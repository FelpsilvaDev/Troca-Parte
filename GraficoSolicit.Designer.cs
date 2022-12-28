
namespace AtendimentoTrocaParte
{
    partial class GraficoSolicit
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraficoSolicit));
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartTipos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mskDataGrafico1 = new System.Windows.Forms.MaskedTextBox();
            this.mskDataGrafico2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAtendente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartMotivo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartModulo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBuscagfc = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAtendente)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMotivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(477, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(334, 36);
            this.label11.TabIndex = 40;
            this.label11.Text = "Gráficos de Solicitante";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(129)))), ((int)(((byte)(26)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 21);
            this.panel2.TabIndex = 38;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // chartTipos
            // 
            chartArea6.Name = "ChartArea1";
            this.chartTipos.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartTipos.Legends.Add(legend6);
            this.chartTipos.Location = new System.Drawing.Point(6, 129);
            this.chartTipos.Name = "chartTipos";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Tipos";
            this.chartTipos.Series.Add(series6);
            this.chartTipos.Size = new System.Drawing.Size(393, 198);
            this.chartTipos.TabIndex = 41;
            this.chartTipos.Text = "chart1";
            title6.Name = "TitleTipo";
            title6.Text = "Tipo";
            this.chartTipos.Titles.Add(title6);
            // 
            // mskDataGrafico1
            // 
            this.mskDataGrafico1.Location = new System.Drawing.Point(5, 100);
            this.mskDataGrafico1.Mask = "00/00/0000";
            this.mskDataGrafico1.Name = "mskDataGrafico1";
            this.mskDataGrafico1.Size = new System.Drawing.Size(94, 20);
            this.mskDataGrafico1.TabIndex = 45;
            this.mskDataGrafico1.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataGrafico2
            // 
            this.mskDataGrafico2.Location = new System.Drawing.Point(113, 100);
            this.mskDataGrafico2.Mask = "00/00/0000";
            this.mskDataGrafico2.Name = "mskDataGrafico2";
            this.mskDataGrafico2.Size = new System.Drawing.Size(93, 20);
            this.mskDataGrafico2.TabIndex = 46;
            this.mskDataGrafico2.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(2, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Dê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(110, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Até";
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(406, 129);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Setor";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(393, 198);
            this.chart1.TabIndex = 52;
            this.chart1.Text = "chart1";
            title7.Name = "TitleSetor";
            title7.Text = "Setor";
            this.chart1.Titles.Add(title7);
            // 
            // chartAtendente
            // 
            chartArea8.Name = "ChartArea1";
            this.chartAtendente.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartAtendente.Legends.Add(legend8);
            this.chartAtendente.Location = new System.Drawing.Point(406, 337);
            this.chartAtendente.Name = "chartAtendente";
            this.chartAtendente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.IsValueShownAsLabel = true;
            series8.Legend = "Legend1";
            series8.Name = "Atendentes";
            this.chartAtendente.Series.Add(series8);
            this.chartAtendente.Size = new System.Drawing.Size(393, 306);
            this.chartAtendente.TabIndex = 53;
            this.chartAtendente.Text = "Setor";
            title8.Name = "TitleModulo";
            title8.Text = "Atendentes";
            this.chartAtendente.Titles.Add(title8);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chartMotivo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chartModulo);
            this.panel1.Controls.Add(this.btnBuscagfc);
            this.panel1.Controls.Add(this.mskDataGrafico2);
            this.panel1.Controls.Add(this.chartAtendente);
            this.panel1.Controls.Add(this.mskDataGrafico1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.chartTipos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 749);
            this.panel1.TabIndex = 54;
            // 
            // chartMotivo
            // 
            chartArea9.Name = "ChartArea1";
            this.chartMotivo.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartMotivo.Legends.Add(legend9);
            this.chartMotivo.Location = new System.Drawing.Point(6, 337);
            this.chartMotivo.Name = "chartMotivo";
            this.chartMotivo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series9.ChartArea = "ChartArea1";
            series9.IsValueShownAsLabel = true;
            series9.Legend = "Legend1";
            series9.Name = "Motivo";
            this.chartMotivo.Series.Add(series9);
            this.chartMotivo.Size = new System.Drawing.Size(393, 306);
            this.chartMotivo.TabIndex = 44;
            this.chartMotivo.Text = "chartMotivo";
            title9.Name = "TitleMotivo";
            title9.Text = "Motivo";
            this.chartMotivo.Titles.Add(title9);
            // 
            // chartModulo
            // 
            chartArea10.Name = "ChartArea1";
            this.chartModulo.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartModulo.Legends.Add(legend10);
            this.chartModulo.Location = new System.Drawing.Point(806, 129);
            this.chartModulo.Name = "chartModulo";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.IsValueShownAsLabel = true;
            series10.Legend = "Legend1";
            series10.Name = "Modulo";
            series10.YValuesPerPoint = 4;
            this.chartModulo.Series.Add(series10);
            this.chartModulo.Size = new System.Drawing.Size(555, 514);
            this.chartModulo.TabIndex = 51;
            this.chartModulo.Text = "chartModulo";
            title10.Name = "TitleModulo";
            title10.Text = "Modulo";
            this.chartModulo.Titles.Add(title10);
            // 
            // btnBuscagfc
            // 
            this.btnBuscagfc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnBuscagfc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscagfc.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscagfc.IconColor = System.Drawing.Color.Black;
            this.btnBuscagfc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscagfc.IconSize = 20;
            this.btnBuscagfc.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBuscagfc.Location = new System.Drawing.Point(211, 98);
            this.btnBuscagfc.Name = "btnBuscagfc";
            this.btnBuscagfc.Size = new System.Drawing.Size(70, 25);
            this.btnBuscagfc.TabIndex = 47;
            this.btnBuscagfc.Text = "Buscar";
            this.btnBuscagfc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscagfc.UseVisualStyleBackColor = false;
            this.btnBuscagfc.Click += new System.EventHandler(this.btnBuscagfc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // GraficoSolicit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1368, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GraficoSolicit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficos Solicitantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GraficoSolicit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAtendente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMotivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSetor;
        private System.Windows.Forms.MaskedTextBox mskDataGrafico1;
        private System.Windows.Forms.MaskedTextBox mskDataGrafico2;
        private FontAwesome.Sharp.IconButton btnBuscagfc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chartTipos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAtendente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMotivo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartModulo;
    }
}