
namespace SimulacionTP3.Presentacion.FormulariosVarios
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTirulo = new System.Windows.Forms.Label();
            this.Encabezado = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnPoisson = new System.Windows.Forms.Button();
            this.SubMenu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnBoxMuller = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnExponencial = new System.Windows.Forms.Button();
            this.btnUniforme = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Black;
            this.pnlTitulo.Controls.Add(this.lblTirulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(665, 100);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTirulo
            // 
            this.lblTirulo.AutoSize = true;
            this.lblTirulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTirulo.ForeColor = System.Drawing.Color.White;
            this.lblTirulo.Location = new System.Drawing.Point(130, 34);
            this.lblTirulo.Name = "lblTirulo";
            this.lblTirulo.Size = new System.Drawing.Size(435, 32);
            this.lblTirulo.TabIndex = 0;
            this.lblTirulo.Text = "Trabajo Práctico 3: Variables Aleatorias";
            // 
            // Encabezado
            // 
            this.Encabezado.BackColor = System.Drawing.Color.Transparent;
            this.Encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Encabezado.Location = new System.Drawing.Point(0, 100);
            this.Encabezado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(665, 68);
            this.Encabezado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(558, 696);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "v1.0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 443);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(591, 168);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 443);
            this.panel2.TabIndex = 9;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(25, 415);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(37, 19);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "V 1.2";
            this.lblVersion.Click += new System.EventHandler(this.ClickLblVersion);
            // 
            // btnPoisson
            // 
            this.btnPoisson.BackColor = System.Drawing.Color.Black;
            this.btnPoisson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPoisson.FlatAppearance.BorderSize = 0;
            this.btnPoisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoisson.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoisson.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPoisson.Location = new System.Drawing.Point(74, 518);
            this.btnPoisson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(517, 60);
            this.btnPoisson.TabIndex = 17;
            this.btnPoisson.Text = "Distribución Poisson";
            this.btnPoisson.UseVisualStyleBackColor = false;
            this.btnPoisson.Click += new System.EventHandler(this.ClickBtnPoisson);
            // 
            // SubMenu
            // 
            this.SubMenu.AutoSize = true;
            this.SubMenu.BackColor = System.Drawing.Color.Transparent;
            this.SubMenu.Controls.Add(this.panel6);
            this.SubMenu.Controls.Add(this.btnConvolucion);
            this.SubMenu.Controls.Add(this.panel7);
            this.SubMenu.Controls.Add(this.btnBoxMuller);
            this.SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenu.Location = new System.Drawing.Point(74, 378);
            this.SubMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(517, 140);
            this.SubMenu.TabIndex = 16;
            this.SubMenu.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 130);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(517, 10);
            this.panel6.TabIndex = 21;
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.BackColor = System.Drawing.Color.Gray;
            this.btnConvolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvolucion.FlatAppearance.BorderSize = 0;
            this.btnConvolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvolucion.ForeColor = System.Drawing.Color.White;
            this.btnConvolucion.Location = new System.Drawing.Point(0, 70);
            this.btnConvolucion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(517, 60);
            this.btnConvolucion.TabIndex = 10;
            this.btnConvolucion.Text = "Convolución";
            this.btnConvolucion.UseVisualStyleBackColor = false;
            this.btnConvolucion.Click += new System.EventHandler(this.ClickBtnConvolucion);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 60);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(517, 10);
            this.panel7.TabIndex = 22;
            // 
            // btnBoxMuller
            // 
            this.btnBoxMuller.BackColor = System.Drawing.Color.Gray;
            this.btnBoxMuller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBoxMuller.FlatAppearance.BorderSize = 0;
            this.btnBoxMuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoxMuller.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxMuller.ForeColor = System.Drawing.Color.White;
            this.btnBoxMuller.Location = new System.Drawing.Point(0, 0);
            this.btnBoxMuller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBoxMuller.Name = "btnBoxMuller";
            this.btnBoxMuller.Size = new System.Drawing.Size(517, 60);
            this.btnBoxMuller.TabIndex = 9;
            this.btnBoxMuller.Text = "Box-Muller";
            this.btnBoxMuller.UseVisualStyleBackColor = false;
            this.btnBoxMuller.Click += new System.EventHandler(this.ClickBtnNormalBM);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.Black;
            this.btnNormal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNormal.Location = new System.Drawing.Point(74, 308);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(517, 60);
            this.btnNormal.TabIndex = 15;
            this.btnNormal.Text = "Distribución Normal";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.ClickBtnNormal);
            // 
            // btnExponencial
            // 
            this.btnExponencial.BackColor = System.Drawing.Color.Black;
            this.btnExponencial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExponencial.FlatAppearance.BorderSize = 0;
            this.btnExponencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExponencial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponencial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExponencial.Location = new System.Drawing.Point(74, 238);
            this.btnExponencial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(517, 60);
            this.btnExponencial.TabIndex = 14;
            this.btnExponencial.Text = "Distribución Exponencial";
            this.btnExponencial.UseVisualStyleBackColor = false;
            this.btnExponencial.Click += new System.EventHandler(this.ClickBtnExponencial);
            // 
            // btnUniforme
            // 
            this.btnUniforme.BackColor = System.Drawing.Color.Black;
            this.btnUniforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUniforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUniforme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUniforme.FlatAppearance.BorderSize = 0;
            this.btnUniforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUniforme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniforme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUniforme.Location = new System.Drawing.Point(74, 168);
            this.btnUniforme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUniforme.Name = "btnUniforme";
            this.btnUniforme.Size = new System.Drawing.Size(517, 60);
            this.btnUniforme.TabIndex = 13;
            this.btnUniforme.Text = "Distribución Uniforme";
            this.btnUniforme.UseVisualStyleBackColor = false;
            this.btnUniforme.Click += new System.EventHandler(this.ClickBtnUniforme);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(74, 228);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 10);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(74, 298);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(517, 10);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(74, 368);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(517, 10);
            this.panel5.TabIndex = 20;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 611);
            this.Controls.Add(this.btnPoisson);
            this.Controls.Add(this.SubMenu);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnExponencial);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnUniforme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Encabezado);
            this.Controls.Add(this.pnlTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.Text = "TP3 Simulación | Cosci - Folli - Lerda - Lozada - Reartes - Slavik";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTirulo;
        private System.Windows.Forms.Panel Encabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPoisson;
        private System.Windows.Forms.Panel SubMenu;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.Button btnBoxMuller;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnExponencial;
        private System.Windows.Forms.Button btnUniforme;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblVersion;
    }
}

