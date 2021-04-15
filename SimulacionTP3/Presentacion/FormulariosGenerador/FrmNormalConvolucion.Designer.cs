namespace SimulacionTP3.Presentacion.FormulariosGenerador
{
    partial class FrmNormalConvolucion
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesviacion = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedia = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.gbDatos.SuspendLayout();
            this.gbIntervalos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.txtDesviacion);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtMedia);
            this.gbDatos.Controls.SetChildIndex(this.gbIntervalos, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.lblCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtMedia, 0);
            this.gbDatos.Controls.SetChildIndex(this.label1, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtDesviacion, 0);
            this.gbDatos.Controls.SetChildIndex(this.label2, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Desviación (σ)";
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Location = new System.Drawing.Point(15, 109);
            this.txtDesviacion.MaxLength = 6;
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.ShortcutsEnabled = false;
            this.txtDesviacion.Size = new System.Drawing.Size(153, 25);
            this.txtDesviacion.TabIndex = 11;
            this.txtDesviacion.Tipo = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.Reales;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Media (μ)";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(15, 52);
            this.txtMedia.MaxLength = 6;
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ShortcutsEnabled = false;
            this.txtMedia.Size = new System.Drawing.Size(153, 25);
            this.txtMedia.TabIndex = 9;
            this.txtMedia.Tipo = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.RealesNegativos;
            // 
            // FrmNormalConvolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 519);
            this.Name = "FrmNormalConvolucion";
            this.Text = "Normal Convolución";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbIntervalos.ResumeLayout(false);
            this.gbIntervalos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Formularios.ControlesUsuario.NumTextBox txtDesviacion;
        private System.Windows.Forms.Label label1;
        private Formularios.ControlesUsuario.NumTextBox txtMedia;
    }
}