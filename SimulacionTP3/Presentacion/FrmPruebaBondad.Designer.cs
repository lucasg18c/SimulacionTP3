namespace SimulacionTP3.Presentacion
{
    partial class FrmPruebaBondad
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
            this.tablaProcedimiento = new System.Windows.Forms.DataGridView();
            this.lblCOnclusion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProcedimiento
            // 
            this.tablaProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProcedimiento.Location = new System.Drawing.Point(34, 136);
            this.tablaProcedimiento.Name = "tablaProcedimiento";
            this.tablaProcedimiento.Size = new System.Drawing.Size(716, 361);
            this.tablaProcedimiento.TabIndex = 0;
            // 
            // lblResultado
            // 
            this.lblCOnclusion.AutoSize = true;
            this.lblCOnclusion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOnclusion.Location = new System.Drawing.Point(30, 33);
            this.lblCOnclusion.Name = "lblResultado";
            this.lblCOnclusion.Size = new System.Drawing.Size(74, 21);
            this.lblCOnclusion.TabIndex = 1;
            this.lblCOnclusion.Text = "resultado";
            // 
            // FrmPruebaBondad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 509);
            this.Controls.Add(this.lblCOnclusion);
            this.Controls.Add(this.tablaProcedimiento);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPruebaBondad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prueba Bondad";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProcedimiento;
        private System.Windows.Forms.Label lblCOnclusion;
    }
}