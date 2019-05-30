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
            cbTipoProduto.DisplayMember = "Tipo";
            cbTipoProduto.ValueMember = "CodTipoProduto";
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

        //insere um novo produto se não tiver nenhum selecionado, se houver seleção
        //guarda os dados do produto selecionado. bloqueia as text boxs.
        private void btGuardar_Click(object sender, EventArgs e)
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
                            //código para carregar o tipo de produto da combo box
                            CodTipoProduto = (Int32)cbTipoProduto.SelectedValue
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
                        produto.CodTipoProduto = (Int32)cbTipoProduto.SelectedValue;
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
            if (cbTipoProduto != null)
            {
                TipoProduto novoTipo = new TipoProduto() { Tipo = cbTipoProduto.Text };
                BookidsContainer.TipoProdutoSet.Add(novoTipo);
                BookidsContainer.SaveChanges();
                carregarComboTipo();
            }
        }

        //Carrega a informação do produto selecionado para as text boxs
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

        //limpa e desbloqueia as text boxs para edição
        private void btInserirProduto_Click(object sender, EventArgs e)
        {
            dgvProdutosLoja.ClearSelection();
            tbDesignacao.Enabled = true;
            tbDesignacao.Clear();
            nmPreco.Enabled = true;
            nmPreco.Value = 0.01m;        
            nmStockProduto.Enabled = true;
            nmStockProduto.Value = 0;
            cbTipoProduto.Enabled = true;
        }

        private void btEditarProduto_Click(object sender, EventArgs e)
        {
            tbDesignacao.Enabled = true;
            nmPreco.Enabled = true;
            nmStockProduto.Enabled = true;
            cbTipoProduto.Enabled = true;
        }
    }
}
