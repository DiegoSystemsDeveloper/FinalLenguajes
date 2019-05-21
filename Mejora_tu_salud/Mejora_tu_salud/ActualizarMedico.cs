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
    public partial class ActualizarMedico : Form
    {
        BD bd = new BD();
        Form cerrada;
        string idMedico;

        public ActualizarMedico(string nombreMedico, string idMedico, string salario, Form form)
        {
            InitializeComponent();
            cerrada = form;
            lblMedico.Text = "Nombre Actual: " + nombreMedico;
            lblSalarioMedico.Text = "Salario Actual: $ " + salario;
            this.idMedico = idMedico;
        }

        private void ActualizarMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrada.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                MessageBox.Show("Por favor completa los datos a actualizar", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtSalario.Text == "")
            {
                MessageBox.Show("Por favor completa los datos a actualizar", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bd.actualizarMedico(txtNombre.Text, txtSalario.Text, idMedico);

                txtNombre.Text = "";
                txtSalario.Text = "";
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
    }
}
