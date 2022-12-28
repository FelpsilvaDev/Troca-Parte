using AtendimentoTrocaParte.Models;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmReport : Form
    {
        //Solicitacao solicit;
        List<Solicitacao> listaOficial;
        public FrmReport(List<Solicitacao> lista)
        {
            InitializeComponent();

            listaOficial = lista;
        }
        private void FrmReport_Load(object sender, EventArgs e)
        {

            ReportDataSource lst = new ReportDataSource("Report1", listaOficial);
            SolicitacaobindingSource.DataSource = listaOficial;
            reportViewer1.LocalReport.DataSources.Add(lst);
            //reportViewer1.LocalReport.DataSources.Add(lst);
            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
        }

    }
}