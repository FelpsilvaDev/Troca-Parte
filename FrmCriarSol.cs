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
    public partial class FrmCriarSol : Form
    {
        public FrmCriarSol()

        {
            InitializeComponent();

            comboMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            SolicitacoesADO db = new SolicitacoesADO();

            if (comboSetor.Text != "" && comboTipo.Text != "" && comboModulo.Text != "" && txtNome.Text != "" && txtRef.Text != "" && txtCor.Text != "" && txtTam.Text != "" && txtQuant.Text != "" && txtLider.Text !="" && comboMotivo.Text != "")
            {
                Solicitacao solicitacao = new Solicitacao();

                solicitacao.DataAbertura = DateTime.Now;
                solicitacao.Nome = txtNome.Text.ToUpper();
                solicitacao.Modulo = comboModulo.Text.ToUpper();
                solicitacao.Referencia = txtRef.Text.ToUpper();
                solicitacao.Setor = comboSetor.Text.ToUpper();
                solicitacao.Tipo = comboTipo.Text.ToUpper();
                solicitacao.Motivo = comboMotivo.Text;
                solicitacao.Cor = txtCor.Text.ToUpper();
                solicitacao.Tamanho = txtTam.Text.ToUpper();
                solicitacao.Quant = txtQuant.Text.ToUpper();
                solicitacao.Parte = txtParte.Text.ToUpper();
                solicitacao.Lider = txtLider.Text.ToUpper();


                try
                {
                    db.CriarChamado(solicitacao);
                    LimparCampos();
                    MessageBox.Show("Solicitação criada com sucesso ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar solitação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("Preencher todos os campos: " , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LimparCampos()
        {
            txtCor.Text = "";
            txtTam.Text = "";
            txtQuant.Text = "";
            txtRef.Text = "";
            txtParte.Text = "";
            txtNome.Text = "";
            comboModulo.Text = "";
            txtLider.Text = "";
            comboMotivo.Text = "";
            comboSetor.Text = "";
            comboTipo.Text = "";
            comboModulo.SelectedIndex = -1;
            comboMotivo.SelectedIndex = -1;
            comboSetor.SelectedIndex = -1;
            comboTipo.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            this.Close();

        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboSetor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCriarSol_Load(object sender, EventArgs e)
        {
            CriarDropModulo();
            CriarDropMotivo();
            CriarDropSetor();
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

        private void comboModulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
