using AdoPracticaMiercoles.Helper;
using AdoPracticaMiercoles.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace AdoPracticaMiercoles.Repositories
{
#region STORED PROCEDURE
/*
create procedure SP_ALL_DEPARTAMENTOS
AS
select * from DEPT
GO
create procedure SP_EMPLEADO_DEPARTAMENTO
(@nombre nvarchar(50))
AS
declare @idDept int
select @idDept = DEPT.DEPT_NO from DEPT where DNOMBRE = @nombre
select * from EMP where EMP.DEPT_NO = @idDept
GO
create procedure SP_INSERT_DEPARTAMENTO
(@nombre nvarchar(50), @localidad nvarchar(50))
AS
DECLARE @id int
select @id = (MAX(DEPT_NO) + 1) from DEPT
INSERT INTO DEPT VALUES(@id, @nombre, @localidad)
GO

create procedure SP_UPDATE_EMPLEADO
(@idemp int,@apellido nvarchar(50),@oficio nvarchar(50),@salario int)
AS
UPDATE EMP SET APELLIDO=@apellido, OFICIO=@oficio,SALARIO=@salario  WHERE EMP_NO = @idemp
GO
---------------------------
--PRUEBAS DE PROCEDIMIENTOS
---------------------------
EXEC SP_ALL_DEPARTAMENTOS
exec SP_INSERT_DEPARTAMENTO 'ANGEL','MADRID'
exec SP_EMPLEADO_DEPARTAMENTO 'CONTABILIDAD'
exec SP_UPDATE_EMPLEADO 7782,'PINTO','GERENTE',300000


    */
#endregion
    public class RepositoryEmpleadosDepartamento
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public RepositoryEmpleadosDepartamento()
        {
            IConfiguration configuration = HelperConfiguration.GetConfiguration();
            string connectionstring = configuration.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionstring);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public async Task<List<Departamento>> GetDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Departamento> departamentos = new List<Departamento>();
            while (await this.reader.ReadAsync())
            {
                Departamento dept = new Departamento();
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                dept.DeptNombre = nombre;
                dept.DeptLocalidad = localidad;
                departamentos.Add(dept);
            }
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();

            return departamentos;
        }
        public async Task<List<Empleados>> GetEmpleadosDepartamento(string nombreDepartamento)
        {
            string sql = "SP_EMPLEADO_DEPARTAMENTO";
            SqlParameter pamNombre = new SqlParameter();
            pamNombre.ParameterName = "@nombre";
            pamNombre.Value = nombreDepartamento;
            this.com.Parameters.Add(pamNombre);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Empleados> empleados = new List<Empleados>();
            while (await this.reader.ReadAsync())
            {
                Empleados emp = new Empleados();
                string idEmpleado = this.reader["EMP_NO"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                emp.IdEmpleado = int.Parse(idEmpleado);
                emp.Apellido = apellido;
                emp.Oficio = oficio;
                emp.Salario = int.Parse(salario);
                empleados.Add(emp);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }
        public async Task<int> CreateDepartamento(string DeptNombre, string localidad) {
            string sql = "SP_INSERT_DEPARTAMENTO";
            SqlParameter pamNombre = new SqlParameter();
            pamNombre.ParameterName = "@nombre";
            pamNombre.Value = DeptNombre;
            this.com.Parameters.Add(pamNombre);
            SqlParameter pamLocalidad = new SqlParameter();
            pamLocalidad.ParameterName = "@localidad";
            pamLocalidad.Value = localidad;
            this.com.Parameters.Add(pamLocalidad);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            this.com.Parameters.Clear();
            await this.cn.CloseAsync();
            return registros;
        }
        public async Task<int> updateEmpleado(int idEmp,string apellido, string oficio,int salario)
        {
            string sql = "SP_UPDATE_EMPLEADO";
            SqlParameter pamIdEmp = new SqlParameter();
            pamIdEmp.ParameterName = "@idemp";
            pamIdEmp.Value = idEmp;
            this.com.Parameters.Add(pamIdEmp);
            SqlParameter pamApellido = new SqlParameter();
            pamApellido.ParameterName = "@apellido";
            pamApellido.Value = apellido;
            this.com.Parameters.Add(pamApellido);
            SqlParameter pamOficio = new SqlParameter();
            pamOficio.ParameterName = "@oficio";
            pamOficio.Value = oficio;
            this.com.Parameters.Add(pamOficio);
            SqlParameter pamSalario = new SqlParameter();
            pamSalario.ParameterName = "@salario";
            pamSalario.Value = salario;
            this.com.Parameters.Add(pamSalario);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            this.com.Parameters.Clear();
            await this.cn.CloseAsync();
            return registros;
        }
    }
}
