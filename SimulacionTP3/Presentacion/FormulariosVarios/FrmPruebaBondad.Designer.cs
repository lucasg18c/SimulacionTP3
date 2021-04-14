namespace SimulacionTP3.Presentacion.FormulariosVarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPruebaBondad));
            this.tablaProcedimiento = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblEstadistico = new System.Windows.Forms.Label();
            this.lblValorCritico = new System.Windows.Forms.Label();
            this.lblPruebaBondad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProcedimiento
            // 
            this.tablaProcedimiento.AllowUserToAddRows = false;
            this.tablaProcedimiento.AllowUserToDeleteRows = false;
            this.tablaProcedimiento.AllowUserToOrderColumns = true;
            this.tablaProcedimiento.AllowUserToResizeColumns = false;
            this.tablaProcedimiento.AllowUserToResizeRows = false;
            this.tablaProcedimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProcedimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProcedimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProcedimiento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaProcedimiento.Location = new System.Drawing.Point(34, 136);
            this.tablaProcedimiento.MultiSelect = false;
            this.tablaProcedimiento.Name = "tablaProcedimiento";
            this.tablaProcedimiento.ReadOnly = true;
            this.tablaProcedimiento.RowHeadersVisible = false;
            this.tablaProcedimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProcedimiento.Size = new System.Drawing.Size(716, 361);
            this.tablaProcedimiento.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(30, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(187, 21);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "ESTADÍSTICO DE PRUEBA:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(30, 40);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(121, 21);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "VALOR CRÍTICO:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(30, 61);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(182, 21);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "NOMBRE DE LA PRUEBA:";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConclusion.Location = new System.Drawing.Point(30, 93);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(94, 21);
            this.lblConclusion.TabIndex = 4;
            this.lblConclusion.Text = "conclusión";
            // 
            // lblEstadistico
            // 
            this.lblEstadistico.AutoSize = true;
            this.lblEstadistico.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadistico.Location = new System.Drawing.Point(242, 19);
            this.lblEstadistico.Name = "lblEstadistico";
            this.lblEstadistico.Size = new System.Drawing.Size(156, 21);
            this.lblEstadistico.TabIndex = 5;
            this.lblEstadistico.Text = "estadistico de prueba";
            // 
            // lblValorCritico
            // 
            this.lblValorCritico.AutoSize = true;
            this.lblValorCritico.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCritico.Location = new System.Drawing.Point(242, 40);
            this.lblValorCritico.Name = "lblValorCritico";
            this.lblValorCritico.Size = new System.Drawing.Size(88, 21);
            this.lblValorCritico.TabIndex = 6;
            this.lblValorCritico.Text = "valor critico";
            // 
            // lblPruebaBondad
            // 
            this.lblPruebaBondad.AutoSize = true;
            this.lblPruebaBondad.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPruebaBondad.Location = new System.Drawing.Point(242, 61);
            this.lblPruebaBondad.Name = "lblPruebaBondad";
            this.lblPruebaBondad.Size = new System.Drawing.Size(115, 21);
            this.lblPruebaBondad.TabIndex = 7;
            this.lblPruebaBondad.Text = "prueba bondad";
            // 
            // FrmPruebaBondad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 509);
            this.Controls.Add(this.lblPruebaBondad);
            this.Controls.Add(this.lblValorCritico);
            this.Controls.Add(this.lblEstadistico);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tablaProcedimiento);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblEstadistico;
        private System.Windows.Forms.Label lblValorCritico;
        private System.Windows.Forms.Label lblPruebaBondad;
    }
}