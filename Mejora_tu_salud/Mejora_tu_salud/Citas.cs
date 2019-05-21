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
        Form cerrado;

        public Citas(Form form)
        {
            InitializeComponent();
            cerrado = form;
        }

        private void Citas_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrado.Visible = true;
        }
    }
}
