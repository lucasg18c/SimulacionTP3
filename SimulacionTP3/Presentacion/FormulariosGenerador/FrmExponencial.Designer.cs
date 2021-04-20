namespace SimulacionTP3.Presentacion.FormulariosGenerador
{
    partial class FrmExponencial
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
            this.media = new SimulacionTP3.Presentacion.ControlesUsuario.DatoTxtNum();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.media);
            this.pnlDatos.Size = new System.Drawing.Size(278, 438);
            this.pnlDatos.Controls.SetChildIndex(this.media, 0);
            // 
            // media
            // 
            this.media.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.media.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.media.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.media.Dock = System.Windows.Forms.DockStyle.Top;
            this.media.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.media.ForeColor = System.Drawing.Color.White;
            this.media.Location = new System.Drawing.Point(0, 134);
            this.media.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(278, 53);
            this.media.TabIndex = 11;
            this.media.Texto = "Media (μ)";
            this.media.TipoDato = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.Reales;
            this.media.Valor = 10D;
            // 
            // FrmExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 609);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmExponencial";
            this.Text = "Exponencial";
            this.pnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ControlesUsuario.DatoTxtNum media;
    }
}