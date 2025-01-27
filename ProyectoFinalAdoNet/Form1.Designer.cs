namespace ProyectoFinalAdoNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            txtApellido = new TextBox();
            txtOficio = new TextBox();
            txtSalario = new TextBox();
            txtLocalidad = new TextBox();
            txtNombre = new TextBox();
            cmbDepartamentos = new ComboBox();
            lstEmpleados = new ListBox();
            btnInsertar = new Button();
            btnModificar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 38);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Deparatementos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(570, 120);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "OFICIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 38);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 38);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "EMPLEADOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 256);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "LOCALIDAD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 181);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "NOMBRE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 111);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 6;
            label7.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(570, 208);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 7;
            label8.Text = "SALARIO";
            // 
            // txtId
            // 
            txtId.Location = new Point(62, 134);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(570, 61);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 11;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(570, 143);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(125, 27);
            txtOficio.TabIndex = 12;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(570, 236);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(125, 27);
            txtSalario.TabIndex = 13;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(62, 279);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(125, 27);
            txtLocalidad.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(62, 212);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 15;
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(62, 61);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(151, 28);
            cmbDepartamentos.TabIndex = 16;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(291, 76);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(222, 244);
            lstEmpleados.TabIndex = 17;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(78, 322);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(580, 291);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(100, 9);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 20;
            lblMensaje.Text = "label9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 363);
            Controls.Add(lblMensaje);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(lstEmpleados);
            Controls.Add(cmbDepartamentos);
            Controls.Add(txtNombre);
            Controls.Add(txtLocalidad);
            Controls.Add(txtSalario);
            Controls.Add(txtOficio);
            Controls.Add(txtApellido);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtId;
        private TextBox txtApellido;
        private TextBox txtOficio;
        private TextBox txtSalario;
        private TextBox txtLocalidad;
        private TextBox txtNombre;
        private ComboBox cmbDepartamentos;
        private ListBox lstEmpleados;
        private Button btnInsertar;
        private Button btnModificar;
        private Label lblMensaje;
    }
}
