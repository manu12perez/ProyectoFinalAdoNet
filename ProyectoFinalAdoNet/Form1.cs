using ProyectoFinalAdoNet.Models;
using ProyectoFinalAdoNet.Repositories;

namespace ProyectoFinalAdoNet
{
    public partial class Form1 : Form
    {
        RepositoryDepartamentosEmpleados repository;
        private int idEmpleado;
        public Form1()
        {
            InitializeComponent();
            this.repository = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentos();
            this.idEmpleado = 0;

        }

        private async void LoadDepartamentos()
        {
            List<string> departamentos = await this.repository.GetDepartamentos();
            this.cmbDepartamentos.Items.Clear();
            foreach (string d in departamentos)
            {
                this.cmbDepartamentos.Items.Add(d);
            }
        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departamento departamento = await this.repository.GetDepartamentosInfo(this.cmbDepartamentos.SelectedItem.ToString());
            this.lstEmpleados.Items.Clear();
            foreach (Empleados em in departamento.empleados)
            {
                this.lstEmpleados.Items.Add(em.apellido);
            }

            this.txtId.Text = departamento.id.ToString();
            this.txtLocalidad.Text = departamento.loc;
            this.txtNombre.Text = departamento.nombre;
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            await this.repository.CreateDepartamento
                (int.Parse(this.txtId.Text), this.txtNombre.Text, this.txtLocalidad.Text);
            this.lblMensaje.Text = this.repository.mensaje;
            this.LoadDepartamentos();

        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleados empleado = await this.repository.GetEmpleadoInfoAsync(this.lstEmpleados.SelectedItem.ToString());
            this.idEmpleado = empleado.id;
            this.txtApellido.Text = empleado.apellido;
            this.txtOficio.Text = empleado.oficio;
            this.txtSalario.Text = empleado.salario.ToString();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            await this.repository.UpdateEmpleadoAsync(
                this.idEmpleado,
                this.txtApellido.Text,
                this.txtOficio.Text,
                int.Parse(this.txtSalario.Text));
            this.txtApellido.Clear();
            this.txtOficio.Clear();
            this.txtSalario.Clear();
        }
    }
}
