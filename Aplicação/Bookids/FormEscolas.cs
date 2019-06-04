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
    public partial class FormEscolas : Form

    {
        private ModelBookidsContainer BookidsContainer;

        public FormEscolas()
        {
            InitializeComponent();
            BookidsContainer = new ModelBookidsContainer();
        }

        private void FormEscolas_Load(object sender, EventArgs e)
        {
            carregarEscolas();
            limparDados();
        }

        private void carregarEscolas()
        {
            var listaEscolas = from Escolas in BookidsContainer.EscolasSet
                               orderby Escolas.Nome
                               select Escolas;
            escolasBindingSource.DataSource = listaEscolas.ToList();
        }

        private bool dadosPreenchidosEscolas()
        {
            if(tbNomeEscolas.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !");
                tbNomeEscolas.Focus();
                return false;
            }

            if(tbLocalidadeEscolas.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !");
                tbLocalidadeEscolas.Focus();
                return false;
            }

            if(tbTelefoneEscolas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !");
                tbTelefoneEscolas.Focus();
                return false;
            }

            return true;
        }

        //Botão para permitir que os dados relativos a uma escola sejam preenchidos
        private void btAdicionarEscola_Click(object sender, EventArgs e)
        {
            dgvEscolas.ClearSelection();
            btAdicionarEscola.Enabled = false;
            btGuardarEscola.Enabled = true;
            btCancelClean.Enabled = true;
            tbNomeEscolas.Enabled = true;
            tbMoradaEscolas.Enabled = true;
            tbCodPostalEscolas.Enabled = true;
            tbLocalidadeEscolas.Enabled = true;
            tbTelefoneEscolas.Enabled = true;
            tbMailEscolas.Enabled = true;
            dgvEscolas.Enabled = false;
        }

        //Botão que permite editar uma escola selecionada
        private void btEditarEscola_Click(object sender, EventArgs e)
        {
            btEditarEscola.Enabled = false;
            btGuardarEscola.Enabled = true;
            btCancelClean.Enabled = true;
            tbNomeEscolas.Enabled = true;
            tbMoradaEscolas.Enabled = true;
            tbCodPostalEscolas.Enabled = true;
            tbLocalidadeEscolas.Enabled = true;
            tbTelefoneEscolas.Enabled = true;
            tbMailEscolas.Enabled = true;
            dgvEscolas.Enabled = false;
        }

        /// <summary>
        /// Botão Guardar.
        /// Este botão permite que sejam guardados dados da escola, caso esteja alguma linha(escola) selecionada na
        /// na dgv o botão permite guardar dados da edição.
        /// Se não houver nenhuma selecção cria uma nova escola com os dados recolhidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGuardarEscola_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja guardar as alterações efectuadas ?",
                "Guardar", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
             
                try
                {
                    Escolas escola = (Escolas)dgvEscolas.SelectedRows[0].DataBoundItem;
                    if (dadosPreenchidosEscolas())
                    {
                        btAdicionarEscola.Enabled = false;
                        escola.Nome = tbNomeEscolas.Text;
                        escola.Morada = tbMoradaEscolas.Text;
                        escola.CodPostal = tbCodPostalEscolas.Text;
                        escola.Localidade = tbLocalidadeEscolas.Text;
                        escola.Telefone = tbTelefoneEscolas.Text;
                        escola.Mail = tbMailEscolas.Text;
                    }
                    BookidsContainer.SaveChanges();                   
                    carregarEscolas();
                    limparDados();
                }
                catch(ArgumentOutOfRangeException ex)
                {            
                
                    if (dadosPreenchidosEscolas())
                    {
                        Escolas nova = new Escolas()
                        {
                            Nome = tbNomeEscolas.Text,
                            Morada = tbMoradaEscolas.Text,
                            CodPostal = tbCodPostalEscolas.Text,
                            Localidade = tbLocalidadeEscolas.Text,
                            Telefone = tbTelefoneEscolas.Text,
                            Mail = tbMailEscolas.Text
                        };
                        BookidsContainer.EscolasSet.Add(nova);
                        BookidsContainer.SaveChanges();                       
                        carregarEscolas();
                        limparDados();
                    }
                }
            }                      
        }

        //Permite selecionar e carregar dados das escolas através da dgv
        private void dgvEscolas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Escolas escola = (Escolas)dgvEscolas.SelectedRows[0].DataBoundItem;
                if (escola != null)
                {
                    btAdicionarEscola.Enabled = false;
                    btEditarEscola.Enabled = true;
                    btApagarEscola.Enabled = true;
                    btCancelClean.Enabled = true;

                    tbNomeEscolas.Text = escola.Nome;
                    tbMoradaEscolas.Text = escola.Morada;
                    tbCodPostalEscolas.Text = escola.CodPostal;
                    tbLocalidadeEscolas.Text = escola.Localidade;
                    tbTelefoneEscolas.Text = escola.Telefone;
                    tbMailEscolas.Text = escola.Mail;
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {

            }
        }

        //método "refresh/reset"
        private void limparDados()
        {
            dgvEscolas.ClearSelection();
            tbNomeEscolas.Clear();
            tbMoradaEscolas.Clear();
            tbCodPostalEscolas.Clear();
            tbLocalidadeEscolas.Clear();
            tbTelefoneEscolas.Clear();
            tbMailEscolas.Clear();
            tbNomeEscolas.Enabled = false;
            tbMoradaEscolas.Enabled = false;
            tbCodPostalEscolas.Enabled = false;
            tbLocalidadeEscolas.Enabled = false;
            tbTelefoneEscolas.Enabled = false;
            tbMailEscolas.Enabled = false;
            btAdicionarEscola.Enabled = true;
            btGuardarEscola.Enabled = false;
            btEditarEscola.Enabled = false;
            btApagarEscola.Enabled = false;
            btCancelClean.Enabled = false;
            dgvEscolas.Enabled = true;
        }

        private void btCancelClean_Click(object sender, EventArgs e)
        {
            limparDados();
        }

        private void btApagarEscola_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem a certeza que deseja apagar esta escola ?",
                "Apagar", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                Escolas escola = (Escolas)dgvEscolas.SelectedRows[0].DataBoundItem;
                if (escola != null)
                {
                    BookidsContainer.EscolasSet.Remove(escola);
                    BookidsContainer.SaveChanges();
                    limparDados();
                    carregarEscolas();
                }
            }            
        }
    }
}
