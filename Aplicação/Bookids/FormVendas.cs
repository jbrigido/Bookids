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
            dgvVendas.Columns[0].HeaderText = "Nº Cartão";
            BookidsContainer = new ModelBookidsContainer();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            carregarDadosVendas();
            carregarComboTipo();
            carregarComboClientes();
            limparDadosVendas();
        }

        public void carregarComboClientes()
        {
            var listaClientes = from Clientes in BookidsContainer.ClientesSet
                                orderby Clientes.Nome
                                select Clientes;
            cbClientes.DataSource = listaClientes.ToList<Clientes>();
        }

        private void carregarDadosVendas()
        {
            var listaVendas = from Compras in BookidsContainer.ComprasSet
                              orderby Compras.Data
                              select Compras;
            comprasBindingSource.DataSource = listaVendas.ToList();
        }

        private void carregarComboTipo()
        {
            var listaTipos = from TipoProduto in BookidsContainer.TipoProdutoSet
                             orderby TipoProduto.Tipo
                             select TipoProduto;
            cbTipoProduto.DataSource = listaTipos.ToList<TipoProduto>();
            carregarListaProtudos();
        }

        public void carregarListaProtudos()
        {
            var listaProdutos = from Produtos in BookidsContainer.ProdutosSet
                                orderby Produtos.Designacao
                                where Produtos.TipoProduto.CodTipoProduto == 
                            ((TipoProduto)cbTipoProduto.SelectedItem).CodTipoProduto
                                select Produtos;
            lbProdutos.DataSource = listaProdutos.ToList<Produtos>();
            //lbProdutos.ClearSelected();
        }

        private void limparDadosVendas()
        {
            dgvVendas.ClearSelection();
            tbNrCartao.Clear();
            tbValorOferta.Clear();
            btRegistarVenda.Enabled = true;
            btGuardarVenda.Enabled = false;
            btEditarVenda.Enabled = false;
            btApagarVenda.Enabled = false;
            btCancelCleanVenda.Enabled = false;
            gbDetalhesVenda.Enabled = false;
        }

        private void btRegistarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes cliente = (Clientes)cbClientes.SelectedItem;
                dgvVendas.ClearSelection();
                btRegistarVenda.Enabled = false;
                btGuardarVenda.Enabled = true;
                btCancelCleanVenda.Enabled = true;
                gbDetalhesVenda.Enabled = true;
            }
            catch
            {

            }
        }
    }
}
