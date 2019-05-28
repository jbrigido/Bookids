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
    public partial class FormClientes : Form
    {
        private ModelBookidsContainer BookidsContainer;

        public FormClientes()
        {
            InitializeComponent();
            BookidsContainer = new ModelBookidsContainer();

            carregarClientes();
            
        }

        private void carregarClientes()
        {
            var listaClientes = from clientes in BookidsContainer.ClientesSet
                                orderby clientes.Nome
                                select clientes;
            clientesBindingSource.DataSource = listaClientes.ToList();

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }


        /* Função para verificar o preenchimento das tb relativo aos dados dos clientes */
        private bool dadosPreenchidosClientes()
        {
            var op = true;

            if(tbNomeCli.Text == string.Empty)
            {
                op = false;
            }

            if (tbMoradaCli.Text == string.Empty)
            {
                op = false;
            }

            if (tbCodPostalCli.Text == string.Empty)
            {
                op = false;
            }

            if (tbLocalidadeCli.Text == string.Empty)
            {
                op = false;
            }

            if (tbTelemovelCli.Text.Trim() == string.Empty && tbTelefoneCli.Text.Trim() == string.Empty)
            {
                tbTelemovelCli.Focus();
                op = false;
            }

            return op;
        }

        private void dgvClientes_MouseClick(object sender, MouseEventArgs e)
        {
            Clientes cliente = (Clientes)dgvClientes.SelectedRows[0].DataBoundItem;
            if (cliente != null)
            {
                filhosBindingSource.DataSource = cliente.Filhos.ToList<Filhos>();
                tbNomeCli.Text = cliente.Nome;
                tbCartaoCli.Text = cliente.NrCartao;
                nmValorOferta.Value = (Int32)cliente.ValorOferta;
                tbLocalidadeCli.Text = cliente.Localidade;
                tbMoradaCli.Text = cliente.Morada;
                tbCodPostalCli.Text = cliente.CodPostal;
                tbTelemovelCli.Text = cliente.Telemovel;
                tbTelefoneCli.Text = cliente.Telefone;
                tbMailCli.Text = cliente.Mail;
            }
        }

        private void btCriarCliente_Click(object sender, EventArgs e)
        {
            if (dadosPreenchidosClientes())
            {
                Clientes novo = new Clientes()
                {
                    Nome = tbNomeCli.Text,
                    Morada = tbMoradaCli.Text,
                    Localidade = tbLocalidadeCli.Text,
                    CodPostal = tbCodPostalCli.Text,
                    Telefone = tbTelefoneCli.Text,
                    Telemovel = tbTelemovelCli.Text,
                    Mail = tbMailCli.Text,
                    //Valor Oferta para decimal?
                    ValorOferta = (Int32)nmValorOferta.Value,
                    NrCartao = tbCartaoCli.Text,
                };
                BookidsContainer.ClientesSet.Add(novo);
                BookidsContainer.SaveChanges();
                dgvClientes.DataSource = BookidsContainer.ClientesSet.ToList();   
            }
        }

        private bool dadosPreenchidosFilhos()
        {
            if (tbNomeFilho.Text == string.Empty)
            {
                return false;
            }
           
            if (dtpDataNascFilho.Value == null)
            {
                return false;
            }

            if (cbSexoFilho.Text == string.Empty)
            {
                return false;
            }

            return true;
            
        }

        private void dgvFilhos_MouseClick(object sender, MouseEventArgs e)
        {
            Filhos filho = (Filhos)dgvFilhos.SelectedRows[0].DataBoundItem;
            if (filho != null)
            {
                tbNomeFilho.Text = filho.Nome;
                dtpDataNascFilho.Value = filho.DataNascicmento;
                cbSexoFilho.Text = filho.Sexo;
                //cbEscolaFilho.Text = ;
            }
        }

        private void btAdicionarFilho_Click(object sender, EventArgs e)
        {
            Clientes cliente = (Clientes)dgvClientes.SelectedRows[0].DataBoundItem;
            if (cliente != null)
            {
                if (dadosPreenchidosFilhos())
                {
                    Filhos novo = new Filhos()
                    {
                        Nome = tbNomeFilho.Text,
                        DataNascicmento = dtpDataNascFilho.Value,
                        Sexo = cbSexoFilho.Text,
                        IdProgenitor = cliente.IdPessoa,
                        IdEscola = 1,

                        Morada = cliente.Morada,
                        Localidade = cliente.Localidade,
                        CodPostal = cliente.CodPostal,
                        Telefone = cliente.Telefone,
                        Telemovel = cliente.Telemovel,
                        Mail = cliente.Mail
                    };

                }
            }
            
        }
    }
}
