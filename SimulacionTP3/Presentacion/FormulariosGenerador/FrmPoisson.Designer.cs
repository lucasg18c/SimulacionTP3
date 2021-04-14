namespace SimulacionTP3.Presentacion.FormulariosGenerador
{
    partial class FrmPoisson
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
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.Location = new System.Drawing.Point(12, 188);
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.Location = new System.Drawing.Point(15, 208);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtFrecuencia);
            this.gbDatos.Controls.SetChildIndex(this.txtIntervalos, 0);
            this.gbDatos.Controls.SetChildIndex(this.lblIntervalos, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.lblCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtFrecuencia, 0);
            this.gbDatos.Controls.SetChildIndex(this.label1, 0);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(12, 112);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(15, 132);
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.Location = new System.Drawing.Point(15, 56);
            this.txtFrecuencia.MaxLength = 6;
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.ShortcutsEnabled = false;
            this.txtFrecuencia.Size = new System.Drawing.Size(153, 25);
            this.txtFrecuencia.TabIndex = 5;
            this.txtFrecuencia.Tipo = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frecuencia (λ)";
            // 
            // FrmPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 519);
            this.Name = "FrmPoisson";
            this.Text = "Poisson";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Formularios.ControlesUsuario.NumTextBox txtFrecuencia;
    }
}