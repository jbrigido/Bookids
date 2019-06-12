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
    public partial class FormVendas : Form
    {
        private ModelBookidsContainer BookidsContainer;

        public FormVendas()
        {
            InitializeComponent();
            BookidsContainer = new ModelBookidsContainer();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            carregarComboClientes();
            carregarComboTipo();
            limparDadosVendas();
        }

        public void carregarComboClientes()
        {
            var listaClientes = from Clientes in BookidsContainer.ClientesSet
                                orderby Clientes.Nome
                                select Clientes;
            cbClientes.DataSource = listaClientes.ToList<Clientes>();
        }

        private void carregarComboTipo()
        {
            var listaTipos = from TipoProduto in BookidsContainer.TipoProdutoSet
                             orderby TipoProduto.Tipo
                             select TipoProduto;
            cbTipoProduto.DataSource = listaTipos.ToList<TipoProduto>();
        }

        private void carregarDadosVendas(Clientes cliente)
        {
            var listaVendas = from Compras in BookidsContainer.ComprasSet
                              where Compras.IdCliente == cliente.IdPessoa
                              orderby Compras.Data
                              select Compras;
            comprasBindingSource.DataSource = listaVendas.ToList();
            tbNrCartao.Text = cliente.NrCartao;
            tbValorOferta.Text = Convert.ToString(cliente.ValorOferta);
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

        public void carregarListaCompras(Compras compraAtiva)
        {
            var listaDetalhesCompra = from DetalheCompras in BookidsContainer.DetalheComprasSet
                                      orderby DetalheCompras.CodProduto
                                      where DetalheCompras.NrCompra == compraAtiva.NrCompra
                                      select DetalheCompras;
            detalheComprasBindingSource.DataSource = listaDetalhesCompra.ToList();
        }

        private void limparDadosVendas()
        {
            dgvVendas.ClearSelection();
            dgvVendas.Enabled = true;
            dgvDetalhesCompra.DataSource = null;
            tbNrCartao.Clear();
            tbValorOferta.Clear();
            btRegistarVenda.Enabled = true;
            btGuardarVenda.Enabled = false;
            btEditarVenda.Enabled = false;
            btApagarVenda.Enabled = false;
            btCancelCleanVenda.Enabled = false;
            dgvDetalhesCompra.Enabled = false;
            btRemoverProduto.Enabled = false;
            btImprimir.Enabled = false;
            gbProdutos.Enabled = false;
        }

        private void btRegistarVenda_Click(object sender, EventArgs e)
        {
            dgvVendas.ClearSelection();
            dgvVendas.Enabled = false;
            btRegistarVenda.Enabled = false;
            btGuardarVenda.Enabled = true;
            btCancelCleanVenda.Enabled = true;
            Compras nova = new Compras()
            {
                IdCliente = ((Clientes)cbClientes.SelectedItem).IdPessoa,
                Data = DateTime.Now,
                UtilizouCartao = false
            };
            BookidsContainer.ComprasSet.Add(nova);
            BookidsContainer.SaveChanges();
            dgvDetalhesCompra.Enabled = true;
            gbProdutos.Enabled = true;
        }

        private void btEditarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Compras compra = (Compras)dgvVendas.SelectedRows[0].DataBoundItem;
                dgvVendas.Enabled = false;
                btRegistarVenda.Enabled = false;
                btGuardarVenda.Enabled = true;
                btCancelCleanVenda.Enabled = true;
                dgvDetalhesCompra.Enabled = true;
                gbProdutos.Enabled = true;
                carregarListaCompras(compra);
            }
            catch
            {

            }
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btRegistarVenda.Enabled = true;
            carregarDadosVendas((Clientes)cbClientes.SelectedItem);
        }

        private void dgvVendas_MouseClick(object sender, MouseEventArgs e)
        {
            Compras compra = (Compras)dgvVendas.SelectedRows[0].DataBoundItem;
            if (compra != null) { 
                btRegistarVenda.Enabled = false;
                btEditarVenda.Enabled = true;
                btApagarVenda.Enabled = true;
                btCancelCleanVenda.Enabled = true;
            } 
        }

        private void btApagarVenda_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem a certeza que deseja apagar?",
                "Apagar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    Compras compra = (Compras)dgvVendas.SelectedRows[0].DataBoundItem;
                    BookidsContainer.ComprasSet.Remove(compra);
                    BookidsContainer.SaveChanges();
                    carregarDadosVendas((Clientes)cbClientes.SelectedItem);
                    limparDadosVendas();
                }
                catch(ArgumentOutOfRangeException)
                {

                }
            }
        }

        private void btCancelCleanVenda_Click(object sender, EventArgs e)
        {
            limparDadosVendas();
        }

        private void cbTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarListaProdutos();
            lbProdutos.ClearSelected();
        }

        private void dgvDetalhesCompra_MouseClick(object sender, MouseEventArgs e)
        {
            btRemoverProduto.Enabled = true;
        }

        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produtos produto = (Produtos)lbProdutos.SelectedItem;
            /*foreach (Produtos prod in lbProdutos.Items)
            {
                if (prod.CodProduto == ((Produtos)lbProdutos.SelectedItem).CodProduto)
                {
                    cbTipoProduto.DropDownStyle = ComboBoxStyle.DropDownList;
                    carregarComboTipo();
                    return;
                }
            }*/
            if (produto != null && nmQuantidade.Value <= produto.StockExistente)
            {
                DetalheCompras novo = new DetalheCompras()
                {
                    Quantidade = (Int32)nmQuantidade.Value,
                    NrCompra = ((Compras)dgvVendas.SelectedRows[0].DataBoundItem).NrCompra,
                    CodProduto = produto.CodProduto
                };
                BookidsContainer.DetalheComprasSet.Add(novo);
                produto.StockExistente -= novo.Quantidade;
                BookidsContainer.SaveChanges();
                carregarListaCompras((Compras)dgvVendas.SelectedRows[0].DataBoundItem);
                carregarListaProdutos();
            }
            else
            {
                MessageBox.Show("Stock insuficiente!");
            }
        }
    }
}
