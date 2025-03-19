using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cbxCategoria.Text))
            {
                Erro("Campo Categoria não pode estar Vazia!");
                return;
            }
            ////Verifica 
            else if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                Erro("Campo Nome do produto não pode estar Vazia!");
                return;
            }
            else if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                Erro("Campo Nome do produto não pode estar Vazia!");
                return;
            }
            ////Verifica 
            else if (string.IsNullOrEmpty(dtpDataValidade.Text))
            {
                Erro("Campo Data de vencimento do produto não pode estar Vazia!");
                return;
            }
            else
            {
                Sucesso("Produto Cadastrado com sucesso!");

            }

            Produto prod = new Produto();
            prod.Codigo = Convert.ToInt32(txtCodigo.Text);
            prod.Nome = txtNomeProduto.Text;
            prod.Categoria = cbxCategoria.SelectedItem?.ToString();
            prod.Preco = (double)nudPreco.Value;
            prod.DataVencimento = dtpDataValidade.Text;
            prod.Observacao = txtObservacao.Text;

            Produto.ListaProdutos.Add(prod);

            txtCodigo.Text = (Produto.ListaProdutos.Count + 1).ToString();

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = "00" + (Produto.ListaProdutos.Count + 1).ToString();
            txtCodigo.Enabled = false;
            cbxCategoria.SelectedIndex = 0;

        }
    }
}
