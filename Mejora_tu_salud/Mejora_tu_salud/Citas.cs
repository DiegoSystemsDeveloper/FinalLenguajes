using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mejora_tu_salud
{
    public partial class Citas : Form
    {
        BD bd = new BD();
        Form cerrado;
        DataTable pacientes = new DataTable();
        DataTable medicos = new DataTable();
        DataTable empleado = new DataTable();

        Boolean sePuede = false;

        public Citas(Form form, string nombreEmpleado, DataTable empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            cerrado = form;
            lblNombreEmpleado.Text = "Bienvenido " + nombreEmpleado;
        }

        private void Citas_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrado.Visible = true;
        }

        private void Citas_Load(object sender, EventArgs e)
        {

            pacientes = bd.listarPacientes();
            medicos = bd.listarDoctores();

            cmbPaciente.DataSource = pacientes;
            cmbPaciente.DisplayMember = "Id_paciente";
            cmbPaciente.ValueMember = "Nombres";

            cmbMedico.DataSource = medicos;
            cmbMedico.DisplayMember = "Id_medico";
            cmbMedico.ValueMember = "Nombres";
           
            txtNombrePaciente.Text = cmbPaciente.SelectedValue.ToString();
            txtApellidosPaciente.Text = bd.buscarPaciente(cmbPaciente.Text).Rows[0]["Apellidos"].ToString();
            txtNombreMedico.Text = cmbMedico.SelectedValue.ToString();
            txtEspecialidad.Text = bd.buscarEspecialidad(bd.buscarMedico(cmbMedico.Text).Rows[0]["IdEspecialidad"].ToString()).Rows[0]["Nombre"].ToString();

            sePuede = true;
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sePuede)
            {
                txtNombrePaciente.Text = bd.buscarPaciente(cmbPaciente.Text).Rows[0]["Nombres"].ToString();
                txtApellidosPaciente.Text = bd.buscarPaciente(cmbPaciente.Text).Rows[0]["Apellidos"].ToString();
            }           
        }      

        private void cmbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sePuede)
            {
                txtNombreMedico.Text = bd.buscarMedico(cmbMedico.Text).Rows[0]["Nombres"].ToString();
                txtEspecialidad.Text = bd.buscarEspecialidad(bd.buscarMedico(cmbMedico.Text).Rows[0]["IdEspecialidad"].ToString()).Rows[0]["Nombre"].ToString();
            }
        }

        private void btnValorApagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El medico " + txtNombreMedico.Text  + " que es de la " + "\n" +
                            "Especialidad de " + txtEspecialidad.Text + " tiene un salario" + "\n" +
                            "Por cita de: $ " + bd.buscarMedico(cmbMedico.Text).Rows[0]["Salario_por_cita"].ToString() + " pesos.",
                            "Salario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegistroPaciente_Click(object sender, EventArgs e)
        {
            RegistrarPaciente registrarPaciente = new RegistrarPaciente(this, empleado);
            registrarPaciente.Visible = true;
            this.Visible = false;
        }
    }
}
