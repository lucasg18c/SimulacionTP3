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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.txtIntervalos = new SimulacionTP3.Formularios.ControlesUsuario.NumTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblCantidad);
            this.gbDatos.Controls.Add(this.txtCantidad);
            this.gbDatos.Controls.Add(this.lblIntervalos);
            this.gbDatos.Controls.Add(this.txtIntervalos);
            this.gbDatos.Controls.Add(this.btnGenerar);
            this.gbDatos.Location = new System.Drawing.Point(12, 14);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(230, 342);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
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
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(12, 208);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(112, 17);
            this.lblIntervalos.TabIndex = 2;
            this.lblIntervalos.Text = "Intervalos (gráfico)";
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.Location = new System.Drawing.Point(15, 228);
            this.txtIntervalos.MaxLength = 6;
            this.txtIntervalos.Name = "txtIntervalos";
            this.txtIntervalos.ShortcutsEnabled = false;
            this.txtIntervalos.Size = new System.Drawing.Size(153, 25);
            this.txtIntervalos.TabIndex = 1;
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
            this.txtSerie.Size = new System.Drawing.Size(669, 131);
            this.txtSerie.TabIndex = 1;
            // 
            // btnProbar
            // 
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
        protected System.Windows.Forms.Label lblIntervalos;
        protected NumTextBox txtIntervalos;
        protected System.Windows.Forms.GroupBox gbDatos;
        protected System.Windows.Forms.Label lblCantidad;
        protected NumTextBox txtCantidad;
    }
}