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
            limparDadosVendas();
        }

        public void carregarComboClientes()
        {
            var listaClientes = from Clientes in BookidsContainer.ClientesSet
                                orderby Clientes.Nome
                                select Clientes;
            cbClientes.DataSource = listaClientes.ToList<Clientes>();
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
        }

        private void btRegistarVenda_Click(object sender, EventArgs e)
        {
            Compras nova = new Compras()
            {
                IdCliente = ((Clientes)cbClientes.SelectedItem).IdPessoa,
                Data = DateTime.Now,
                UtilizouCartao = true
            };
            BookidsContainer.ComprasSet.Add(nova);
            BookidsContainer.SaveChanges();
            carregarDadosVendas((Clientes)cbClientes.SelectedItem);
            /*
            try
            {
                FormDetalhesVenda formDetalhesVenda = new FormDetalhesVenda();
                formDetalhesVenda.ShowDialog();
            }
            catch
            {

            }
            */
        }

        private void btEditarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Compras compra = (Compras)dgvVendas.SelectedRows[0].DataBoundItem;
                FormDetalhesVenda formDetalhesVenda = new FormDetalhesVenda(compra);
                formDetalhesVenda.ShowDialog();
            }
            catch
            {

            }
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarDadosVendas((Clientes)cbClientes.SelectedItem);
        }

        private void dgvVendas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Compras compra = (Compras)dgvVendas.SelectedRows[0].DataBoundItem;
                btRegistarVenda.Enabled = false;
                btEditarVenda.Enabled = true;
                btApagarVenda.Enabled = true;
                btCancelCleanVenda.Enabled = true;
            }
            catch
            {

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
                catch
                {

                }
            }
        }

        private void btCancelCleanVenda_Click(object sender, EventArgs e)
        {
            dgvVendas.ClearSelection();
            dgvDetalhesCompra.ClearSelection();
            btRegistarVenda.Enabled = true;
            btEditarVenda.Enabled = false;
            btGuardarVenda.Enabled = false;
            btApagarVenda.Enabled = false;
            btCancelCleanVenda.Enabled = false;
        }
    }
}
