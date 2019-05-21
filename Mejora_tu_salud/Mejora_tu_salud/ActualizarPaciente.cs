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
    public partial class ActualizarPaciente : Form
    {
        Form cerrada;
        BD bd = new BD();
        string idPaciente;

        public ActualizarPaciente(string idPaciente, string nombrePaciente, string direccion, string telefono, Form form)
        {
            InitializeComponent();
            cerrada = form;
            lblPaciente.Text = "Paciente: " + nombrePaciente;
            lblDireccion.Text = "Direccion Actual: " + direccion;
            lblTelefono.Text = "Telefono Actual: " + telefono;
            this.idPaciente = idPaciente;
        }

        private void ActualizarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrada.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtDireccion.Text == "")
            {
                MessageBox.Show("Faltan campos por completar", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtTelefono.Text == "")
            {
                MessageBox.Show("Faltan campos por completar", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bd.actualizarPaciente(txtTelefono.Text, txtDireccion.Text, idPaciente);
                txtDireccion.Text = "";
                txtTelefono.Text = "";
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
