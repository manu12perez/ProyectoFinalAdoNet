using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ProyectoFinalAdoNet.Helpers;
using System.Data;
using ProyectoFinalAdoNet.Models;

#region PROCEDIMIENTOS ALMACENADOS
/*
create procedure SP_ALL_DEPARTAMENTOSP
as
	select * from DEPT
go
 
alter procedure SP_GET_INFO_DEPT
(@nombredept nvarchar(50), @id int out, @nombre nvarchar(50) out, @loc nvarchar(50) out)
as
	select @id = DEPT_NO, @nombre = DNOMBRE, @loc = LOC from DEPT where DNOMBRE = @nombredept;

select* from EMP where DEPT_NO = @id;

go
declare @id int, @nombre nvarchar(50), @loc nvarchar(50)
exec SP_GET_INFO_DEPT 'CONTABILIDAD', @id out, @nombre out, @loc out
print @nombre
print @loc
 
 
alter procedure SP_INSERT_DEPT
(@id int , @nombre nvarchar(50), @loc nvarchar(50))
as
	declare @existsId int;
select @existsId = DEPT_NO from DEPT where DEPT_NO = @id
 
	if @existsId is null
	begin
		insert into DEPT values(@id, @nombre, @loc);
end
	else
	begin
		print 'YA EXISTE'
	end
go
 
create procedure SP_GET_INFO_EMP
(@apellido nvarchar(50))
as
	select * from EMP where APELLIDO = @apellido
go
 
create procedure SP_UPDATE_EMP
(@id int, @apellido nvarchar(50), @oficio nvarchar(50), @salario int)
as
	update EMP set APELLIDO = @apellido , SALARIO = @salario, OFICIO = @oficio where EMP_NO = @id
go
*/
#endregion

namespace ProyectoFinalAdoNet.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public string mensaje;

        public RepositoryDepartamentosEmpleados()
        {
            this.cn = new SqlConnection(HelperConfig.GetStringConnection());
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.mensaje = "";
            this.cn.InfoMessage += Cn_InfoMessage;

        }

        public async Task<List<string>> GetDepartamentos()
        {
            List<string> departamentos = new List<string>();
            string sql = "SP_ALL_DEPARTAMENTOSP";

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            while(await this.reader.ReadAsync())
            {
                departamentos.Add(this.reader["DNOMBRE"].ToString());
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();

            return departamentos;
        }

        public async Task<Departamento> GetDepartamentosInfo(string nombredept)
        {
            List<Empleados> empleados = new List<Empleados>();
            Departamento dep = new Departamento();

            string sql = "SP_GET_INFO_DEPT";

            this.com.Parameters.AddWithValue("@nombredept", nombredept);

            SqlParameter paramid = new SqlParameter();
            paramid.Direction = ParameterDirection.Output;
            paramid.ParameterName = "@id";
            paramid.Value = 0;
            this.com.Parameters.Add(paramid);

            SqlParameter paramnom = new SqlParameter();
            paramnom.Direction = ParameterDirection.Output;
            paramnom.ParameterName = "@nombre";
            paramnom.Size = 100;
            this.com.Parameters.Add(paramnom);

            SqlParameter paramloc = new SqlParameter();
            paramloc.Direction = ParameterDirection.Output;
            paramloc.ParameterName = "@loc";
            paramloc.Size = 100;
            this.com.Parameters.Add(paramloc);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            while(await this.reader.ReadAsync())
            {
                Empleados em = new Empleados();
                em.id = int.Parse(this.reader["EMP_NO"].ToString());
                em.apellido = this.reader["APELLIDO"].ToString();
                em.oficio = this.reader["OFICIO"].ToString();
                em.salario = int.Parse(this.reader["SALARIO"].ToString());

                empleados.Add(em);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            dep.id = int.Parse(paramid.Value.ToString());
            dep.nombre = paramnom.Value.ToString();
            dep.loc = paramloc.Value.ToString();
            dep.empleados = empleados;

            return dep;
            

        }

        public async Task CreateDepartamento(int id, string n, string l)
        {
            string sql = "SP_INSERT_DEPT";

            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", n);
            this.com.Parameters.AddWithValue("@loc", l);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

        }

        public async Task<Empleados> GetEmpleadoInfoAsync(string apellido)
        {
            string sql = "SP_GET_INFO_EMP";
            Empleados emp = new Empleados();
            this.com.Parameters.AddWithValue("@apellido", apellido);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while(await this.reader.ReadAsync())
            {
                emp.id = int.Parse(this.reader["EMP_NO"].ToString());
                emp.apellido = this.reader["APELLIDO"].ToString();
                emp.oficio = this.reader["OFICIO"].ToString();
                emp.salario = int.Parse(this.reader["SALARIO"].ToString());
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return emp;
        }
        public async Task UpdateEmpleadoAsync(int id, string ape, string ofi, int salar)
        {
            string sql = "SP_UPDATE_EMP";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@apellido", ape);
            this.com.Parameters.AddWithValue("@oficio", ofi);
            this.com.Parameters.AddWithValue("@salario", salar);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

        }
        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.mensaje = e.Message;
        }
    }
}
