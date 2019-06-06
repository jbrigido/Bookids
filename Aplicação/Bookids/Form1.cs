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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
        }

        private void btEventos_Click(object sender, EventArgs e)
        {
            FormEventos formEventos = new FormEventos();
            formEventos.ShowDialog();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            FormProdutosLoja formProdutosLoja = new FormProdutosLoja();
            formProdutosLoja.ShowDialog();

        }

        private void btEscolas_Click(object sender, EventArgs e)
        {
            FormEscolas formEscolas = new FormEscolas();
            formEscolas.ShowDialog();
        }

        private void btAnimadores_Click(object sender, EventArgs e)
        {
            FormAnimadores formAnimadores = new FormAnimadores();
            formAnimadores.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lbInfo.Focus();
        }

        private void btVendas_Click(object sender, EventArgs e)
        {
            FormVendas formVendas = new FormVendas();
            formVendas.ShowDialog();
        }
    }
}
