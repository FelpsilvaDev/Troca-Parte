using AtendimentoTrocaParte.ADO.NET;
using AtendimentoTrocaParte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtendimentoTrocaParte
{
    public partial class FrmFilaAtendimento : Form
    {
        public FrmFilaAtendimento()
        {
            InitializeComponent();

            dataGridSolicitacoes.AutoGenerateColumns = false;

            comboModulo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        SolicitacoesADO db = new SolicitacoesADO();
        List<Solicitacao> lstFilaAtendimento;
        string data1;
        string data3;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //List<Solicitacao> lista = db.ListarChamados(mskdata1.Text);


            Solicitacao solicita = new Solicitacao();

            solicita.Modulo = comboModulo.Text;

            lstFilaAtendimento = db.ListarChamados("ABERTO", comboModulo.Text);

            if (lstFilaAtendimento.Count != 0)
            {
                dataGridSolicitacoes.DataSource = null;
                dataGridSolicitacoes.DataSource = lstFilaAtendimento;
                //dataGridBuscar.AutoResizeColumns();
            }

            //if (comboModulo.Text != "")
            //{
            //    dataGridSolicitacoes.DataSource = null;
            //    dataGridSolicitacoes.DataSource = lista.Where(ls => ls.DataAbertura >= dt1 && ls.DataAbertura <= dt2 && ls.Modulo == comboModulo.Text).OrderBy(ls => ls.DataAbertura).ToList();
            //}
            //else
            //{
            //    dataGridSolicitacoes.DataSource = null;
            //    dataGridSolicitacoes.DataSource = lista.Where(ls => ls.DataAbertura >= dt1 && ls.DataAbertura <= dt2).OrderBy(ls => ls.DataAbertura).ToList();

            //}


            if (lstFilaAtendimento.Count == 0)
            {
                MessageBox.Show("Nenhum registro encontrado para o filtro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void FrmFilaAtendimento_Load(object sender, EventArgs e)
        {
            CriarDropModulo();
            try
            {
                dataGridSolicitacoes.DataSource = null;
                dataGridSolicitacoes.DataSource = db.ListarChamados("ABERTO", comboModulo.Text);
                //dataGridSolicitacoes.AutoResizeColumns();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar solicitações em tela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CriarDropModulo()
        {
            foreach (var item in ListaComboBox.Modulos())
            {
                comboModulo.Items.Add(item);
            }
        }
        private void dataGridSolicitacoes_DoubleClick(object sender, EventArgs e)
        {

            int posicao = dataGridSolicitacoes.SelectedCells[0].RowIndex;
            DataGridViewRow linha = dataGridSolicitacoes.Rows[posicao];
            int codigo = Convert.ToInt32(linha.Cells[0].Value);
            string status = linha.Cells[1].Value.ToString();
            if (status != "ENTREGUE")
            {
                FrmAdministracao obj = new FrmAdministracao(codigo, this);
                obj.ShowDialog();
            }

        }

        public void CarregarDataGrid()
        {
            try
            {
                dataGridSolicitacoes.DataSource = null;
                dataGridSolicitacoes.DataSource = db.ListarChamados("ABERTO", comboModulo.Text);
                dataGridSolicitacoes.AutoResizeColumns();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar solicitações em tela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridSolicitacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboModulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
