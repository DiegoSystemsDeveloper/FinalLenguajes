namespace Mejora_tu_salud
{
    partial class Citas
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
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.gboxPaciente = new System.Windows.Forms.GroupBox();
            this.gboxMedicos = new System.Windows.Forms.GroupBox();
            this.btnRegistroPaciente = new System.Windows.Forms.Button();
            this.btnActualizarPaciente = new System.Windows.Forms.Button();
            this.btnVerCitas = new System.Windows.Forms.Button();
            this.btnRegistrarMedico = new System.Windows.Forms.Button();
            this.btnActualizarMedico = new System.Windows.Forms.Button();
            this.btnValorApagar = new System.Windows.Forms.Button();
            this.lblRegistrarCita = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtApellidosPaciente = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreMedico = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.btnSolicitarCita = new System.Windows.Forms.Button();
            this.gboxPaciente.SuspendLayout();
            this.gboxMedicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(19, 9);
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(0, 39);
            this.lblNombreEmpleado.TabIndex = 0;
            // 
            // gboxPaciente
            // 
            this.gboxPaciente.Controls.Add(this.btnVerCitas);
            this.gboxPaciente.Controls.Add(this.btnActualizarPaciente);
            this.gboxPaciente.Controls.Add(this.btnRegistroPaciente);
            this.gboxPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPaciente.Location = new System.Drawing.Point(26, 254);
            this.gboxPaciente.Name = "gboxPaciente";
            this.gboxPaciente.Size = new System.Drawing.Size(287, 169);
            this.gboxPaciente.TabIndex = 1;
            this.gboxPaciente.TabStop = false;
            this.gboxPaciente.Text = "Acciones Paciente";
            // 
            // gboxMedicos
            // 
            this.gboxMedicos.Controls.Add(this.btnValorApagar);
            this.gboxMedicos.Controls.Add(this.btnActualizarMedico);
            this.gboxMedicos.Controls.Add(this.btnRegistrarMedico);
            this.gboxMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxMedicos.Location = new System.Drawing.Point(336, 254);
            this.gboxMedicos.Name = "gboxMedicos";
            this.gboxMedicos.Size = new System.Drawing.Size(287, 169);
            this.gboxMedicos.TabIndex = 2;
            this.gboxMedicos.TabStop = false;
            this.gboxMedicos.Text = "Acciones Medicos";
            // 
            // btnRegistroPaciente
            // 
            this.btnRegistroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroPaciente.Location = new System.Drawing.Point(7, 22);
            this.btnRegistroPaciente.Name = "btnRegistroPaciente";
            this.btnRegistroPaciente.Size = new System.Drawing.Size(113, 41);
            this.btnRegistroPaciente.TabIndex = 0;
            this.btnRegistroPaciente.Text = "Registrar";
            this.btnRegistroPaciente.UseVisualStyleBackColor = true;
            this.btnRegistroPaciente.Click += new System.EventHandler(this.btnRegistroPaciente_Click);
            // 
            // btnActualizarPaciente
            // 
            this.btnActualizarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPaciente.Location = new System.Drawing.Point(152, 22);
            this.btnActualizarPaciente.Name = "btnActualizarPaciente";
            this.btnActualizarPaciente.Size = new System.Drawing.Size(113, 41);
            this.btnActualizarPaciente.TabIndex = 1;
            this.btnActualizarPaciente.Text = "Actualizar";
            this.btnActualizarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnVerCitas
            // 
            this.btnVerCitas.Location = new System.Drawing.Point(78, 95);
            this.btnVerCitas.Name = "btnVerCitas";
            this.btnVerCitas.Size = new System.Drawing.Size(121, 42);
            this.btnVerCitas.TabIndex = 2;
            this.btnVerCitas.Text = "Citas";
            this.btnVerCitas.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMedico
            // 
            this.btnRegistrarMedico.Location = new System.Drawing.Point(6, 21);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.Size = new System.Drawing.Size(113, 41);
            this.btnRegistrarMedico.TabIndex = 0;
            this.btnRegistrarMedico.Text = "Registrar";
            this.btnRegistrarMedico.UseVisualStyleBackColor = true;
            // 
            // btnActualizarMedico
            // 
            this.btnActualizarMedico.Location = new System.Drawing.Point(155, 21);
            this.btnActualizarMedico.Name = "btnActualizarMedico";
            this.btnActualizarMedico.Size = new System.Drawing.Size(113, 41);
            this.btnActualizarMedico.TabIndex = 1;
            this.btnActualizarMedico.Text = "Actualizar";
            this.btnActualizarMedico.UseVisualStyleBackColor = true;
            // 
            // btnValorApagar
            // 
            this.btnValorApagar.Location = new System.Drawing.Point(77, 95);
            this.btnValorApagar.Name = "btnValorApagar";
            this.btnValorApagar.Size = new System.Drawing.Size(121, 42);
            this.btnValorApagar.TabIndex = 2;
            this.btnValorApagar.Text = "Ver salario";
            this.btnValorApagar.UseVisualStyleBackColor = true;
            this.btnValorApagar.Click += new System.EventHandler(this.btnValorApagar_Click);
            // 
            // lblRegistrarCita
            // 
            this.lblRegistrarCita.AutoSize = true;
            this.lblRegistrarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarCita.Location = new System.Drawing.Point(29, 68);
            this.lblRegistrarCita.Name = "lblRegistrarCita";
            this.lblRegistrarCita.Size = new System.Drawing.Size(131, 24);
            this.lblRegistrarCita.TabIndex = 3;
            this.lblRegistrarCita.Text = "Registrar cita";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(33, 110);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(113, 26);
            this.cmbPaciente.TabIndex = 4;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // cmbMedico
            // 
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(191, 110);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(113, 26);
            this.cmbMedico.TabIndex = 5;
            this.cmbMedico.SelectedIndexChanged += new System.EventHandler(this.cmbMedico_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(357, 112);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(113, 24);
            this.dtpFecha.TabIndex = 6;
            // 
            // dtpHora
            // 
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(491, 112);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(113, 24);
            this.dtpHora.TabIndex = 7;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(112, 162);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.ReadOnly = true;
            this.txtNombrePaciente.Size = new System.Drawing.Size(113, 24);
            this.txtNombrePaciente.TabIndex = 8;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMedico.Location = new System.Drawing.Point(373, 159);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.ReadOnly = true;
            this.txtNombreMedico.Size = new System.Drawing.Size(113, 24);
            this.txtNombreMedico.TabIndex = 9;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(373, 214);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(113, 24);
            this.txtEspecialidad.TabIndex = 10;
            // 
            // txtApellidosPaciente
            // 
            this.txtApellidosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosPaciente.Location = new System.Drawing.Point(112, 214);
            this.txtApellidosPaciente.Name = "txtApellidosPaciente";
            this.txtApellidosPaciente.ReadOnly = true;
            this.txtApellidosPaciente.Size = new System.Drawing.Size(113, 24);
            this.txtApellidosPaciente.TabIndex = 11;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.Location = new System.Drawing.Point(29, 165);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(70, 18);
            this.lblNombrePaciente.TabIndex = 12;
            this.lblNombrePaciente.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Apellido:";
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AutoSize = true;
            this.lblNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedico.Location = new System.Drawing.Point(255, 165);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.Size = new System.Drawing.Size(108, 16);
            this.lblNombreMedico.TabIndex = 14;
            this.lblNombreMedico.Text = "Nombre Medico:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(255, 218);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(95, 18);
            this.lblEspecialidad.TabIndex = 15;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // btnSolicitarCita
            // 
            this.btnSolicitarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarCita.Location = new System.Drawing.Point(507, 159);
            this.btnSolicitarCita.Name = "btnSolicitarCita";
            this.btnSolicitarCita.Size = new System.Drawing.Size(105, 79);
            this.btnSolicitarCita.TabIndex = 16;
            this.btnSolicitarCita.Text = "Solicitar cita";
            this.btnSolicitarCita.UseVisualStyleBackColor = true;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 435);
            this.Controls.Add(this.btnSolicitarCita);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblNombreMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.txtApellidosPaciente);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.lblRegistrarCita);
            this.Controls.Add(this.gboxMedicos);
            this.Controls.Add(this.gboxPaciente);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Citas_FormClosing);
            this.Load += new System.EventHandler(this.Citas_Load);
            this.gboxPaciente.ResumeLayout(false);
            this.gboxMedicos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.GroupBox gboxPaciente;
        private System.Windows.Forms.Button btnVerCitas;
        private System.Windows.Forms.Button btnActualizarPaciente;
        private System.Windows.Forms.Button btnRegistroPaciente;
        private System.Windows.Forms.GroupBox gboxMedicos;
        private System.Windows.Forms.Button btnValorApagar;
        private System.Windows.Forms.Button btnActualizarMedico;
        private System.Windows.Forms.Button btnRegistrarMedico;
        private System.Windows.Forms.Label lblRegistrarCita;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtApellidosPaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreMedico;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnSolicitarCita;
    }
}