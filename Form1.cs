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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFilaAtend_Click(object sender, EventArgs e)
        {
            FrmFilaAtendimento obj = new FrmFilaAtendimento();
            obj.ShowDialog();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            FrmCriarSol obj = new FrmCriarSol();

            obj.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            FrmAdministracao obj = new FrmAdministracao();
            obj.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmVersion version = new FrmVersion();
            version.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmExportaRelatorio obj = new FrmExportaRelatorio();
            obj.ShowDialog();
        }
    }
}
