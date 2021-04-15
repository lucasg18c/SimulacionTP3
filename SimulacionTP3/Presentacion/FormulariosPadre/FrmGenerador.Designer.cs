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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbIntervalos = new System.Windows.Forms.GroupBox();
            this.rb20 = new System.Windows.Forms.RadioButton();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbDatos.SuspendLayout();
            this.gbIntervalos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.gbIntervalos);
            this.gbDatos.Controls.Add(this.lblCantidad);
            this.gbDatos.Controls.Add(this.txtCantidad);
            this.gbDatos.Controls.Add(this.btnGenerar);
            this.gbDatos.Location = new System.Drawing.Point(12, 14);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(230, 342);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // gbIntervalos
            // 
            this.gbIntervalos.Controls.Add(this.rb20);
            this.gbIntervalos.Controls.Add(this.rb15);
            this.gbIntervalos.Controls.Add(this.rb10);
            this.gbIntervalos.Controls.Add(this.rb5);
            this.gbIntervalos.Location = new System.Drawing.Point(15, 204);
            this.gbIntervalos.Name = "gbIntervalos";
            this.gbIntervalos.Size = new System.Drawing.Size(198, 77);
            this.gbIntervalos.TabIndex = 5;
            this.gbIntervalos.TabStop = false;
            this.gbIntervalos.Text = "Intervalos (gráfico)";
            // 
            // rb20
            // 
            this.rb20.AutoSize = true;
            this.rb20.Location = new System.Drawing.Point(151, 34);
            this.rb20.Name = "rb20";
            this.rb20.Size = new System.Drawing.Size(40, 21);
            this.rb20.TabIndex = 3;
            this.rb20.Text = "20";
            this.rb20.UseVisualStyleBackColor = true;
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Location = new System.Drawing.Point(101, 34);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(38, 21);
            this.rb15.TabIndex = 2;
            this.rb15.Text = "15";
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Checked = true;
            this.rb10.Location = new System.Drawing.Point(51, 34);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(38, 21);
            this.rb10.TabIndex = 1;
            this.rb10.TabStop = true;
            this.rb10.Text = "10";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(6, 34);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(33, 21);
            this.rb5.TabIndex = 0;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 142);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 17);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(15, 162);
            this.txtCantidad.MaxLength = 6;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ShortcutsEnabled = false;
            this.txtCantidad.Size = new System.Drawing.Size(153, 25);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Tipo = SimulacionTP3.Formularios.ControlesUsuario.NumTextBox.TipoDato.Enteros;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(58, 287);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 32);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.ClickBtnGenerar);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(12, 376);
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerie.Size = new System.Drawing.Size(689, 131);
            this.txtSerie.TabIndex = 1;
            // 
            // btnProbar
            // 
            this.btnProbar.Enabled = false;
            this.btnProbar.Location = new System.Drawing.Point(723, 376);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(110, 49);
            this.btnProbar.TabIndex = 2;
            this.btnProbar.Text = "Probar Generador";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.ClickBtnProbar);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(723, 458);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 49);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.ClickBtnLimpiar);
            // 
            // grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(260, 24);
            this.grafica.Name = "grafica";
            this.grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Numeros";
            this.grafica.Series.Add(series1);
            this.grafica.Size = new System.Drawing.Size(573, 332);
            this.grafica.TabIndex = 4;
            this.grafica.Text = "chart1";
            // 
            // FrmGenerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 519);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.gbDatos);
            this.Name = "FrmGenerador";
            this.Text = "FrmGenerador";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbIntervalos.ResumeLayout(false);
            this.gbIntervalos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        protected System.Windows.Forms.GroupBox gbDatos;
        protected System.Windows.Forms.Label lblCantidad;
        protected NumTextBox txtCantidad;
        protected System.Windows.Forms.GroupBox gbIntervalos;
        protected System.Windows.Forms.RadioButton rb20;
        protected System.Windows.Forms.RadioButton rb15;
        protected System.Windows.Forms.RadioButton rb10;
        protected System.Windows.Forms.RadioButton rb5;
    }
}