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
            this.txtFrecuencia = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedia = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtMedia);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtFrecuencia);
            this.gbDatos.Controls.SetChildIndex(this.txtIntervalos, 0);
            this.gbDatos.Controls.SetChildIndex(this.lblIntervalos, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.lblCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtFrecuencia, 0);
            this.gbDatos.Controls.SetChildIndex(this.label1, 0);
            this.gbDatos.Controls.SetChildIndex(this.label2, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtMedia, 0);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(12, 151);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(15, 171);
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.Location = new System.Drawing.Point(15, 57);
            this.txtFrecuencia.MaxLength = 6;
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.ShortcutsEnabled = false;
            this.txtFrecuencia.Size = new System.Drawing.Size(153, 25);
            this.txtFrecuencia.TabIndex = 5;
            this.txtFrecuencia.Tipo = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.Reales;
            this.txtFrecuencia.TextChanged += new System.EventHandler(this.ModificadoTxtFrecuencia);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frecuencia (λ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Media (μ)";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(15, 114);
            this.txtMedia.MaxLength = 6;
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ShortcutsEnabled = false;
            this.txtMedia.Size = new System.Drawing.Size(153, 25);
            this.txtMedia.TabIndex = 8;
            this.txtMedia.Tipo = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.Reales;
            this.txtMedia.TextChanged += new System.EventHandler(this.ModificadoTxtMedia);
            // 
            // FrmExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 518);
            this.Name = "FrmExponencial";
            this.Text = "Exponencial";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Formularios.ControlesUsuario.NumTextBox txtFrecuencia;
        private Formularios.ControlesUsuario.NumTextBox txtMedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}