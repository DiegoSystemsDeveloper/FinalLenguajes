using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Mejora_tu_salud
{
    class BD
    {
        string Usuario = "admin";
        string Contrasena = "admin";

        String conexion = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ..\..\BD\DB_Mejora_tu_salud.accdb";
        string SQL;
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        public string Contrasena1 { get => Contrasena; set => Contrasena = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }

        public DataTable ingresarAlSistema(string usuario, string contraseña)
        {
            DataTable table = new DataTable();
            SQL = "select * from tbEmpleados where Usuario = '" + usuario + "' AND Contrasena = '" + contraseña + "'";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(table);
            return table;
        }

        public DataTable listarPacientes()
        {
            DataTable pacientes = new DataTable();
            SQL = "select * from tbPacientes";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(pacientes);
            return pacientes;         
        }

        public DataTable listarDoctores()
        {
            DataTable medicos = new DataTable();
            SQL = "select * from tbMedicos";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(medicos);
            return medicos;
        }

        public DataTable listarEmpleados()
        {
            DataTable empleados = new DataTable();
            SQL = "select * from tbEmpleados";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(empleados);
            return empleados;
        }

        public DataTable listarEspecialidades()
        {
            DataTable especialidades = new DataTable();
            SQL = "select * from tbEspecialidades";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(especialidades);
            return especialidades;
        }

        public DataTable buscarEspecialidad(string especialidad)
        {
            DataTable especialidades = new DataTable();
            SQL = "select Nombre from tbEspecialidades where IdEspecialidad = '" + especialidad + "'";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(especialidades);
            return especialidades;
        }

        public DataTable buscarPaciente(string paciente)
        {
            DataTable pacientes = new DataTable();
            SQL = "select * from tbPacientes where Id_paciente = '" + paciente + "'";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(pacientes);
            return pacientes;
        }

        public DataTable buscarMedico(string medico)
        {
            DataTable medicos = new DataTable();
            SQL = "select * from tbMedicos where Id_medico = '" + medico + "'";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(medicos);
            return medicos;
        }

        public void registrarPaciente(string id, string nombre, string apellidos, string fNacimiento, string direccion, string telefono, string fregistro, string empleado)
        {
            DataTable table = new DataTable();
            SQL = "insert into tbPacientes (Id_paciente, Nombres, Apellidos, Fecha_de_nacimiento, Direccion, Teléfono, Fecha_de_registro, Empleado_que_registra) values ('" + id + "', '" + nombre + "', '" + apellidos + "', '" + fNacimiento + "', '" + direccion + "', '" + telefono + "', '" + fregistro + "', '" + empleado + "')";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(table);

            MessageBox.Show("Se ha registrado exitosamente el nuevo paciente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void registrarMedico(string id, string nombre, string apellidos, string especialidad, double salario, int experiencia)
        {
            DataTable medicos = new DataTable();
            SQL = "insert into tbMedicos (Id_medico, Nombres, Apellidos, IdEspecialidad, Salario_por_cita, Anos_de_experiencia) values ('" + id + "', '" + nombre + "', '" + apellidos + "', '" + especialidad + "', '" + salario + "', '" + experiencia + "')";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(medicos);

            MessageBox.Show("Se ha registrado exitosamente el nuevo medico.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void registrarEmpleado(string id, string nombre, string apellidos, string usuario, string contrasena)
        {
            DataTable empleados = new DataTable();
            SQL = "insert into tbEmpleados (IdEmpleado, Nombres, Apellidos, Usuario, Contrasena) values ('" + id + "', '" + nombre + "', '" + apellidos + "', '" + usuario + "', '" + contrasena + "')";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(empleados);

            MessageBox.Show("Se ha registrado exitosamente el nuevo empleado.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void actualizarMedico(string nombre, string salario, string idMedico)
        {
            DataTable medicos = new DataTable();
            SQL = "update tbMedicos set Nombres = '" + nombre + "', Salario_por_cita = '" + salario + "' where Id_medico = '" + idMedico + "'";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(medicos);

            MessageBox.Show("Se ha actualizado el medico");
        }

        public void actualizarPaciente(string telefono, string Direccion, string idPaciente)
        {
            DataTable pacientes = new DataTable();
            SQL = "update tbPacientes set Teléfono = '" + telefono + "', Direccion = '" + Direccion + "' where Id_paciente = '" + idPaciente + "'";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(pacientes);

            MessageBox.Show("Se ha actualizado el paciente");
        }
    }
}
