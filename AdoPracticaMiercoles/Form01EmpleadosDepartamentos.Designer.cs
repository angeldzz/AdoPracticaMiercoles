namespace AdoPracticaMiercoles
{
    partial class Form01EmpleadosDepartamentos
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
            btnInsertDepartamento = new Button();
            cmbDepartamentos = new ComboBox();
            lstEmpleados = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtDeptLocalidad = new TextBox();
            label4 = new Label();
            txtDeptNombre = new TextBox();
            label5 = new Label();
            txtOficio = new TextBox();
            label6 = new Label();
            txtSalario = new TextBox();
            label7 = new Label();
            txtApellido = new TextBox();
            label8 = new Label();
            btnUpdateEmpleado = new Button();
            SuspendLayout();
            // 
            // btnInsertDepartamento
            // 
            btnInsertDepartamento.Location = new Point(12, 159);
            btnInsertDepartamento.Name = "btnInsertDepartamento";
            btnInsertDepartamento.Size = new Size(134, 42);
            btnInsertDepartamento.TabIndex = 1;
            btnInsertDepartamento.Text = "Insert Departamento";
            btnInsertDepartamento.UseVisualStyleBackColor = true;
            btnInsertDepartamento.Click += btnInsertDepartamento_Click;
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(12, 30);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(121, 23);
            cmbDepartamentos.TabIndex = 2;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(179, 30);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(292, 289);
            lstEmpleados.TabIndex = 3;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 12);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 4;
            label1.Text = "Empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 5;
            label2.Text = "Departamentos";
            // 
            // txtDeptLocalidad
            // 
            txtDeptLocalidad.Location = new Point(12, 130);
            txtDeptLocalidad.Name = "txtDeptLocalidad";
            txtDeptLocalidad.Size = new Size(133, 23);
            txtDeptLocalidad.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "Localidad";
            // 
            // txtDeptNombre
            // 
            txtDeptNombre.Location = new Point(12, 80);
            txtDeptNombre.Name = "txtDeptNombre";
            txtDeptNombre.Size = new Size(134, 23);
            txtDeptNombre.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 62);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Nombre";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(498, 80);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(134, 23);
            txtOficio.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 62);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 17;
            label6.Text = "Oficio";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(498, 130);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(134, 23);
            txtSalario.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(498, 112);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 15;
            label7.Text = "Salario";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(498, 33);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(134, 23);
            txtApellido.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(498, 15);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 13;
            label8.Text = "Apellido";
            // 
            // btnUpdateEmpleado
            // 
            btnUpdateEmpleado.Location = new Point(498, 159);
            btnUpdateEmpleado.Name = "btnUpdateEmpleado";
            btnUpdateEmpleado.Size = new Size(134, 42);
            btnUpdateEmpleado.TabIndex = 12;
            btnUpdateEmpleado.Text = "Update Empleado";
            btnUpdateEmpleado.UseVisualStyleBackColor = true;
            btnUpdateEmpleado.Click += btnUpdateEmpleado_Click;
            // 
            // Form01EmpleadosDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 353);
            Controls.Add(txtOficio);
            Controls.Add(label6);
            Controls.Add(txtSalario);
            Controls.Add(label7);
            Controls.Add(txtApellido);
            Controls.Add(label8);
            Controls.Add(btnUpdateEmpleado);
            Controls.Add(txtDeptNombre);
            Controls.Add(label5);
            Controls.Add(txtDeptLocalidad);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstEmpleados);
            Controls.Add(cmbDepartamentos);
            Controls.Add(btnInsertDepartamento);
            Name = "Form01EmpleadosDepartamentos";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnInsertDepartamento;
        private ComboBox cmbDepartamentos;
        private ListBox lstEmpleados;
        private Label label1;
        private Label label2;
        private TextBox txtDeptLocalidad;
        private Label label4;
        private TextBox txtDeptNombre;
        private Label label5;
        private TextBox txtOficio;
        private Label label6;
        private TextBox txtSalario;
        private Label label7;
        private TextBox txtApellido;
        private Label label8;
        private Button btnUpdateEmpleado;
    }
}
