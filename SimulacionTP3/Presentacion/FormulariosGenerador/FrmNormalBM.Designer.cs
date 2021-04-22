namespace SimulacionTP3.Presentacion.FormulariosGenerador
{
    partial class FrmNormalBM
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
            this.desviacion = new SimulacionTP3.Presentacion.ControlesUsuario.DatoTxtNum();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.desviacion);
            this.pnlDatos.Controls.Add(this.media);
            this.pnlDatos.Size = new System.Drawing.Size(324, 423);
            this.pnlDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDatos_Paint);
            this.pnlDatos.Controls.SetChildIndex(this.cantidad, 0);
            this.pnlDatos.Controls.SetChildIndex(this.intervalos, 0);
            this.pnlDatos.Controls.SetChildIndex(this.media, 0);
            this.pnlDatos.Controls.SetChildIndex(this.desviacion, 0);
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
            this.media.Size = new System.Drawing.Size(324, 53);
            this.media.TabIndex = 8;
            this.media.Texto = "Media (μ)";
            this.media.TipoDato = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.RealesNegativos;
            this.media.Valor = 15D;
            // 
            // desviacion
            // 
            this.desviacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.desviacion.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.desviacion.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.desviacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.desviacion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desviacion.ForeColor = System.Drawing.Color.White;
            this.desviacion.Location = new System.Drawing.Point(0, 187);
            this.desviacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.desviacion.Name = "desviacion";
            this.desviacion.Size = new System.Drawing.Size(324, 53);
            this.desviacion.TabIndex = 9;
            this.desviacion.Texto = "Desviacion (σ)";
            this.desviacion.TipoDato = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            this.desviacion.Valor = 1D;
            // 
            // FrmNormalBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 615);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmNormalBM";
            this.Text = "Normal Box Muller";
            this.pnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesUsuario.DatoTxtNum desviacion;
        private ControlesUsuario.DatoTxtNum media;
    }
}