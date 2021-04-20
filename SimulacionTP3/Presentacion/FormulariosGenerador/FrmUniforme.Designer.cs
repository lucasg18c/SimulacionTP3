namespace SimulacionTP3.Presentacion.FormulariosGenerador
{
    partial class FrmUniforme
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
            this.desde = new SimulacionTP3.Presentacion.ControlesUsuario.DatoTxtNum();
            this.hasta = new SimulacionTP3.Presentacion.ControlesUsuario.DatoTxtNum();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.hasta);
            this.pnlDatos.Controls.Add(this.desde);
            this.pnlDatos.Size = new System.Drawing.Size(324, 468);
            this.pnlDatos.Controls.SetChildIndex(this.desde, 0);
            this.pnlDatos.Controls.SetChildIndex(this.hasta, 0);
            // 
            // desde
            // 
            this.desde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.desde.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.desde.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.desde.Dock = System.Windows.Forms.DockStyle.Top;
            this.desde.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde.ForeColor = System.Drawing.Color.White;
            this.desde.Location = new System.Drawing.Point(0, 134);
            this.desde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(324, 53);
            this.desde.TabIndex = 8;
            this.desde.Texto = "Desde (A)";
            this.desde.TipoDato = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.RealesNegativos;
            this.desde.Valor = 5D;
            // 
            // hasta
            // 
            this.hasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.hasta.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.hasta.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.hasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.hasta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta.ForeColor = System.Drawing.Color.White;
            this.hasta.Location = new System.Drawing.Point(0, 187);
            this.hasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(324, 53);
            this.hasta.TabIndex = 9;
            this.hasta.Texto = "Hasta (B)";
            this.hasta.TipoDato = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.RealesNegativos;
            this.hasta.Valor = 10D;
            // 
            // FrmUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 611);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUniforme";
            this.Text = "Generar Serie Uniforme";
            this.pnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesUsuario.DatoTxtNum hasta;
        private ControlesUsuario.DatoTxtNum desde;
    }
}