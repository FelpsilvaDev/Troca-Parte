namespace AtendimentoTrocaParte
{
    partial class FrmFilaAtendimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilaAtendimento));
            this.dataGridSolicitacoes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.comboModulo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSolicitacoes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSolicitacoes
            // 
            this.dataGridSolicitacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSolicitacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSolicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSolicitacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitacao,
            this.stat,
            this.obs,
            this.dt,
            this.lider,
            this.sol,
            this.atendente,
            this.setor,
            this.motivo,
            this.mod,
            this.refe,
            this.cor,
            this.tam,
            this.ptpec,
            this.quant});
            this.dataGridSolicitacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSolicitacoes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSolicitacoes.Location = new System.Drawing.Point(15, 87);
            this.dataGridSolicitacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridSolicitacoes.Name = "dataGridSolicitacoes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSolicitacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSolicitacoes.RowHeadersVisible = false;
            this.dataGridSolicitacoes.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridSolicitacoes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridSolicitacoes.RowTemplate.Height = 24;
            this.dataGridSolicitacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSolicitacoes.Size = new System.Drawing.Size(1885, 422);
            this.dataGridSolicitacoes.TabIndex = 49;
            this.dataGridSolicitacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSolicitacoes_CellContentClick);
            this.dataGridSolicitacoes.DoubleClick += new System.EventHandler(this.dataGridSolicitacoes_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(129)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.comboModulo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1903, 82);
            this.panel1.TabIndex = 50;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 23;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBuscar.Location = new System.Drawing.Point(216, 37);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 33);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboModulo
            // 
            this.comboModulo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboModulo.FormattingEnabled = true;
            this.comboModulo.Location = new System.Drawing.Point(15, 37);
            this.comboModulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboModulo.Name = "comboModulo";
            this.comboModulo.Size = new System.Drawing.Size(193, 29);
            this.comboModulo.TabIndex = 9;
            this.comboModulo.SelectedIndexChanged += new System.EventHandler(this.comboModulo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Módulo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // IdSolicitacao
            // 
            this.IdSolicitacao.DataPropertyName = "IdSolicitacao";
            this.IdSolicitacao.HeaderText = "Código";
            this.IdSolicitacao.MinimumWidth = 6;
            this.IdSolicitacao.Name = "IdSolicitacao";
            this.IdSolicitacao.ReadOnly = true;
            this.IdSolicitacao.Width = 75;
            // 
            // stat
            // 
            this.stat.DataPropertyName = "Status";
            this.stat.HeaderText = "Status";
            this.stat.MinimumWidth = 6;
            this.stat.Name = "stat";
            this.stat.Width = 125;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "Tipo";
            this.obs.HeaderText = "Tipo";
            this.obs.MinimumWidth = 6;
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Width = 125;
            // 
            // dt
            // 
            this.dt.DataPropertyName = "DataAbertura";
            this.dt.HeaderText = "Data Abertura";
            this.dt.MinimumWidth = 6;
            this.dt.Name = "dt";
            this.dt.Width = 125;
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
            // sol
            // 
            this.sol.DataPropertyName = "Nome";
            this.sol.HeaderText = "Solicitante";
            this.sol.MinimumWidth = 6;
            this.sol.Name = "sol";
            this.sol.Width = 125;
            // 
            // atendente
            // 
            this.atendente.DataPropertyName = "Responsavel";
            this.atendente.HeaderText = "Atendente";
            this.atendente.MinimumWidth = 6;
            this.atendente.Name = "atendente";
            this.atendente.ReadOnly = true;
            this.atendente.Width = 125;
            // 
            // setor
            // 
            this.setor.DataPropertyName = "Setor";
            this.setor.HeaderText = "Setor";
            this.setor.MinimumWidth = 6;
            this.setor.Name = "setor";
            this.setor.Width = 125;
            // 
            // motivo
            // 
            this.motivo.DataPropertyName = "Motivo";
            this.motivo.HeaderText = "Motivo";
            this.motivo.MinimumWidth = 6;
            this.motivo.Name = "motivo";
            this.motivo.Width = 125;
            // 
            // mod
            // 
            this.mod.DataPropertyName = "Modulo";
            this.mod.HeaderText = "Módulo";
            this.mod.MinimumWidth = 6;
            this.mod.Name = "mod";
            this.mod.Width = 125;
            // 
            // refe
            // 
            this.refe.DataPropertyName = "Referencia";
            this.refe.HeaderText = "Referência";
            this.refe.MinimumWidth = 6;
            this.refe.Name = "refe";
            this.refe.Width = 125;
            // 
            // cor
            // 
            this.cor.DataPropertyName = "Cor";
            this.cor.HeaderText = "Cor";
            this.cor.MinimumWidth = 6;
            this.cor.Name = "cor";
            this.cor.Width = 125;
            // 
            // tam
            // 
            this.tam.DataPropertyName = "Tamanho";
            this.tam.HeaderText = "Tamanho";
            this.tam.MinimumWidth = 6;
            this.tam.Name = "tam";
            this.tam.ReadOnly = true;
            this.tam.Width = 125;
            // 
            // ptpec
            // 
            this.ptpec.DataPropertyName = "Parte";
            this.ptpec.HeaderText = "Parte da Peça";
            this.ptpec.MinimumWidth = 6;
            this.ptpec.Name = "ptpec";
            this.ptpec.ReadOnly = true;
            this.ptpec.Width = 125;
            // 
            // quant
            // 
            this.quant.DataPropertyName = "Quant";
            this.quant.HeaderText = "Quant";
            this.quant.MinimumWidth = 6;
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            this.quant.Width = 125;
            // 
            // FrmFilaAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1903, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridSolicitacoes);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmFilaAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fila de Atendimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFilaAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSolicitacoes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridSolicitacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboModulo;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn lider;
        private System.Windows.Forms.DataGridViewTextBoxColumn sol;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn refe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
    }
}