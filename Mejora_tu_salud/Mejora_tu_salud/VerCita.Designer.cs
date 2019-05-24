namespace Mejora_tu_salud
{
    partial class VerCita
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
            this.lblCitasPaciente = new System.Windows.Forms.Label();
            this.dgvCitasPaciente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCitasPaciente
            // 
            this.lblCitasPaciente.AutoSize = true;
            this.lblCitasPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasPaciente.Location = new System.Drawing.Point(13, 13);
            this.lblCitasPaciente.Name = "lblCitasPaciente";
            this.lblCitasPaciente.Size = new System.Drawing.Size(66, 24);
            this.lblCitasPaciente.TabIndex = 0;
            this.lblCitasPaciente.Text = "label1";
            // 
            // dgvCitasPaciente
            // 
            this.dgvCitasPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitasPaciente.Location = new System.Drawing.Point(17, 61);
            this.dgvCitasPaciente.Name = "dgvCitasPaciente";
            this.dgvCitasPaciente.Size = new System.Drawing.Size(480, 106);
            this.dgvCitasPaciente.TabIndex = 1;
            // 
            // VerCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 179);
            this.Controls.Add(this.dgvCitasPaciente);
            this.Controls.Add(this.lblCitasPaciente);
            this.Name = "VerCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas del paciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerCita_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCitasPaciente;
        private System.Windows.Forms.DataGridView dgvCitasPaciente;
    }
}