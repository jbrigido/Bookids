using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids
{
    public partial class FormProdutosLoja : Form
    {
        private ModelBookidsContainer BookidsContainer;

        public FormProdutosLoja()
        {
            InitializeComponent();
            BookidsContainer = new ModelBookidsContainer();
        }

        private void FormProdutosLoja_Load(object sender, EventArgs e)
        {
            carregarProdutos();
            carregarComboTipo();
            tbDesignacao.Enabled = false;
            nmPreco.Enabled = false;
            nmStockProduto.Enabled = false;
            cbTipoProduto.Enabled = false;
            btEditarProduto.Enabled = false;
            btGuardarProduto.Enabled = false;
            btApagarProduto.Enabled = false;
            btCancelClean.Enabled = false;
        }

        private void carregarProdutos()
        {
            var listaProdutos = from Produtos in BookidsContainer.ProdutosSet
                                orderby Produtos.Designacao
                                select Produtos;
            produtosBindingSource.DataSource = listaProdutos.ToList();
        }

        private void carregarComboTipo()
        {
            var listaTipos = from TipoProduto in BookidsContainer.TipoProdutoSet
                             orderby TipoProduto.Tipo
                             select TipoProduto;
            cbTipoProduto.DataSource = listaTipos.ToList<TipoProduto>();
            //cbTipoProduto.DisplayMember = "Tipo";
            //cbTipoProduto.ValueMember = "CodTipoProduto";
        }

        private void cbTipoProduto_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuEditarTipo.Show((ComboBox)sender, e.Location);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbTipoProduto.DropDownStyle = ComboBoxStyle.Simple;
            cbTipoProduto.Text = string.Empty;
        }

        private bool dadosPreenchidosProduto()
        {
            if (tbDesignacao.Text == string.Empty)
            {
                return false;
            }

            if (nmPreco.Value <= 0)
            {
                return false;
            }

            if (nmStockProduto.Value < 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Desbloqueia as textbox relativas ao Produto
        /// Limpa as textbox relativas ao Produto e torna-as editaveis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            dgvProdutosLoja.ClearSelection();
            btAdicionarProduto.Enabled = false;
            tbDesignacao.Enabled = true;
            nmPreco.Enabled = true;
            nmPreco.Value = 0.01m;
            nmStockProduto.Enabled = true;
            nmStockProduto.Value = 0;
            cbTipoProduto.Enabled = true;
        }


        /// <summary>
        /// Guardar dados do Produto.
        /// Se a textbox CodProduto estiver vazia verifica se todas as outras estão preeenchidas
        /// e cria um novo Produto com os dados nas textboxs atuazlizando a gridview no fim
        /// Se a textbox CodProduto estiver preenchida verifica o Produto selecionado na gridview
        /// verifica os dados das textboxs e guarda os mesmo no Produto selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGuardarProduto_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja guardar as alterações efetuadas?",
                "Guardar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                //tbCodProduto não é editavel, se estiver vazia, não existe produto selecionado
                if (tbCodProduto.Text == string.Empty)
                {
                    if (dadosPreenchidosProduto())
                    {
                        Produtos novo = new Produtos()
                        {
                            Designacao = tbDesignacao.Text,
                            Preco = nmPreco.Value,
                            StockExistente = (Int32)nmStockProduto.Value,
                            CodTipoProduto = ((TipoProduto)cbTipoProduto.SelectedItem).CodTipoProduto
                        };
                        BookidsContainer.ProdutosSet.Add(novo);
                        BookidsContainer.SaveChanges();
                        carregarProdutos();
                    }
                }
                else
                {
                    Produtos produto = (Produtos)dgvProdutosLoja.SelectedRows[0].DataBoundItem;
                    if (dadosPreenchidosProduto())
                    {
                        produto.Designacao = tbDesignacao.Text;
                        produto.Preco = nmPreco.Value;
                        produto.StockExistente = (Int32)nmStockProduto.Value;
                        //produto.CodTipoProduto = (Int32)cbTipoProduto.SelectedValue;
                        produto.CodTipoProduto = ((TipoProduto)cbTipoProduto.SelectedItem).CodTipoProduto;
                        BookidsContainer.SaveChanges();
                    }

                }
                carregarProdutos();
                tbDesignacao.Enabled = false;
                nmPreco.Enabled = false;
                nmStockProduto.Enabled = false;
                cbTipoProduto.Enabled = false;
            }

            if (dr == DialogResult.No)
            {
                tbDesignacao.Enabled = false;
                nmPreco.Enabled = false;
                nmStockProduto.Enabled = false;
                cbTipoProduto.Enabled = false;
            }

        }


        private void btAdicionarTipo_Click(object sender, EventArgs e)
        {
            if (cbTipoProduto.Text != string.Empty)
            {
                TipoProduto novoTipo = new TipoProduto() { Tipo = cbTipoProduto.Text };
                BookidsContainer.TipoProdutoSet.Add(novoTipo);
                BookidsContainer.SaveChanges();
                cbTipoProduto.DropDownStyle = ComboBoxStyle.DropDownList;
                carregarComboTipo();
            }
        }

        //Carrega a informação do produto selecionado para as text boxs
        /// <summary>
        /// Carrega as textbox relativas ao Produto selecionado na data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProdutosLoja_MouseClick(object sender, MouseEventArgs e)
        {
            Produtos produto = (Produtos)dgvProdutosLoja.SelectedRows[0].DataBoundItem;
            if (produto != null)
            {
                tbCodProduto.Text = Convert.ToString(produto.CodProduto);
                tbDesignacao.Text = produto.Designacao;
                nmPreco.Value = produto.Preco;
                nmStockProduto.Value = produto.StockExistente;
                cbTipoProduto.Text = produto.TipoProduto.Tipo;
            }
        }



        //Habilita a edição nas textboxs
        private void btEditarProduto_Click(object sender, EventArgs e)
        {
            tbDesignacao.Enabled = true;
            nmPreco.Enabled = true;
            nmStockProduto.Enabled = true;
            cbTipoProduto.Enabled = true;
        }

        private void btApagarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produto = (Produtos)dgvProdutosLoja.SelectedRows[0].DataBoundItem;
                BookidsContainer.ProdutosSet.Remove(produto);
                BookidsContainer.SaveChanges();
                carregarProdutos();
            }
            catch
            {
                MessageBox.Show("Nenhum produto selecionado!");
            }
            

        }

        private void btCancelClean_Click(object sender, EventArgs e)
        {
            dgvProdutosLoja.ClearSelection();
            tbCodProduto.Clear();
            tbDesignacao.Clear();
            nmStockProduto.ResetText();
            nmPreco.ResetText();
            tbDesignacao.Enabled = true;
            nmPreco.Enabled = true;
            nmStockProduto.Enabled = true;
            cbTipoProduto.Enabled = true;
            btAdicionarProduto.Enabled = true;
            btGuardarProduto.Enabled = false;
            btEditarProduto.Enabled = false;
            btApagarProduto.Enabled = false;
            btCancelClean.Enabled = false;
        }
    }
}
