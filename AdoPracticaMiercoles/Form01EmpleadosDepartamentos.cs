using AdoPracticaMiercoles.Models;
using AdoPracticaMiercoles.Repositories;
using System.Reflection;
using System.Threading.Tasks;

namespace AdoPracticaMiercoles
{
    public partial class Form01EmpleadosDepartamentos : Form
    {
        RepositoryEmpleadosDepartamento repo;
        public Form01EmpleadosDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleadosDepartamento();
            this.LoadDepartamentos();
        }
        private async Task LoadDepartamentos()
        {
            this.cmbDepartamentos.Items.Clear();
            List<Departamento> departamentos = await this.repo.GetDepartamentos();
            foreach (Departamento dept in departamentos)
            {
                this.cmbDepartamentos.Items.Add(dept.DeptNombre+" - "+dept.DeptLocalidad);
            }
        }
        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DeptNombre = this.cmbDepartamentos.SelectedItem.ToString().Split(" - ")[0];
            string Localidad = this.cmbDepartamentos.SelectedItem.ToString().Split(" - ")[1];
            this.txtDeptNombre.Text = DeptNombre;
            this.txtDeptLocalidad.Text = Localidad;
            this.lstEmpleados.Items.Clear();
            List<Empleados> empleados = await this.repo.GetEmpleadosDepartamento(DeptNombre);
            foreach (Empleados emp in empleados)
            {
                this.lstEmpleados.Items.Add($"{emp.IdEmpleado} - {emp.Apellido} - {emp.Oficio} - {emp.Salario} €");
            }
        }
        private async void btnInsertDepartamento_Click(object sender, EventArgs e)
        {
            string nombre = txtDeptNombre.Text.ToString();
            string localidad = txtDeptLocalidad.Text.ToString();
            int registros = await this.repo.CreateDepartamento(nombre, localidad);
            MessageBox.Show($"Departamento {nombre} insertado, registros {registros}");
            await this.LoadDepartamentos();
        }

        private async void btnUpdateEmpleado_Click(object sender, EventArgs e)
        {
            string textLista = this.lstEmpleados.SelectedItem.ToString();
            int idEmpleado = int.Parse(textLista.Split(" - ")[0]);
            string apellido = this.txtApellido.Text;
            string oficio = this.txtOficio.Text;
            int salario = int.Parse(this.txtSalario.Text);
            int registros = await this.repo.updateEmpleado(idEmpleado,apellido,oficio,salario);
            cmbDepartamentos_SelectedIndexChanged(null,null);
            MessageBox.Show($"registro: { registros}, Apellido cambiado a {apellido} oficio a {oficio} salario a {salario}");
        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstEmpleados.SelectedItem == null) return;

            string nombreDEPT = this.cmbDepartamentos.SelectedItem.ToString().Split(" - ")[0];
            List<Empleados> empleados = await this.repo.GetEmpleadosDepartamento(nombreDEPT);

            string textLista = this.lstEmpleados.SelectedItem.ToString();
            int idEmpleado = int.Parse(textLista.Split(" - ")[0]);

            Empleados emp = empleados.Find(x => x.IdEmpleado == idEmpleado);

            if (emp != null)
            {
                txtApellido.Text = emp.Apellido;
                txtOficio.Text = emp.Oficio;
                txtSalario.Text = emp.Salario.ToString();
            }
        }
    }
}
