﻿namespace SimulacionTP3.Presentacion.FormulariosGenerador
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
            this.txtMedia = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.gbIntervalos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtMedia);
            this.gbDatos.Controls.SetChildIndex(this.gbIntervalos, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.lblCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtMedia, 0);
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
            // gbIntervalos
            // 
            this.gbIntervalos.Visible = false;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(15, 56);
            this.txtMedia.MaxLength = 6;
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ShortcutsEnabled = false;
            this.txtMedia.Size = new System.Drawing.Size(153, 25);
            this.txtMedia.TabIndex = 5;
            this.txtMedia.Tipo = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.Reales;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Media (μ)";
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
            this.gbIntervalos.ResumeLayout(false);
            this.gbIntervalos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Formularios.ControlesUsuario.NumTextBox txtMedia;
    }
}