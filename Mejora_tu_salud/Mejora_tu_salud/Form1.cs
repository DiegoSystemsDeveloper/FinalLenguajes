﻿using System;
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
    public partial class Inicio : Form
    {
        BD bd = new BD();
        DataTable table = new DataTable();

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                MessageBox.Show("Por favor ingrese su usuario", "Completar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor ingrese su contraseña", "Completar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (bd.Usuario1.Equals(txtUsuario.Text) && bd.Contrasena1.Equals(txtContrasena.Text))
                {
                    Administrador admin = new Administrador(this);
                    admin.Show();
                    this.Visible = false;
                    txtUsuario.Text = "";
                    txtContrasena.Text = "";
                }
                else
                {
                    table = bd.ingresarAlSistema(txtUsuario.Text, txtContrasena.Text);
                    Boolean bandera = true;
                    try
                    {
                        String usuario = table.Rows[0]["Usuario"].ToString();
                        String contraseña = table.Rows[0]["Contrasena"].ToString();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bandera = false;
                    }

                    if (bandera)
                    {
                        Citas citas = new Citas(this, table.Rows[0]["Nombres"].ToString(), table);
                        citas.Show();
                        this.Visible = false;
                        txtUsuario.Text = "";
                        txtContrasena.Text = "";
                    }
                }
            }
        }
    }
}
