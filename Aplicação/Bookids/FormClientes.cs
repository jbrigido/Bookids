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
            carregarClientes();
            carregarComboEscola();
            limparDadosFilhos();
            limparDadosClientes();
        }


        /// <summary>
        /// FUNCIONALIDADES DO FORMULÁRIO RELATIVA À GESTÃO DOS CLIENTES
        /// </summary>

        private void carregarClientes()
        {
            var listaClientes = from clientes in BookidsContainer.ClientesSet
                                orderby clientes.Nome
                                select clientes;
            clientesBindingSource.DataSource = listaClientes.ToList();
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
            btAdicionarClientes.Enabled = true;
            btGuardarClientes.Enabled = false;
            btEditarClientes.Enabled = false;
            btApagarClientes.Enabled = false;
            btAdicionarFilhos.Enabled = false;
            btCancelCleanFilhos.Enabled = false;
            dgvClientes.Enabled = true;

        }

        /* Função para verificar o preenchimento das tb relativo aos dados dos clientes */
        private bool dadosPreenchidosClientes()
        {
            if(tbNomeCli.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                tbNomeCli.Focus();
                return false;
            }

            if (tbMoradaCli.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                tbMoradaCli.Focus();
                return false;
            }

            if (tbCodPostalCli.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                tbCodPostalCli.Focus();
                return false;
            }

            if (tbLocalidadeCli.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                tbLocalidadeCli.Focus();
                return false;
            }

            if (tbTelemovelCli.Text.Trim() == string.Empty && tbTelefoneCli.Text.Trim() == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
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

                btAdicionarClientes.Enabled = false;
                btEditarClientes.Enabled = true;
                btApagarClientes.Enabled = true;
                btAdicionarFilhos.Enabled = true;
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
            catch(ArgumentOutOfRangeException)
            {
                btAdicionarFilhos.Enabled = false;
                btCancelCleanFilhos.Enabled = false;

            }
            dgvFilhos.ClearSelection();
        }

        private void btCancelCleanClientes_Click(object sender, EventArgs e)
        {
            dgvFilhos.Rows.Clear();
            limparDadosClientes();
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
            dgvClientes.Enabled = false;
        }

        private void btEditarClientes_Click(object sender, EventArgs e)
        {
            btEditarClientes.Enabled = false;
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
            dgvClientes.Enabled = false;
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
                    carregarClientes();
                    limparDadosClientes();
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
                        carregarClientes();
                        limparDadosClientes();
                    }
                }
            }
        }


     /// <summary>
     /// FUNCIONALIDADES DO FORMULÁRIO RELATIVA À GESTÃO DOS FILHOS DOS CLIENTES
     /// </summary>

        private void carregarFilhos()
        {
            var listaFilhos = from Filhos in BookidsContainer.FilhosSet
                              orderby Filhos.Nome
                              select Filhos;
            filhosBindingSource.DataSource = listaFilhos.ToList();
        }

        private void carregarFilhos(Clientes cliente)
        {
            var listaFilhos = from Filhos in BookidsContainer.FilhosSet
                              where Filhos.IdProgenitor == cliente.IdPessoa
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

        private void limparDadosFilhos()
        {
            tbNomeFilho.Clear();
            tbNomeFilho.Enabled = false;
            cbEscolaFilho.Enabled = false;
            cbSexoFilho.Enabled = false;
            dtpDataNascFilho.Enabled = false;
            btAdicionarFilhos.Enabled = true;
            btEditarFilhos.Enabled = false;
            btGuardarFilhos.Enabled = false;
            btApagarFilhos.Enabled = false;
            dgvFilhos.ClearSelection();
            dgvFilhos.Enabled = true;
        }

        private bool dadosPreenchidosFilhos()
        {
            if (tbNomeFilho.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                tbNomeFilho.Focus();
                return false;
            }
           
            if (dtpDataNascFilho.Value == null)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                return false;
            }

            if (cbSexoFilho.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                cbSexoFilho.Focus();
                return false;
            }

            if (cbEscolaFilho.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                cbEscolaFilho.Focus();
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

        private void btAdicionarFilho_Click(object sender, EventArgs e)
        {
            dgvFilhos.ClearSelection();
            btAdicionarFilhos.Enabled = false;
            btEditarFilhos.Enabled = true;
            btGuardarFilhos.Enabled = true;
            tbNomeFilho.Enabled = true;
            cbEscolaFilho.Enabled = true;
            cbSexoFilho.Enabled = true;
            dtpDataNascFilho.Enabled = true;
            dgvFilhos.Enabled = false;
        }

        private void btCancelCleanFilhos_Click(object sender, EventArgs e)
        {
            limparDadosFilhos();
        }

        private void btEditarFilhos_Click(object sender, EventArgs e)
        {
            btEditarFilhos.Enabled = false;
            btGuardarFilhos.Enabled = true;
            tbNomeFilho.Enabled = true;
            cbEscolaFilho.Enabled = true;
            cbSexoFilho.Enabled = true;
            dtpDataNascFilho.Enabled = true;
            dgvFilhos.Enabled = false;
        }

        private void btGuardarFilhos_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja guardar as alterações efectuadas?",
                "Guardar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    Clientes cliente = (Clientes)dgvClientes.SelectedRows[0].DataBoundItem;
                    try
                    {
                        Filhos filho = (Filhos)dgvFilhos.SelectedRows[0].DataBoundItem;
                        if (dadosPreenchidosFilhos())
                        {
                            filho.Nome = tbNomeFilho.Text;
                            filho.DataNascicmento = dtpDataNascFilho.Value;
                            filho.Sexo = cbSexoFilho.Text;
                            filho.IdEscola = ((Escolas)cbEscolaFilho.SelectedItem).IdEscola;
                        }
                        BookidsContainer.SaveChanges();
                        carregarFilhos(cliente);
                        limparDadosFilhos();
                    }
                    catch (ArgumentOutOfRangeException ex)
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
                            carregarFilhos(cliente);
                            limparDadosFilhos();
                        }
                    }
                }
                catch
                {

                }

                
            }
        }

        private void btApagarClientes_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem a certeza que deseja apagar?",
                "Apagar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Clientes cliente = (Clientes)dgvClientes.SelectedRows[0].DataBoundItem;
                if (cliente != null)
                {
                    //COMO REMOVER OS FILHOS DO CLIENTE REMOVIDO?
                    while (cliente.Filhos.Count > 0)
                    {
                        foreach (Filhos filho in filhosBindingSource)
                        {
                            if(cliente.IdPessoa == filho.IdProgenitor)
                            {
                                BookidsContainer.FilhosSet.Remove(filho);
                            }
                        }
                    }
                    BookidsContainer.ClientesSet.Remove(cliente);
                    BookidsContainer.SaveChanges();
                    carregarFilhos(cliente);
                    carregarClientes();
                    limparDadosClientes();
                    limparDadosFilhos();
                }
            }
        }

        private void btApagarFilhos_Click(object sender, EventArgs e)
        {
            Clientes cliente = (Clientes)dgvClientes.SelectedRows[0].DataBoundItem;
            DialogResult dr = MessageBox.Show("Tem a certeza que deseja apagar?",
                "Apagar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                    Filhos filho = (Filhos)dgvFilhos.SelectedRows[0].DataBoundItem;
                    if (filho != null)
                    {
                        //COMO REMOVER OS FILHOS DO CLIENTE REMOVIDO?
                        BookidsContainer.FilhosSet.Remove(filho);
                        BookidsContainer.SaveChanges();
                        carregarFilhos(cliente);
                        limparDadosFilhos();
                        limparDadosClientes();

                    }                
            }

        }
    }
}
