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
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }
        UsuarioADO userADO = new UsuarioADO();
        string senhaUser;
        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            dataGridView1.AutoGenerateColumns = false;

            CarregarDataGrid();

            ComboAtivo.DropDownStyle = ComboBoxStyle.DropDownList;


        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && ComboAtivo.SelectedIndex.ToString() != "")
            {
                Usuario usuario = new Usuario();

                usuario.Nome = txtNome.Text.ToUpper();
                usuario.Ativo = ComboAtivo.Text == "Sim" ? "S" : "N";
                usuario.Tipo = "COMUM";
                usuario.Senha = txtSenha.Text;

                try
                {
                    if (btnNovo.Text == "Alterar")
                    {
                        if (txtSenha.Text == "")
                        {
                            usuario.Senha = senhaUser;
                        }
                        else
                        {
                            usuario.Senha = txtSenha.Text;
                        }
                        usuario.IdAtendente = Convert.ToInt32(txtCodigo.Text);
                        userADO.AlterarUsuario(usuario);
                        MessageBox.Show("Usuário Alterado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (txtSenha.Text != "")
                        {
                            userADO.CadastrarUsuario(usuario);
                            MessageBox.Show("Usuário Cadastrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Informe uma senha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    btnNovo.Text = "Cadastrar";

                    CarregarDataGrid();


                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao realizar cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CarregarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = userADO.ListarUsuarios().Where(x => x.IdAtendente != 1 && x.IdAtendente != 13).ToList();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            ComboAtivo.SelectedIndex = -1;
            txtSenha.Text = "";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int posicao = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow linha = dataGridView1.Rows[posicao];

            int codigo = Convert.ToInt32(linha.Cells[0].Value);

            Usuario usuario = new Usuario();
            usuario = userADO.PesquisarPorCodigo(codigo);
            senhaUser = usuario.Senha;



            btnNovo.Text = "Alterar";
            txtCodigo.Text = linha.Cells["idatendente"].Value.ToString();
            txtNome.Text = linha.Cells["nome"].Value.ToString();

            if (linha.Cells["ativo"].Value.ToString() == "Sim")
            {
                ComboAtivo.SelectedIndex = 1;
            }
            else
            {
                ComboAtivo.SelectedIndex = 0;

            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
