namespace Mejora_tu_salud
{
    partial class ActualizarMedico
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
            this.lblNombreMedico = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblSalarioMedico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AutoSize = true;
            this.lblNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedico.Location = new System.Drawing.Point(90, 85);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.Size = new System.Drawing.Size(62, 15);
            this.lblNombreMedico.TabIndex = 0;
            this.lblNombreMedico.Text = "Nombre:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(90, 139);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(57, 15);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salario:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(217, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(217, 138);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(110, 20);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(159, 197);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(22, 22);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(47, 15);
            this.lblMedico.TabIndex = 5;
            this.lblMedico.Text = "label1";
            // 
            // lblSalarioMedico
            // 
            this.lblSalarioMedico.AutoSize = true;
            this.lblSalarioMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMedico.Location = new System.Drawing.Point(214, 22);
            this.lblSalarioMedico.Name = "lblSalarioMedico";
            this.lblSalarioMedico.Size = new System.Drawing.Size(47, 15);
            this.lblSalarioMedico.TabIndex = 6;
            this.lblSalarioMedico.Text = "label1";
            // 
            // ActualizarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 270);
            this.Controls.Add(this.lblSalarioMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNombreMedico);
            this.Name = "ActualizarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarMedico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActualizarMedico_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreMedico;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblSalarioMedico;
    }
}