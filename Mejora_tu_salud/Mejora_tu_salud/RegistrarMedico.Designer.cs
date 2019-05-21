namespace Mejora_tu_salud
{
    partial class RegistrarMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblAnosExperiencia = new System.Windows.Forms.Label();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtAñosExperiencia = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(39, 53);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(127, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Numero de identificacion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(39, 158);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(39, 213);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 3;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(38, 270);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(80, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario por cita:";
            // 
            // lblAnosExperiencia
            // 
            this.lblAnosExperiencia.AutoSize = true;
            this.lblAnosExperiencia.Location = new System.Drawing.Point(39, 326);
            this.lblAnosExperiencia.Name = "lblAnosExperiencia";
            this.lblAnosExperiencia.Size = new System.Drawing.Size(106, 13);
            this.lblAnosExperiencia.TabIndex = 5;
            this.lblAnosExperiencia.Text = "Años de experiencia:";
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(181, 210);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidades.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(181, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 7;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(181, 105);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(121, 20);
            this.txtNombres.TabIndex = 8;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(181, 155);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(121, 20);
            this.txtApellidos.TabIndex = 9;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(181, 267);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(121, 20);
            this.txtSalario.TabIndex = 10;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // txtAñosExperiencia
            // 
            this.txtAñosExperiencia.Location = new System.Drawing.Point(181, 326);
            this.txtAñosExperiencia.Name = "txtAñosExperiencia";
            this.txtAñosExperiencia.Size = new System.Drawing.Size(121, 20);
            this.txtAñosExperiencia.TabIndex = 11;
            this.txtAñosExperiencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAñosExperiencia_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(129, 378);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // RegistrarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 429);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtAñosExperiencia);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.lblAnosExperiencia);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Name = "RegistrarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarMedico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarMedico_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblAnosExperiencia;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtAñosExperiencia;
        private System.Windows.Forms.Button btnRegistrar;
    }
}