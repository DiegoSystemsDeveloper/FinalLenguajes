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
    public partial class Administrador : Form
    {
        BD bd = new BD();
        Form cerrado;

        public Administrador(Form form)
        {
            InitializeComponent();
            cerrado = form;
            dgv.DataSource = bd.listarEmpleados();
        }

        private void Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrado.Visible = true; 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Por favor ingrese el numero de identificacion del empleado.");
            }
            else if(txtNombre.Text == "")
            {
                MessageBox.Show("Por favor ingrese el nombre del empleado");
            }
            else if(txtApellidos.Text == "")
            {
                MessageBox.Show("Por favor ingrese los apellidos del empleado");
            }
            else if(txtUsuario.Text == "")
            {
                MessageBox.Show("Por favor ingrese el usuario del empleado");
            }
            else if(txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor ingrese la contraseña del empleado");
            }
            else if(txtConfirmarContrasena.Text == "")
            {
                MessageBox.Show("Por favor confirme la contraseña del empleado");
            }
            else
            {
                if(txtConfirmarContrasena.Text.Equals(txtContrasena.Text))
                {
                    Boolean seRegistro = true;

                    try
                    {
                        bd.registrarEmpleado(txtId.Text, txtNombre.Text, txtApellidos.Text, txtUsuario.Text, txtContrasena.Text);
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        seRegistro = false;
                    }

                    if(seRegistro)
                    {
                        txtId.Text = "";
                        txtNombre.Text = "";
                        txtApellidos.Text = "";
                        txtUsuario.Text = "";
                        txtContrasena.Text = "";
                        txtConfirmarContrasena.Text = "";
                        dgv.DataSource = bd.listarEmpleados();
                    }
                } 
                else
                {
                    MessageBox.Show("Confirme correctamente la contraseña", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
    }
}
