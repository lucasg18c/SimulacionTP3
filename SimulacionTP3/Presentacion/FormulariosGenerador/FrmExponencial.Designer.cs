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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedia = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtMedia);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.SetChildIndex(this.txtCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.lblCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.label2, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtMedia, 0);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(30, 107);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(33, 127);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Media (μ)";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(33, 57);
            this.txtMedia.MaxLength = 6;
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ShortcutsEnabled = false;
            this.txtMedia.Size = new System.Drawing.Size(153, 25);
            this.txtMedia.TabIndex = 8;
            this.txtMedia.Tipo = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.Reales;
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
        private Formularios.ControlesUsuario.NumTextBox txtMedia;
        private System.Windows.Forms.Label label2;
    }
}