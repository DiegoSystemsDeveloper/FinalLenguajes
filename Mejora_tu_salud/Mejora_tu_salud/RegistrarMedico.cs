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
    public partial class RegistrarMedico : Form
    {
        BD bd = new BD();
        Form cerrada;
        string idMedico;

        public RegistrarMedico(Form form)
        {
            InitializeComponent();
            cerrada = form;
            txtSalario.Text = "0";
            txtAñosExperiencia.Text = "0";

            cmbEspecialidades.DataSource = bd.listarEspecialidades();
            cmbEspecialidades.DisplayMember = "Nombre";
            cmbEspecialidades.ValueMember = "IdEspecialidad";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Por favor ingresa el numero de identificacion del medico");
            }
            else if(txtNombres.Text == "")
            {
                MessageBox.Show("Por favor ingresa el nombre del medico");
            }
            else if(txtApellidos.Text == "")
            {
                MessageBox.Show("Por favor ingresa los apellidos del medico");
            }
            else if(txtSalario.Text == "")
            {
                MessageBox.Show("Por favor ingresa el salario del medico");
            }
            else if(txtAñosExperiencia.Text == "")
            {
                MessageBox.Show("Por favor ingresa los años de experiencia del medico");
            }
            else if(cmbEspecialidades.Text == "")
            {
                MessageBox.Show("Por favor ingresa la especialidad del medico");
            }
            else
            {
                int experiencia = Convert.ToInt16(txtAñosExperiencia.Text);
                double salario = double.Parse(txtSalario.Text);

                if(experiencia <= 50 )
                {
                    if(salario < 10000000)
                    {
                        Boolean bandera = true;

                        try
                        {
                            bd.registrarMedico(txtId.Text, txtNombres.Text, txtApellidos.Text, cmbEspecialidades.SelectedValue.ToString(), salario, experiencia);
                        }
                        catch(Exception exc)
                        {
                            MessageBox.Show("Ya se encuentra registrado ese numero de identificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            bandera = false;
                        }

                        if(bandera)
                        {
                            txtId.Text = "";
                            txtNombres.Text = "";
                            txtApellidos.Text = "";
                            txtSalario.Text = "";
                            txtAñosExperiencia.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El salario es demasiado alto, por favor verifique los datos");
                    }
                }
                else
                {
                    MessageBox.Show("La experiencia no tiene datos congruentes");
                }
            }
        }

        private void RegistrarMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrada.Visible = true;
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

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAñosExperiencia_KeyPress(object sender, KeyPressEventArgs e)
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
