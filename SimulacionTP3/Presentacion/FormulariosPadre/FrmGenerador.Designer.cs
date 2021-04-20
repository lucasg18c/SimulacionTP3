using SimulacionTP3.Formularios.ControlesUsuario;

namespace SimulacionTP3.Presentacion.FormulariosPadre
{
    partial class FrmGenerador
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlMg3 = new System.Windows.Forms.Panel();
            this.pnlMg4 = new System.Windows.Forms.Panel();
            this.pnlMg7 = new System.Windows.Forms.Panel();
            this.pnlMg5 = new System.Windows.Forms.Panel();
            this.pnlMg6 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlMg1 = new System.Windows.Forms.Panel();
            this.btnProbar = new System.Windows.Forms.Button();
            this.pnlMg2 = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.intervalos = new SimulacionTP3.Presentacion.ControlesUsuario.DatoCombo();
            this.cantidad = new SimulacionTP3.Presentacion.ControlesUsuario.DatoTxtNum();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtSerieAleatoria = new System.Windows.Forms.RichTextBox();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlTopAplicacion = new System.Windows.Forms.Panel();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDatos.SuspendLayout();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.pnlTopAplicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMg3
            // 
            this.pnlMg3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMg3.Location = new System.Drawing.Point(30, 541);
            this.pnlMg3.Name = "pnlMg3";
            this.pnlMg3.Size = new System.Drawing.Size(609, 19);
            this.pnlMg3.TabIndex = 5;
            // 
            // pnlMg4
            // 
            this.pnlMg4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMg4.Location = new System.Drawing.Point(0, 59);
            this.pnlMg4.Name = "pnlMg4";
            this.pnlMg4.Size = new System.Drawing.Size(30, 501);
            this.pnlMg4.TabIndex = 7;
            // 
            // pnlMg7
            // 
            this.pnlMg7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMg7.Location = new System.Drawing.Point(30, 59);
            this.pnlMg7.Name = "pnlMg7";
            this.pnlMg7.Size = new System.Drawing.Size(609, 19);
            this.pnlMg7.TabIndex = 11;
            // 
            // pnlMg5
            // 
            this.pnlMg5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMg5.Location = new System.Drawing.Point(609, 78);
            this.pnlMg5.Name = "pnlMg5";
            this.pnlMg5.Size = new System.Drawing.Size(30, 463);
            this.pnlMg5.TabIndex = 13;
            // 
            // pnlMg6
            // 
            this.pnlMg6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMg6.Location = new System.Drawing.Point(30, 415);
            this.pnlMg6.Name = "pnlMg6";
            this.pnlMg6.Size = new System.Drawing.Size(579, 30);
            this.pnlMg6.TabIndex = 15;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(0, 399);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(324, 50);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.ClickBtnExportar);
            // 
            // pnlMg1
            // 
            this.pnlMg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.pnlMg1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMg1.Location = new System.Drawing.Point(0, 397);
            this.pnlMg1.Name = "pnlMg1";
            this.pnlMg1.Size = new System.Drawing.Size(324, 2);
            this.pnlMg1.TabIndex = 9;
            // 
            // btnProbar
            // 
            this.btnProbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnProbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProbar.FlatAppearance.BorderSize = 0;
            this.btnProbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbar.Location = new System.Drawing.Point(0, 347);
            this.btnProbar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(324, 50);
            this.btnProbar.TabIndex = 10;
            this.btnProbar.Text = "Probar Generador";
            this.btnProbar.UseVisualStyleBackColor = false;
            this.btnProbar.Visible = false;
            this.btnProbar.Click += new System.EventHandler(this.ClickBtnProbar);
            // 
            // pnlMg2
            // 
            this.pnlMg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.pnlMg2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMg2.Location = new System.Drawing.Point(0, 449);
            this.pnlMg2.Name = "pnlMg2";
            this.pnlMg2.Size = new System.Drawing.Size(324, 2);
            this.pnlMg2.TabIndex = 11;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Location = new System.Drawing.Point(0, 451);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(324, 50);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.ClickBtnGenerar);
            // 
            // pnlDatos
            // 
            this.pnlDatos.AutoScroll = true;
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.pnlDatos.Controls.Add(this.intervalos);
            this.pnlDatos.Controls.Add(this.cantidad);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(324, 347);
            this.pnlDatos.TabIndex = 12;
            // 
            // intervalos
            // 
            this.intervalos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.intervalos.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.intervalos.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.intervalos.Dock = System.Windows.Forms.DockStyle.Top;
            this.intervalos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.intervalos.ForeColor = System.Drawing.Color.White;
            this.intervalos.Location = new System.Drawing.Point(0, 66);
            this.intervalos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.intervalos.Name = "intervalos";
            this.intervalos.Size = new System.Drawing.Size(324, 68);
            this.intervalos.TabIndex = 7;
            this.intervalos.Texto = "Intervalos";
            // 
            // cantidad
            // 
            this.cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.cantidad.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.cantidad.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.cantidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.cantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.ForeColor = System.Drawing.Color.White;
            this.cantidad.Location = new System.Drawing.Point(0, 0);
            this.cantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(324, 66);
            this.cantidad.TabIndex = 6;
            this.cantidad.Texto = "Cantidad";
            this.cantidad.TipoDato = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            this.cantidad.Valor = 50D;
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.pnlDatos);
            this.pnlLateral.Controls.Add(this.btnProbar);
            this.pnlLateral.Controls.Add(this.pnlMg1);
            this.pnlLateral.Controls.Add(this.btnExportar);
            this.pnlLateral.Controls.Add(this.pnlMg2);
            this.pnlLateral.Controls.Add(this.btnGenerar);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLateral.Location = new System.Drawing.Point(639, 59);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(324, 501);
            this.pnlLateral.TabIndex = 8;
            // 
            // grafica
            // 
            this.grafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.grafica.BorderlineColor = System.Drawing.Color.Empty;
            this.grafica.BorderlineWidth = 0;
            this.grafica.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.grafica.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.grafica.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.grafica.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            this.grafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grafica.Location = new System.Drawing.Point(30, 78);
            this.grafica.Margin = new System.Windows.Forms.Padding(4);
            this.grafica.Name = "grafica";
            this.grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            series1.Name = "Numeros";
            this.grafica.Series.Add(series1);
            this.grafica.Size = new System.Drawing.Size(579, 337);
            this.grafica.TabIndex = 16;
            // 
            // txtSerieAleatoria
            // 
            this.txtSerieAleatoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.txtSerieAleatoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerieAleatoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSerieAleatoria.ForeColor = System.Drawing.Color.White;
            this.txtSerieAleatoria.Location = new System.Drawing.Point(30, 445);
            this.txtSerieAleatoria.Name = "txtSerieAleatoria";
            this.txtSerieAleatoria.ReadOnly = true;
            this.txtSerieAleatoria.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtSerieAleatoria.Size = new System.Drawing.Size(579, 96);
            this.txtSerieAleatoria.TabIndex = 17;
            this.txtSerieAleatoria.Text = "";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.pnlTopBar.Controls.Add(this.pnlTopAplicacion);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(963, 59);
            this.pnlTopBar.TabIndex = 0;
            // 
            // pnlTopAplicacion
            // 
            this.pnlTopAplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.pnlTopAplicacion.Controls.Add(this.lblNombreApp);
            this.pnlTopAplicacion.Controls.Add(this.pictureBox1);
            this.pnlTopAplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTopAplicacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTopAplicacion.Location = new System.Drawing.Point(0, 0);
            this.pnlTopAplicacion.Name = "pnlTopAplicacion";
            this.pnlTopAplicacion.Size = new System.Drawing.Size(220, 59);
            this.pnlTopAplicacion.TabIndex = 1;
            this.pnlTopAplicacion.Click += new System.EventHandler(this.ClickBtnNombreApp);
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.AutoSize = true;
            this.lblNombreApp.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblNombreApp.Location = new System.Drawing.Point(74, 18);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(123, 25);
            this.lblNombreApp.TabIndex = 1;
            this.lblNombreApp.Text = "TP3 Grupo 14";
            this.lblNombreApp.Click += new System.EventHandler(this.ClickBtnNombreApp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimulacionTP3.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ClickBtnNombreApp);
            // 
            // FrmGenerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(963, 560);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.pnlMg6);
            this.Controls.Add(this.txtSerieAleatoria);
            this.Controls.Add(this.pnlMg5);
            this.Controls.Add(this.pnlMg7);
            this.Controls.Add(this.pnlMg3);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlMg4);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = true;
            this.Name = "FrmGenerador";
            this.Text = "FrmGenerador";
            this.pnlDatos.ResumeLayout(false);
            this.pnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopAplicacion.ResumeLayout(false);
            this.pnlTopAplicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMg3;
        private System.Windows.Forms.Panel pnlMg4;
        private System.Windows.Forms.Panel pnlMg7;
        private System.Windows.Forms.Panel pnlMg5;
        private System.Windows.Forms.Panel pnlMg6;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Panel pnlMg1;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Panel pnlMg2;
        private System.Windows.Forms.Button btnGenerar;
        protected System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.RichTextBox txtSerieAleatoria;
        protected ControlesUsuario.DatoCombo intervalos;
        protected ControlesUsuario.DatoTxtNum cantidad;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTopAplicacion;
        private System.Windows.Forms.Label lblNombreApp;
    }
}