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
    public partial class GraficoSolicit : Form
    {

        public GraficoSolicit(List<Solicitacao> _lstSolicitGrafico, string dt1, string dt2)
        {

            InitializeComponent();
            lstGrafico = _lstSolicitGrafico;
            mskDataGrafico1.Text = dt1;
            mskDataGrafico2.Text = dt2;

        }
        List<Solicitacao> lstGrafico = new List<Solicitacao>();
        List<Solicitacao> lstModulos = new List<Solicitacao>();
        List<Solicitacao> lstMotivo = new List<Solicitacao>();
        UsuarioADO usuarioADO = new UsuarioADO();
        SolicitacoesADO solicit = new SolicitacoesADO();
        string data1;
        string data3;


        public class Tipos
        {
            public string Tipo { get; set; }
            public string Setor { get; set; }
            public string Modulo { get; set; }
            public string Motivo { get; set; }
            public int IdAtendente { get; set; }
        }



        List<SolicitacaoModel> lstchart1 = new List<SolicitacaoModel>();
        List<SolicitacaoModel> lstchart2 = new List<SolicitacaoModel>();
        List<SolicitacaoModel> lstchart3 = new List<SolicitacaoModel>();
        List<SolicitacaoModel> lstchart4 = new List<SolicitacaoModel>();
        List<SolicitacaoModel> lstchart5 = new List<SolicitacaoModel>();
        List<Solicitacao> lstAtentedentes = new List<Solicitacao>();
        //CRIADO O ARRAY PARA TRAZER AS INFORMAÇÕES DE MÓDULO PARA O GRÁFICO
        string[] Tipo = new string[2] { "SOLICITAÇÃO", "URGENTE" };
        string[] Setor = new string[9] { "TECIDO", "RENDA" , "ALÇA", "ALMOXARIFADO" ,"SEPARAÇÃO" ,"MOLDADO","VIÉS" ,"ETIQUETA" , "DESENV. PRODUTO" };

        private void GraficoSolicit_Load(object sender, EventArgs e)
        {
            List<Usuario> lstUsuario = usuarioADO.ListarUsuarios();

            // ClearGrafico();
            ClearChart();
            ListarModuloMotivo();

            GerarGrafico(lstModulos, lstchart3, lstUsuario, lstchart5, lstMotivo, lstchart4);
        }

        internal void Show(List<Solicitacao> lstSolicitacoes)
        {
            throw new NotImplementedException();
        }

        private void btnBuscagfc_Click(object sender, EventArgs e)
        {

            try
            {
                data1 = mskDataGrafico1.Text;
                data1 += " 00:00";

                data3 = mskDataGrafico2.Text;
                data3 += " 23:59";

                if (Convert.ToDateTime(data1) > Convert.ToDateTime(data3))
                {
                    MessageBox.Show("A data de abertura ou de encerramento não podem ser inferiores! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ClearGrafico();
                    ClearChart();

                    lstGrafico = solicit.BuscarSolicitacao(Convert.ToDateTime(data1), Convert.ToDateTime(data3));
                    List<Usuario> lstUsuario = usuarioADO.ListarUsuarios();

                    ListarModuloMotivo();

                    GerarGrafico(lstModulos, lstchart3, lstUsuario, lstchart5, lstMotivo, lstchart4);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Insira um período válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ListarModuloMotivo()
        {
            lstModulos = lstGrafico.GroupBy(x => x.Modulo).Select(y => y.First()).ToList();
            lstMotivo = lstGrafico.GroupBy(x => x.Motivo).Select(y => y.First()).ToList();
        }
        private void ClearGrafico()
        {

            lstchart1.Clear();
            lstchart2.Clear();
            lstchart3.Clear();
            lstchart4.Clear();
            lstchart5.Clear();
            lstModulos.Clear();
            lstMotivo.Clear();
            lstGrafico.Clear();

        }
        private void ClearChart()
        {
            chartAtendente.Series["Atendentes"].Points.Clear();
            chartModulo.Series["Modulo"].Points.Clear();
            chartMotivo.Series["Motivo"].Points.Clear();
            chartTipos.Series["Tipos"].Points.Clear();
            chart1.Series["Setor"].Points.Clear();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GraficoPorMotivo(List<Solicitacao> lstMotivo, List<SolicitacaoModel> lstchart4)
        {
            foreach (var item in lstMotivo)
            {
                SolicitacaoModel solic = new SolicitacaoModel();

                foreach (var motivo in lstGrafico.Where(x => x.Motivo == item.Motivo))
                {
                    solic.Param1 = item.Motivo;
                    solic.Param2 += 1;
                }
                if (solic.Param1 != null)
                {
                    lstchart4.Add(solic);
                }
            }

            foreach (var item in lstchart4)
            {
                chartMotivo.Series["Motivo"].Points.AddXY(item.Param1, item.Param2);
            }

            chartMotivo.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void GraficoPorModulo(List<Solicitacao> lstModulos, List<SolicitacaoModel> lstchart3)

        {

            foreach (var item in lstModulos)
            {
                SolicitacaoModel solic = new SolicitacaoModel();

                foreach (var modulo in lstGrafico.Where(x => x.Modulo.Trim() == item.Modulo).ToList())
                {

                    solic.Param1 = item.Modulo;
                    solic.Param2 += 1;

                }

                if (solic.Param1 != null)
                    lstchart3.Add(solic);
            }
            foreach (var item in lstchart3)
            {
                //chartModulo.Series["Modulo"].Points.AddXY(item.Key, item.Value);

                chartModulo.Series["Modulo"].Points.AddXY(item.Param1, item.Param2);
            }
        }

        private void GraficoPorAtendente(List<Usuario> lstUsuario, List<SolicitacaoModel> lstchart5)
        {           
                foreach (var item in lstUsuario)
                {
                    SolicitacaoModel solic = new SolicitacaoModel();

                    foreach (var atend in lstGrafico.Where(x => x.Responsavel == item.Nome).ToList())
                    {
                        solic.Param1 = item.Nome;
                        solic.Param2 += 1; //commit teste 
                    }
                    if (solic.Param1 != null)
                    {
                        lstchart5.Add(solic);
                    }
                }
            
            foreach (var item in lstchart5)
            {
                chartAtendente.Series["Atendentes"].Points.AddXY(item.Param1, item.Param2);
            }
        }

            private void GerarPorTipo(string[] tipo, List<SolicitacaoModel> lstchart1)
            {
                //BUSCANDO POR TIPO
                for (int i = 0; i < Tipo.Length; i++)
                {
                    SolicitacaoModel solic = new SolicitacaoModel();

                    foreach (var tipos in lstGrafico.Where(x => x.Tipo == Tipo[i]).ToList())
                    {
                        solic.Param1 = Tipo[i];
                        solic.Param2 += 1;
                    }
                    if (solic.Param1 != null)
                    {
                        lstchart1.Add(solic);
                    }
                }

                foreach (var item in lstchart1)
                {
                    chartTipos.Series["Tipos"].Points.AddXY(item.Param1, item.Param2);
                }
            }

            public void GerarPorSetor(string[] Setor, List<SolicitacaoModel> lstchart2)
            {
                //BUSCANDO POR SETOR
                for (int i = 0; i < Setor.Length; i++)
                {
                    SolicitacaoModel solic = new SolicitacaoModel();

                    foreach (var setor in lstGrafico.Where(x => x.Setor.Trim() == Setor[i].ToString()).ToList())
                    {
                        solic.Param1 = Setor[i];
                        solic.Param2 += 1;
                    }

                    if (solic.Param1 != null)
                        lstchart2.Add(solic);
                }


                foreach (var item in lstchart2)
                {
                    chart1.Series["Setor"].Points.AddXY(item.Param1, item.Param2);
                }
            }

            private void GerarGrafico(List<Solicitacao> lstModulos, List<SolicitacaoModel> lstchart3, List<Usuario> lstUsuario, List<SolicitacaoModel> lstchart5,
                List<Solicitacao> lstMotivo, List<SolicitacaoModel> lstchart4)
            {
                GerarPorTipo(Tipo, lstchart1);
                GerarPorSetor(Setor, lstchart2);
                GraficoPorModulo(lstModulos, lstchart3);
                GraficoPorMotivo(lstMotivo, lstchart4);
                GraficoPorAtendente(lstUsuario, lstchart5);
            }

            private void panel3_Paint(object sender, PaintEventArgs e)
            {

            }

            private void iconButton1_Click(object sender, EventArgs e)
            {

            }
        }
    }
