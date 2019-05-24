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
        const int LIMITE_DE_CITAS = 2;

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

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            RegistrarMedico registrarMedico = new RegistrarMedico(this);
            registrarMedico.Show();
            this.Visible = false;
        }

        private void btnActualizarMedico_Click(object sender, EventArgs e)
        {
            ActualizarMedico actualizarMedico = new ActualizarMedico(bd.buscarMedico(cmbMedico.Text).Rows[0]["Nombres"].ToString(), bd.buscarMedico(cmbMedico.Text).Rows[0]["Id_medico"].ToString(), bd.buscarMedico(cmbMedico.Text).Rows[0]["Salario_por_cita"].ToString(), this);
            actualizarMedico.Show();
            this.Visible = false; 
        }

        private void btnActualizarPaciente_Click(object sender, EventArgs e)
        {
            ActualizarPaciente actualizarPaciente = new ActualizarPaciente(bd.buscarPaciente(cmbPaciente.Text).Rows[0]["Id_paciente"].ToString(), bd.buscarPaciente(cmbPaciente.Text).Rows[0]["Nombres"].ToString(), bd.buscarPaciente(cmbPaciente.Text).Rows[0]["Direccion"].ToString(), bd.buscarPaciente(cmbPaciente.Text).Rows[0]["Teléfono"].ToString(), this);
            actualizarPaciente.Show();
            this.Visible = false;
        }

        private void btnVerCitas_Click(object sender, EventArgs e)
        {
            VerCita verCita = new VerCita(bd.buscarPaciente(cmbPaciente.Text).Rows[0]["Id_paciente"].ToString(), bd.buscarPaciente(cmbPaciente.Text).Rows[0]["Nombres"].ToString(), this);
            verCita.Show();
            this.Visible = false;
        }

        private void btnSolicitarCita_Click(object sender, EventArgs e)
        {
            int citasDelCliente = bd.buscarCitasPaciente(cmbPaciente.Text).Rows.Count;

            if(citasDelCliente < LIMITE_DE_CITAS)
            {
                Boolean existeRegistro = true;
                string idMedicoRegistrado = null;

                try
                {
                    idMedicoRegistrado = bd.buscarCitasPaciente(cmbPaciente.Text).Rows[0]["Id_medico"].ToString(); 
                }
                catch(Exception exc)
                {
                    existeRegistro = false;
                }

                if(existeRegistro)
                {
                    string idEspecialidadRegistrada = bd.buscarEspecialidad(bd.buscarMedico(idMedicoRegistrado).Rows[0]["IdEspecialidad"].ToString()).Rows[0]["IdEspecialidad"].ToString();
                    string idEspecialidadNOregistrada = bd.buscarEspecialidad(bd.buscarMedico(cmbMedico.Text).Rows[0]["IdEspecialidad"].ToString()).Rows[0]["IdEspecialidad"].ToString();

                    if (idEspecialidadRegistrada.Equals(idEspecialidadNOregistrada))
                    {
                        MessageBox.Show("Ya existe una cita que tiene el mismo tipo de especialidad", "Citas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        registrarCita();
                    }
                }
                else
                {   
                    registrarCita();
                }
            }
            else
            {
                MessageBox.Show("Solo se permiten " + LIMITE_DE_CITAS + " citas por especialidad.");
            }
        }

        public void registrarCita()
        {
            string nombreMedico = txtNombreMedico.Text;
            string nombrePaciente = txtNombrePaciente.Text;
            string apellidosPaciente = txtApellidosPaciente.Text;
            string especialidadMedico = txtEspecialidad.Text;
            string fecha = dtpFecha.Text;
            string hora = dtpHora.Text;

            DialogResult res = MessageBox.Show("Datos de la cita: " + "\n\n" +
                                               "Nombre del paciente: " + nombrePaciente + "\n" +
                                               "Apellidos del paciente: " + apellidosPaciente + "\n" +
                                               "Medico que atenderá: " + nombreMedico + "\n" +
                                               "Especialidad del medico : " + especialidadMedico + "\n\n" +
                                               "Fecha: " + fecha + "\n" +
                                               "Hora: " + hora + "\n\n" +
                                               "¿Está seguro de registrar esta cita?",
            "Registro de citas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                bd.registrarCita(cmbPaciente.Text, cmbMedico.Text, dtpFecha.Text, dtpHora.Text);
            }
            else
            {
                MessageBox.Show("La cita ha sido cancelada", "Cita cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
