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
    public partial class FrmExportaRelatorio : Form
    {

        public FrmExportaRelatorio()
        {
            InitializeComponent();
            dataGridBuscar.AutoGenerateColumns = false;
            btnExportar.Enabled = false;
            btnGrafico.Enabled = false;
        }

        SolicitacoesADO solicit = new SolicitacoesADO();
        List<Solicitacao> lstSolicitacoes;

        DateTime data2;
        string data1;
        string data3;
        private void btnBuscar_Click(object sender, EventArgs e)
        /*TIPO-SETOR-MOTIVO - MODULO e REFERENCIA e o periodo de busca*/
        {
            Solicitacao solicita = new Solicitacao();

            //Convertendo valor das combo para int
            solicita.Tipo = Convert.ToString(comboTipo.SelectedValue);
            solicita.Setor = Convert.ToString(comboSetor.SelectedValue);

            try
            {
                data1 = mskData1.Text;
                data1 += " 00:00";

                data3 = mskData2.Text;
                data3 += " 23:59";

            }
            catch (Exception)
            {

                MessageBox.Show("Insira um período válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            solicita.Status = "";
            solicita.Tipo = comboTipo.Text;
            solicita.Setor = comboSetor.Text;
            solicita.Motivo = comboMotivo.Text;
            solicita.Modulo = comboModulo.Text;

            if (mskData1.Text == "  /  /" && mskData2.Text == "  /  /")
            {
                MessageBox.Show("Digite um período válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                if (Convert.ToDateTime(data3) < Convert.ToDateTime(data1))
                {
                    MessageBox.Show("A data de abertura ou de encerramento não podem ser inferiores! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (mskData1.Text != "  /  /" && mskData2.Text != "  /  /")
                    {
                        lstSolicitacoes = solicit.BuscarSolicitacao(solicita, Convert.ToDateTime(data1), Convert.ToDateTime(data3));

                        if (lstSolicitacoes.Count != 0)
                        {
                            btnExportar.Enabled = true;
                            btnGrafico.Enabled = true;
                            dataGridBuscar.DataSource = null;
                            dataGridBuscar.DataSource = lstSolicitacoes;
                            //dataGridBuscar.AutoResizeColumns();
                            lblQtdChamados.Text = dataGridBuscar.RowCount.ToString();
                        }
                        else
                        {
                            MessageBox.Show(" Não existe nenhum registro para os critérios de seleção definidos ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridBuscar.DataSource = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira um período válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
        }


        private void brnExportar_Click(object sender, EventArgs e)
        {
            //Solicitacao solicitacao = new Solicitacao();
            ////COLCOAR UMA FUNÇÃO QUE O BOTÃO DE EXPORTAR E DE GERAR GRAFICO SÓ HABILITA SE COUNT > 0
            //solicitacao.Status = "";
            //solicitacao.Setor = comboSetor.Text;
            //solicitacao.Motivo = comboMotivo.Text;
            //solicitacao.Modulo = comboModulo.Text;
            //solicitacao.DataAbertura = Convert.ToDateTime(mskData1.Text);
            //solicitacao.DataEncerramento = Convert.ToDateTime(mskData2.Text);

            //data1 = mskData1.Text;
            //data1 += " 00:00";

            //data3 = mskData2.Text;
            //data3 += " 23:59";

            //solicitacao.DataAbertura = Convert.ToDateTime(data1);
            //data2 = Convert.ToDateTime(data3);

            try
            {
                //lstSolicitacoes = solicit.BuscarSolicitacao(solicitacao, Convert.ToDateTime(data1), Convert.ToDateTime(data3));
                //List<Solicitacao> receb = solicit.BuscarSolicitacao(solicitacao, Convert.ToDateTime(data3), Convert.ToDateTime(data1));

                FrmReport obj = new FrmReport(lstSolicitacoes);
                obj.Show();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {

            if (mskData1.Text != "  /  /" && mskData2.Text != "  /  /")
            {
                //GerarGrafico();

                GraficoSolicit obj = new GraficoSolicit(lstSolicitacoes, mskData1.Text, mskData2.Text);
                obj.Show();

            }
            else
            {
                MessageBox.Show("Digite um período válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void FrmExportaRelatorio_Load(object sender, EventArgs e)
        {
            CriarDropModulo();
            CriarDropSetor();
            CriarDropMotivo();
        }

        private void CriarDropModulo()
        {
            foreach (var item in ListaComboBox.Modulos())
            {
                comboModulo.Items.Add(item);
            }
        }

        private void CriarDropSetor()
        {
            foreach (var item in ListaComboBox.Setor())
            {

                comboSetor.Items.Add(item);
            }
        }

        private void CriarDropMotivo()
        {
            foreach (var item in ListaComboBox.Motivos())
            {
                comboMotivo.Items.Add(item);
            }
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //private void FrmExportaRelatorio_Load(object sender, EventArgs e)
        //{

        //}
    }
}
