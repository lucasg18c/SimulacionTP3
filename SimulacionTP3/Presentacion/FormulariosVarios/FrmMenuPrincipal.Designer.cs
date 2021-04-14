
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
            this.Menu = new System.Windows.Forms.Panel();
            this.btnPoisson = new System.Windows.Forms.Button();
            this.SubMenu = new System.Windows.Forms.Panel();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.btnBoxMuller = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnExponencial = new System.Windows.Forms.Button();
            this.btnUniforme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.Menu.SuspendLayout();
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
            this.lblTirulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTirulo.ForeColor = System.Drawing.Color.White;
            this.lblTirulo.Location = new System.Drawing.Point(130, 34);
            this.lblTirulo.Name = "lblTirulo";
            this.lblTirulo.Size = new System.Drawing.Size(431, 25);
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
            this.Encabezado.Size = new System.Drawing.Size(665, 84);
            this.Encabezado.TabIndex = 5;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.Controls.Add(this.btnPoisson);
            this.Menu.Controls.Add(this.SubMenu);
            this.Menu.Controls.Add(this.btnNormal);
            this.Menu.Controls.Add(this.btnExponencial);
            this.Menu.Controls.Add(this.btnUniforme);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 184);
            this.Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(665, 485);
            this.Menu.TabIndex = 6;
            // 
            // btnPoisson
            // 
            this.btnPoisson.BackColor = System.Drawing.Color.Black;
            this.btnPoisson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPoisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoisson.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPoisson.Location = new System.Drawing.Point(0, 300);
            this.btnPoisson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(665, 60);
            this.btnPoisson.TabIndex = 12;
            this.btnPoisson.Text = "Distribución Poisson";
            this.btnPoisson.UseVisualStyleBackColor = false;
            this.btnPoisson.Click += new System.EventHandler(this.ClickBtnPoisson);
            // 
            // SubMenu
            // 
            this.SubMenu.BackColor = System.Drawing.Color.Transparent;
            this.SubMenu.Controls.Add(this.btnConvolucion);
            this.SubMenu.Controls.Add(this.btnBoxMuller);
            this.SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenu.Location = new System.Drawing.Point(0, 180);
            this.SubMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(665, 120);
            this.SubMenu.TabIndex = 11;
            this.SubMenu.Visible = false;
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConvolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvolucion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConvolucion.Location = new System.Drawing.Point(0, 60);
            this.btnConvolucion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(665, 60);
            this.btnConvolucion.TabIndex = 10;
            this.btnConvolucion.Text = "Convolución";
            this.btnConvolucion.UseVisualStyleBackColor = false;
            this.btnConvolucion.Click += new System.EventHandler(this.ClickBtnConvolucion);
            // 
            // btnBoxMuller
            // 
            this.btnBoxMuller.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBoxMuller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBoxMuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoxMuller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxMuller.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBoxMuller.Location = new System.Drawing.Point(0, 0);
            this.btnBoxMuller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBoxMuller.Name = "btnBoxMuller";
            this.btnBoxMuller.Size = new System.Drawing.Size(665, 60);
            this.btnBoxMuller.TabIndex = 9;
            this.btnBoxMuller.Text = "Box-Muller";
            this.btnBoxMuller.UseVisualStyleBackColor = false;
            this.btnBoxMuller.Click += new System.EventHandler(this.ClickBtnNormalBM);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.Black;
            this.btnNormal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNormal.Location = new System.Drawing.Point(0, 120);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(665, 60);
            this.btnNormal.TabIndex = 8;
            this.btnNormal.Text = "Distribución Normal";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.ClickBtnNormal);
            // 
            // btnExponencial
            // 
            this.btnExponencial.BackColor = System.Drawing.Color.Black;
            this.btnExponencial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExponencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponencial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExponencial.Location = new System.Drawing.Point(0, 60);
            this.btnExponencial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(665, 60);
            this.btnExponencial.TabIndex = 6;
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
            this.btnUniforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniforme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUniforme.Location = new System.Drawing.Point(0, 0);
            this.btnUniforme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUniforme.Name = "btnUniforme";
            this.btnUniforme.Size = new System.Drawing.Size(665, 60);
            this.btnUniforme.TabIndex = 5;
            this.btnUniforme.Text = "Distribución Uniforme";
            this.btnUniforme.UseVisualStyleBackColor = false;
            this.btnUniforme.Click += new System.EventHandler(this.ClickBtnUniforme);
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
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(665, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Encabezado);
            this.Controls.Add(this.pnlTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.Text = "TP3 Simulación | Cosci - Folli - Lerda - Lozada - Reartes - Slavik";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTirulo;
        private System.Windows.Forms.Panel Encabezado;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button btnBoxMuller;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnExponencial;
        private System.Windows.Forms.Button btnUniforme;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.Panel SubMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPoisson;
    }
}

