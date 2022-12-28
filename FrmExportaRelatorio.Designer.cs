
namespace AtendimentoTrocaParte
{
    partial class FrmExportaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportaRelatorio));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.comboSetor = new System.Windows.Forms.ComboBox();
            this.comboMotivo = new System.Windows.Forms.ComboBox();
            this.comboModulo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridBuscar = new System.Windows.Forms.DataGridView();
            this.dataCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEncerramento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indevido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblQtdChamados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskData1 = new System.Windows.Forms.MaskedTextBox();
            this.mskData2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.btnGrafico = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(129)))), ((int)(((byte)(26)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 21);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "URGENTE",
            "SOLICITAÇÃO"});
            this.comboTipo.Location = new System.Drawing.Point(15, 131);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 31;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // comboSetor
            // 
            this.comboSetor.FormattingEnabled = true;
            this.comboSetor.Location = new System.Drawing.Point(142, 131);
            this.comboSetor.Name = "comboSetor";
            this.comboSetor.Size = new System.Drawing.Size(199, 21);
            this.comboSetor.TabIndex = 32;
            // 
            // comboMotivo
            // 
            this.comboMotivo.FormattingEnabled = true;
            this.comboMotivo.Location = new System.Drawing.Point(348, 131);
            this.comboMotivo.Name = "comboMotivo";
            this.comboMotivo.Size = new System.Drawing.Size(153, 21);
            this.comboMotivo.TabIndex = 33;
            // 
            // comboModulo
            // 
            this.comboModulo.FormattingEnabled = true;
            this.comboModulo.Location = new System.Drawing.Point(506, 131);
            this.comboModulo.Name = "comboModulo";
            this.comboModulo.Size = new System.Drawing.Size(146, 21);
            this.comboModulo.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(675, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 36);
            this.label11.TabIndex = 37;
            this.label11.Text = "Buscar Relatorio";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridBuscar);
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Controls.Add(this.lblQtdChamados);
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 530);
            this.panel1.TabIndex = 38;
            // 
            // dataGridBuscar
            // 
            this.dataGridBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataCodigo,
            this.Código,
            this.dataTipo,
            this.dt,
            this.DataEncerramento,
            this.lider,
            this.Solicitante,
            this.nome,
            this.indevido,
            this.Observação,
            this.dataSetor,
            this.dataMotivo,
            this.dataModulo,
            this.dataReferencia,
            this.Cor,
            this.Tam,
            this.PTP,
            this.Qnt});
            this.dataGridBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBuscar.Location = new System.Drawing.Point(0, 0);
            this.dataGridBuscar.Name = "dataGridBuscar";
            this.dataGridBuscar.RowHeadersWidth = 51;
            this.dataGridBuscar.Size = new System.Drawing.Size(1356, 530);
            this.dataGridBuscar.TabIndex = 9;
            // 
            // dataCodigo
            // 
            this.dataCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataCodigo.DataPropertyName = "IdSolicitacao";
            this.dataCodigo.HeaderText = "Codigo";
            this.dataCodigo.MinimumWidth = 6;
            this.dataCodigo.Name = "dataCodigo";
            this.dataCodigo.Width = 80;
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Código.DataPropertyName = "Status";
            this.Código.HeaderText = "Status";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.Width = 125;
            // 
            // dataTipo
            // 
            this.dataTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataTipo.DataPropertyName = "Tipo";
            this.dataTipo.HeaderText = "Tipo";
            this.dataTipo.MinimumWidth = 6;
            this.dataTipo.Name = "dataTipo";
            this.dataTipo.Width = 140;
            // 
            // dt
            // 
            this.dt.DataPropertyName = "DataAbertura";
            this.dt.HeaderText = "Data Abertura";
            this.dt.MinimumWidth = 6;
            this.dt.Name = "dt";
            this.dt.Width = 125;
            // 
            // DataEncerramento
            // 
            this.DataEncerramento.DataPropertyName = "DataEncerramento";
            this.DataEncerramento.HeaderText = "Data Encerramento";
            this.DataEncerramento.MinimumWidth = 6;
            this.DataEncerramento.Name = "DataEncerramento";
            this.DataEncerramento.Width = 125;
            // 
            // lider
            // 
            this.lider.DataPropertyName = "Lider";
            this.lider.HeaderText = "Lider";
            this.lider.MinimumWidth = 6;
            this.lider.Name = "lider";
            this.lider.ReadOnly = true;
            this.lider.Width = 125;
            // 
            // Solicitante
            // 
            this.Solicitante.DataPropertyName = "Nome";
            this.Solicitante.HeaderText = "Solicitante";
            this.Solicitante.MinimumWidth = 6;
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.Width = 125;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "Responsavel";
            this.nome.HeaderText = "Atendente";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 150;
            // 
            // indevido
            // 
            this.indevido.DataPropertyName = "Indevido";
            this.indevido.HeaderText = "Indevido";
            this.indevido.MinimumWidth = 6;
            this.indevido.Name = "indevido";
            this.indevido.ReadOnly = true;
            this.indevido.Width = 125;
            // 
            // Observação
            // 
            this.Observação.DataPropertyName = "Obser";
            this.Observação.HeaderText = "Observação Atendente";
            this.Observação.MinimumWidth = 6;
            this.Observação.Name = "Observação";
            this.Observação.Width = 125;
            // 
            // dataSetor
            // 
            this.dataSetor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataSetor.DataPropertyName = "Setor";
            this.dataSetor.HeaderText = "Setor";
            this.dataSetor.MinimumWidth = 6;
            this.dataSetor.Name = "dataSetor";
            this.dataSetor.Width = 140;
            // 
            // dataMotivo
            // 
            this.dataMotivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataMotivo.DataPropertyName = "Motivo";
            this.dataMotivo.HeaderText = "Motivo";
            this.dataMotivo.MinimumWidth = 6;
            this.dataMotivo.Name = "dataMotivo";
            this.dataMotivo.Width = 140;
            // 
            // dataModulo
            // 
            this.dataModulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataModulo.DataPropertyName = "Modulo";
            this.dataModulo.HeaderText = "Modulo";
            this.dataModulo.MinimumWidth = 6;
            this.dataModulo.Name = "dataModulo";
            this.dataModulo.Width = 140;
            // 
            // dataReferencia
            // 
            this.dataReferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataReferencia.DataPropertyName = "Referencia";
            this.dataReferencia.HeaderText = "Referência";
            this.dataReferencia.MinimumWidth = 6;
            this.dataReferencia.Name = "dataReferencia";
            this.dataReferencia.Width = 140;
            // 
            // Cor
            // 
            this.Cor.DataPropertyName = "Cor";
            this.Cor.HeaderText = "Cor";
            this.Cor.MinimumWidth = 6;
            this.Cor.Name = "Cor";
            this.Cor.Width = 125;
            // 
            // Tam
            // 
            this.Tam.DataPropertyName = "Tamanho";
            this.Tam.HeaderText = "Tamanho";
            this.Tam.MinimumWidth = 6;
            this.Tam.Name = "Tam";
            this.Tam.Width = 125;
            // 
            // PTP
            // 
            this.PTP.DataPropertyName = "Parte";
            this.PTP.HeaderText = "Parte da Peça";
            this.PTP.MinimumWidth = 6;
            this.PTP.Name = "PTP";
            this.PTP.Width = 125;
            // 
            // Qnt
            // 
            this.Qnt.DataPropertyName = "Quant";
            this.Qnt.HeaderText = "Quant";
            this.Qnt.MinimumWidth = 6;
            this.Qnt.Name = "Qnt";
            this.Qnt.Width = 125;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTexto.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTexto.Location = new System.Drawing.Point(58, 21);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(158, 15);
            this.lblTexto.TabIndex = 8;
            this.lblTexto.Text = "Chamados encontrados";
            // 
            // lblQtdChamados
            // 
            this.lblQtdChamados.AutoSize = true;
            this.lblQtdChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblQtdChamados.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblQtdChamados.Location = new System.Drawing.Point(12, 21);
            this.lblQtdChamados.Name = "lblQtdChamados";
            this.lblQtdChamados.Size = new System.Drawing.Size(15, 15);
            this.lblQtdChamados.TabIndex = 7;
            this.lblQtdChamados.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(139, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Setor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(344, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Motivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(503, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Modulo";
            // 
            // mskData1
            // 
            this.mskData1.Location = new System.Drawing.Point(15, 176);
            this.mskData1.Mask = "00/00/0000";
            this.mskData1.Name = "mskData1";
            this.mskData1.Size = new System.Drawing.Size(121, 20);
            this.mskData1.TabIndex = 44;
            this.mskData1.ValidatingType = typeof(System.DateTime);
            // 
            // mskData2
            // 
            this.mskData2.Location = new System.Drawing.Point(142, 176);
            this.mskData2.Mask = "00/00/0000";
            this.mskData2.Name = "mskData2";
            this.mskData2.Size = new System.Drawing.Size(121, 20);
            this.mskData2.TabIndex = 45;
            this.mskData2.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "Periodo Dê";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(142, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Periodo Até";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(268, 174);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 24);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnExportar.IconColor = System.Drawing.Color.Black;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.IconSize = 20;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.Location = new System.Drawing.Point(347, 174);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(73, 24);
            this.btnExportar.TabIndex = 48;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.brnExportar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafico.IconChar = FontAwesome.Sharp.IconChar.FileMedicalAlt;
            this.btnGrafico.IconColor = System.Drawing.Color.Black;
            this.btnGrafico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrafico.IconSize = 20;
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrafico.Location = new System.Drawing.Point(427, 174);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(73, 24);
            this.btnGrafico.TabIndex = 49;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.UseVisualStyleBackColor = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // FrmExportaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskData2);
            this.Controls.Add(this.mskData1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboModulo);
            this.Controls.Add(this.comboMotivo);
            this.Controls.Add(this.comboSetor);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmExportaRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exporta Relatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmExportaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ComboBox comboSetor;
        private System.Windows.Forms.ComboBox comboMotivo;
        private System.Windows.Forms.ComboBox comboModulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskData1;
        private System.Windows.Forms.MaskedTextBox mskData2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridBuscar;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblQtdChamados;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnGrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEncerramento;
        private System.Windows.Forms.DataGridViewTextBoxColumn lider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn indevido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observação;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSetor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tam;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnt;
    }
}