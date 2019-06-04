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
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            limparDadosClientes();
            limparDadosFilhos();
            carregarClientes();
            carregarComboEscola();
        }

        private void carregarClientes()
        {
            var listaClientes = from clientes in BookidsContainer.ClientesSet
                                orderby clientes.Nome
                                select clientes;
            clientesBindingSource.DataSource = listaClientes.ToList();
        }

        private void carregarFilhos()
        {
            var listaFilhos = from Filhos in BookidsContainer.FilhosSet
                              orderby Filhos.Nome
                              select Filhos;
            filhosBindingSource.DataSource = listaFilhos.ToList();
        }

        private void carregarComboEscola()
        {
            var listaEscolas = from Escolas in BookidsContainer.EscolasSet
                             orderby Escolas.Nome
                             select Escolas;
            cbEscolaFilho.DataSource = listaEscolas.ToList<Escolas>();
        }

        private void limparDadosClientes()
        {
            dgvClientes.ClearSelection();
            tbNomeCli.Clear();
            tbMoradaCli.Clear();
            tbCodPostalCli.Clear();
            tbLocalidadeCli.Clear();
            tbTelefoneCli.Clear();
            tbTelemovelCli.Clear();
            tbMailCli.Clear();
            tbCartaoCli.Clear();
            nmValorOferta.ResetText();
            tbNomeCli.Enabled = false;
            tbMoradaCli.Enabled = false;
            tbCodPostalCli.Enabled = false;
            tbLocalidadeCli.Enabled = false;
            tbTelefoneCli.Enabled = false;
            tbTelemovelCli.Enabled = false;
            tbMailCli.Enabled = false;
            tbCartaoCli.Enabled = false;
            nmValorOferta.Enabled = false;
            btGuardarClientes.Enabled = false;
            btEditarClientes.Enabled = false;
            btApagarClientes.Enabled = false;
        }

        /* Função para verificar o preenchimento das tb relativo aos dados dos clientes */
        private bool dadosPreenchidosClientes()
        {
            if(tbNomeCli.Text == string.Empty)
            {
                tbNomeCli.Focus();
                return false;
            }

            if (tbMoradaCli.Text == string.Empty)
            {
                tbMoradaCli.Focus();
                return false;
            }

            if (tbCodPostalCli.Text == string.Empty)
            {
                tbCodPostalCli.Focus();
                return false;
            }

            if (tbLocalidadeCli.Text == string.Empty)
            {
                tbLocalidadeCli.Focus();
                return false;
            }

            if (tbTelemovelCli.Text.Trim() == string.Empty && tbTelefoneCli.Text.Trim() == string.Empty)
            {
                tbTelemovelCli.Focus();
                return false;
            }

            return true;
        }

        private void dgvClientes_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Clientes cliente = (Clientes)dgvClientes.SelectedRows[0].DataBoundItem;
                if (cliente != null)
                {
                    btAdicionarClientes.Enabled = false;
                    btEditarClientes.Enabled = true;
                    btApagarClientes.Enabled = true;
                    btCancelCleanFilhos.Enabled = true;

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
            catch(ArgumentOutOfRangeException)
            {

            }
            
        }

        private void btAdicionarClientes_Click(object sender, EventArgs e)
        {
            dgvClientes.ClearSelection();
            btAdicionarClientes.Enabled = false;
            btEditarClientes.Enabled = true;
            btGuardarClientes.Enabled = true;
            tbNomeCli.Enabled = true;
            tbMoradaCli.Enabled = true;
            tbCodPostalCli.Enabled = true;
            tbLocalidadeCli.Enabled = true;
            tbTelefoneCli.Enabled = true;
            tbTelemovelCli.Enabled = true;
            tbMailCli.Enabled = true;
            nmValorOferta.Enabled = true;
            tbCartaoCli.Enabled = true;
        }

        private void btEditarClientes_Click(object sender, EventArgs e)
        {
            btEditarClientes.Enabled = true;
            btGuardarClientes.Enabled = true;
            tbNomeCli.Enabled = true;
            tbMoradaCli.Enabled = true;
            tbCodPostalCli.Enabled = true;
            tbLocalidadeCli.Enabled = true;
            tbTelefoneCli.Enabled = true;
            tbTelemovelCli.Enabled = true;
            tbMailCli.Enabled = true;
            nmValorOferta.Enabled = true;
            tbCartaoCli.Enabled = true;
        }

        private void btGuardarClientes_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja guardar as alterações efectuadas?",
                "Guardar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    Clientes cliente = (Clientes)dgvClientes.SelectedRows[0].DataBoundItem;
                    if (dadosPreenchidosClientes())
                    {
                        btAdicionarClientes.Enabled = false;
                        cliente.Nome = tbNomeCli.Text;
                        cliente.Morada = tbMoradaCli.Text;
                        cliente.CodPostal = tbCodPostalCli.Text;
                        cliente.Localidade = tbLocalidadeCli.Text;
                        cliente.Telefone = tbTelefoneCli.Text;
                        cliente.Telemovel = tbTelemovelCli.Text;
                        cliente.Mail = tbMailCli.Text;
                        cliente.ValorOferta = (Int32)nmValorOferta.Value;
                        cliente.NrCartao = tbCartaoCli.Text;
                    }
                    BookidsContainer.SaveChanges();
                    limparDadosClientes();
                    carregarClientes();
                }
                catch (ArgumentOutOfRangeException ex)
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
                            ValorOferta = (Int32)nmValorOferta.Value,
                            NrCartao = tbCartaoCli.Text,
                        };
                        BookidsContainer.ClientesSet.Add(novo);
                        BookidsContainer.SaveChanges();
                        limparDadosClientes();
                        carregarClientes();
                    }
                }
            }
        }

        private void limparDadosFilhos()
        {
            dgvFilhos.ClearSelection();
            tbNomeFilho.Clear();
            tbNomeFilho.Enabled = false;
            cbEscolaFilho.Enabled = false;
            cbSexoFilho.Enabled = false;
            dtpDataNascFilho.Enabled = false;
            btEditarFilhos.Enabled = false;
            btApagarFilhos.Enabled = false;
            btGuardarFilhos.Enabled = false;

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
            try
            {
                Filhos filho = (Filhos)dgvFilhos.SelectedRows[0].DataBoundItem;
                if (filho != null)
                {
                    btAdicionarFilhos.Enabled = false;
                    btEditarFilhos.Enabled = true;
                    btApagarFilhos.Enabled = true;
                    btCancelCleanFilhos.Enabled = true;

                    tbNomeFilho.Text = filho.Nome;
                    dtpDataNascFilho.Value = filho.DataNascicmento;
                    cbSexoFilho.Text = filho.Sexo;
                    cbEscolaFilho.SelectedItem = filho.IdEscola;
                }
            }
            catch(ArgumentOutOfRangeException)
            {

            }
        }


        //A ALTERAR 
        private void btAdicionarFilho_Click(object sender, EventArgs e)
        {
            //Codigo do botao guardarFilho
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
                        IdEscola = ((Escolas)cbEscolaFilho.SelectedItem).IdEscola,
                        Morada = cliente.Morada,
                        Localidade = cliente.Localidade,
                        CodPostal = cliente.CodPostal,
                        Telefone = cliente.Telefone,
                        Telemovel = cliente.Telemovel,
                        Mail = cliente.Mail
                    };
                    BookidsContainer.FilhosSet.Add(novo);
                    BookidsContainer.SaveChanges();
                    carregarFilhos();
                }
            }
        }

        private void btCancelCleanClientes_Click(object sender, EventArgs e)
        {
            limparDadosClientes();
        }

        private void btCancelCleanFilhos_Click(object sender, EventArgs e)
        {
            limparDadosFilhos();
        }
    }
}
