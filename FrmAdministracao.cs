using AtendimentoTrocaParte.ADO.NET;
using AtendimentoTrocaParte.Models;
using MySql.Data.MySqlClient;
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
    public partial class FrmAdministracao : Form
    {
        private bool abrirCadastroUsuario = false;

        public FrmAdministracao(int idchamado, FrmFilaAtendimento frmFilaAtendimento)
        {
            InitializeComponent();
            comboResp.DropDownStyle = ComboBoxStyle.DropDownList;
            chamado = idchamado;
            fila = frmFilaAtendimento;
            comboIndevido.SelectedIndex = 0;
            comboIndevido.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public FrmAdministracao()
        {
            InitializeComponent();
            abrirCadastroUsuario = true;
            txtObs.Visible = false;
            label3.Visible = false;
            comboIndevido.Visible = false;
            label5.Visible = false;
            //comboIndevido.SelectedIndex = 0;
            //comboIndevido.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        UsuarioADO db = new UsuarioADO();
        FrmFilaAtendimento fila;
        Usuario resultado ;
        int chamado;
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool resp1 = ValidarLogin();
            Usuario autentica = new Usuario();
            autentica.Nome = comboResp.Text;
            autentica.Senha = txtPass.Text;


            //if (recebeInstancia.GetType() == typeof(FrmFilaAtendimento))
            //{
            //    var receb = recebeInstancia as FrmFilaAtendimento;
            //    receb.dataGridSolicitacoes.SelectedRows = comboResp.Text();
            //}   
            try
            {
                resultado = db.AutenticarUsuario(autentica);

            }
            catch (Exception)
            {

                throw;
            }
           
            try
            {
                if (abrirCadastroUsuario)
                {
                    if (resultado.IdAtendente > 0)
                    {
                        if (resultado.Tipo.ToUpper().Trim().Equals("ADMIN"))
                        {
                            FrmCadastroUsuario cad = new FrmCadastroUsuario();
                            cad.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("você não é um usuário administrador!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos", "erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    if (resp1 == true)
                    {
                        DialogResult resp = MessageBox.Show("Deseja realmente encerrar esse atendimento ? ", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        try
                        {
                            if (resp == DialogResult.Yes)
                            {

                                SolicitacoesADO solicitacoesADO = new SolicitacoesADO();
                                Solicitacao solicitacao = new Solicitacao();

                                solicitacao.Status = "ENTREGUE";
                                solicitacao.DataEncerramento = DateTime.Now;
                                solicitacao.IdAtendente = Convert.ToInt32(comboResp.SelectedValue);
                                solicitacao.IdSolicitacao = chamado;
                                solicitacao.Indevido = comboIndevido.Text.ToUpper();
                                solicitacao.Obser = txtObs.Text.ToUpper();                                

                                solicitacoesADO.AlterarChamado(solicitacao);

                                MessageBox.Show("Solicitação encerrada com sucesso !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fila.CarregarDataGrid();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Senha inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                        txtPass.Text = "";
                        txtPass.Focus();
                
        }

        private bool ValidarLogin()
        {
            bool retorno = false;
            List<Usuario> lista = new List<Usuario>();

            lista = db.ListarUsuarios().Where(ls => ls.Ativo != "N").ToList();

            int codigo = Convert.ToInt32(comboResp.SelectedValue);

            foreach (var item in lista)
            {
                if (item.IdAtendente == codigo)
                {
                    if (item.Senha == txtPass.Text)
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                    }


                }
            }

            return retorno;

        }

        private void FrmAdministracao_Load(object sender, EventArgs e)
        {
            comboResp.DataSource = db.ListarUsuarios().Where(ls => ls.Ativo != "N" && ls.IdAtendente != 1).ToList();
            comboResp.DisplayMember = "Nome";
            comboResp.ValueMember = "IdAtendente";
            comboResp.SelectedIndex = -1;
        }
    }
}
