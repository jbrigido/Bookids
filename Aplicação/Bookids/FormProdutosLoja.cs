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
            carregarComboTipo();
            carregarProdutos();
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

        private void btGuardar_Click(object sender, EventArgs e)
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

        private void dgvProdutosLoja_MouseClick(object sender, MouseEventArgs e)
        {
            Produtos produto = (Produtos)dgvProdutosLoja.SelectedRows[0].DataBoundItem;
            if (produto != null)
            {
                tbDesignacao.Text = produto.Designacao;
                nmPreco.Value = produto.Preco;
                nmStockProduto.Value = produto.StockExistente;
                cbTipoProduto.Text = produto.TipoProduto.Tipo;
            }
        }
    }
}
