namespace SimulacionTP3.Presentacion
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
            this.txtA = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.Location = new System.Drawing.Point(25, 210);
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.Location = new System.Drawing.Point(28, 231);
            this.txtIntervalos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtB);
            this.gbDatos.Controls.Add(this.labelA);
            this.gbDatos.Controls.Add(this.txtA);
            this.gbDatos.Controls.SetChildIndex(this.txtCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.lblCantidad, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtIntervalos, 0);
            this.gbDatos.Controls.SetChildIndex(this.lblIntervalos, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtA, 0);
            this.gbDatos.Controls.SetChildIndex(this.labelA, 0);
            this.gbDatos.Controls.SetChildIndex(this.txtB, 0);
            this.gbDatos.Controls.SetChildIndex(this.label1, 0);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(25, 152);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(28, 172);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(28, 54);
            this.txtA.Name = "txtA";
            this.txtA.ShortcutsEnabled = false;
            this.txtA.Size = new System.Drawing.Size(153, 25);
            this.txtA.TabIndex = 3;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(26, 34);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(16, 17);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "B";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(28, 113);
            this.txtB.Name = "txtB";
            this.txtB.ShortcutsEnabled = false;
            this.txtB.Size = new System.Drawing.Size(153, 25);
            this.txtB.TabIndex = 5;
            // 
            // FrmUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 519);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmUniforme";
            this.Text = "Generar Serie Uniforme";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private Formularios.ControlesUsuario.NumTextBox txtA;
        private System.Windows.Forms.Label label1;
        private Formularios.ControlesUsuario.NumTextBox txtB;
    }
}