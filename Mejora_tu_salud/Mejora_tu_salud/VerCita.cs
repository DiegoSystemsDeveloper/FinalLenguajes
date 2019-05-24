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
    public partial class VerCita : Form
    {
        BD bd = new BD();
        Form cerrada;
        String idPaciente;

        public VerCita(string idPaciente, string nombrePaciente, Form form)
        {
            InitializeComponent();
            cerrada = form;
            this.idPaciente = idPaciente;
            lblCitasPaciente.Text = "Estas son las citas de " + nombrePaciente;
            dgvCitasPaciente.DataSource = bd.buscarCitasPaciente(idPaciente);
        }

        private void VerCita_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrada.Visible = true;
        }
    }
}
