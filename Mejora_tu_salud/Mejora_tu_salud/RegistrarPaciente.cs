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
    public partial class RegistrarPaciente : Form
    {
        BD bd = new BD();
        Form cerrado;
        DataTable empleado = new DataTable();
        String idEmpleado;

        public RegistrarPaciente(Form form, DataTable empleado)
        {
            InitializeComponent();
            cerrado = form;
            txtEmpleado.Text = empleado.Rows[0]["Nombres"].ToString();
            idEmpleado = empleado.Rows[0][0].ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Por favor ingresa el numero de identificacion del paciente");
            }
            else if(txtNombre.Text == "")
            {
                MessageBox.Show("Por favor ingresa el nombre del paciente");
            }
            else if(txtApellidos.Text == "")
            {
                MessageBox.Show("Por favor ingresa los apellidos del paciente");
            }
            else if(dtpNacimiento.Text == "")
            {
                MessageBox.Show("Por favor ingresa la fecha de nacimiento del paciente");
            }
            else if(dtpRegistro.Text == "")
            {
                MessageBox.Show("Por favor ingresa la fecha del registro");
            }
            else
            {
                Boolean bandera = true;

                try
                {
                    bd.registrarPaciente(txtId.Text, txtNombre.Text, txtApellidos.Text, dtpNacimiento.Text, txtDireccion.Text, txtTelefono.Text, dtpRegistro.Text, idEmpleado);
                }
                catch(Exception exc)
                {
                    MessageBox.Show("El numero de identificacion ya se encuentra resgistrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bandera = false;
                }

                if(bandera)
                {
                    txtId.Text = "";
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                }
            }
        }

        private void RegistrarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrado.Visible = true;
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
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
