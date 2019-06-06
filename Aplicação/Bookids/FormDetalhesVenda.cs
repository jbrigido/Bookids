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
    public partial class FormDetalhesVenda : Form
    {
        private ModelBookidsContainer BookidsContainer;
        private Compras compraAtiva;

        public FormDetalhesVenda()
        {
            InitializeComponent();
            BookidsContainer = new ModelBookidsContainer();
            compraAtiva = null;
        }

        public FormDetalhesVenda(Compras compra)
        {
            InitializeComponent();
            BookidsContainer = new ModelBookidsContainer();
            this.compraAtiva = compra;
        }

        private void carregarComboTipo()
        {
            var listaTipos = from TipoProduto in BookidsContainer.TipoProdutoSet
                             orderby TipoProduto.Tipo
                             select TipoProduto;
            cbTipoProduto.DataSource = listaTipos.ToList<TipoProduto>();
        }

        public void carregarListaProtudos()
        {
            var listaProdutos = from Produtos in BookidsContainer.ProdutosSet
                                orderby Produtos.Designacao
                                where Produtos.TipoProduto.CodTipoProduto ==
                            ((TipoProduto)cbTipoProduto.SelectedItem).CodTipoProduto
                                select Produtos;
            lbProdutos.DataSource = listaProdutos.ToList<Produtos>();
        }

        private void cbTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarListaProtudos();
            lbProdutos.ClearSelected();
        }

        private void FormDetalhesVenda_Load(object sender, EventArgs e)
        {

            carregarComboTipo();
            carregarListaProtudos();
        }
    }
}
