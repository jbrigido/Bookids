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
            tbNomeEscolas.Enabled = false;
            tbMoradaEscolas.Enabled = false;
            tbCodPostalEscolas.Enabled = false;
            tbLocalidadeEscolas.Enabled = false;
            tbTelefoneEscolas.Enabled = false;
            tbMailEscolas.Enabled = false;
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
                return false;
            }

            if(tbLocalidadeEscolas.Text == string.Empty)
            {
                return false;
            }

            if(tbTelefoneEscolas.Text == string.Empty)
            {
                return false;
            }

            return true;
        }

        private void btAdicionarEscola_Click(object sender, EventArgs e)
        {
            dgvEscolas.ClearSelection();
            tbNomeEscolas.Enabled = true;
            tbMoradaEscolas.Enabled = true;
            tbCodPostalEscolas.Enabled = true;
            tbLocalidadeEscolas.Enabled = true;
            tbTelefoneEscolas.Enabled = true;
            tbMailEscolas.Enabled = true;

        }

        private void btEditarEscola_Click(object sender, EventArgs e)
        {
            tbNomeEscolas.Enabled = true;
            tbMoradaEscolas.Enabled = true;
            tbCodPostalEscolas.Enabled = true;
            tbLocalidadeEscolas.Enabled = true;
            tbTelefoneEscolas.Enabled = true;
            tbMailEscolas.Enabled = true;
        }

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
                        escola.Nome = tbNomeEscolas.Text;
                        escola.Morada = tbMoradaEscolas.Text;
                        escola.CodPostal = tbCodPostalEscolas.Text;
                        escola.Localidade = tbLocalidadeEscolas.Text;
                        escola.Telefone = tbTelefoneEscolas.Text;
                        escola.Mail = tbMailEscolas.Text;
                    }
                    BookidsContainer.SaveChanges();
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
                    }
                }
                            
            }
        }
    }
}
