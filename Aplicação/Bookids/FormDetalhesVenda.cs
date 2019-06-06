using System;
using System.Collections;
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
            ArrayList listboxProdutos = new ArrayList();
        }

        private void FormDetalhesVenda_Load(object sender, EventArgs e)
        {
            carregarDadosVenda(compraAtiva);
            carregarComboTipo();
            carregarListaCompras();
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

        public void carregarListaProdutos()
        {
            var listaProdutos = from Produtos in BookidsContainer.ProdutosSet
                                orderby Produtos.Designacao
                                where Produtos.TipoProduto.CodTipoProduto ==
                            ((TipoProduto)cbTipoProduto.SelectedItem).CodTipoProduto
                                select Produtos;
            lbProdutos.DataSource = listaProdutos.ToList<Produtos>();
        }

        private void carregarDadosVenda(Compras compra)
        {
            dtpDataVenda.Value = compra.Data;
            if (compra.UtilizouCartao == true)
            {
                checkCartaoCliente.Checked = true;
            }
            else
            {
                checkCartaoCliente.Checked = false;
            }

            
        }

        public void carregarListaCompras()
        {
            var listaDetalhesCompra = from DetalheCompras in BookidsContainer.DetalheComprasSet
                                      orderby DetalheCompras.CodProduto
                                      where DetalheCompras.NrCompra == compraAtiva.NrCompra
                                      select DetalheCompras;
            lbDetalhesVenda.DataSource = listaDetalhesCompra.ToList<DetalheCompras>();
        }



        private void cbTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarListaProdutos();
            lbProdutos.ClearSelected();
        }

        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                DetalheCompras detalhes = (DetalheCompras)compraAtiva.DetalheCompras;

                Produtos produto = (Produtos)lbProdutos.SelectedItem;
                if (produto != null && nmQuantidade.Value > 0)
                {
                    detalhes.CodProduto = produto.CodProduto;
                    detalhes.NrCompra = compraAtiva.NrCompra;
                    detalhes.Quantidade = (int)nmQuantidade.Value;
                }
                BookidsContainer.SaveChanges();

                // PARA GRAVAR NO FIM ADICIONA-SE OS ITEMS A LISTBOX E NO FIM GUARDA AS ALTERAÇOES NA BD
                // PARA ALTERAR PODE APAGAR OS DADOS DO DETALHE PARA GUARDAR DE NOVO OS ITEMS DA LIST BOX

                }
                catch
                {

                }               
           
        }

        private void btRemoverProduto_Click(object sender, EventArgs e)
        {

        }

        private void lbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btAdicionarProduto.Enabled = true;
        }
    }
}
