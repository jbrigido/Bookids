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
    public partial class FormAnimadores : Form
    {
        private ModelBookidsContainer BookidsContainer;

        public FormAnimadores()
        {
            InitializeComponent();
            BookidsContainer = new ModelBookidsContainer();
        }

        private void FormAnimadores_Load(object sender, EventArgs e)
        {
            carregarAnimadores();
            limparDados();
        }

        private void carregarAnimadores()
        {
            var listaAnimadores = from Animadores in BookidsContainer.AnimadoresSet
                                  orderby Animadores.Nome
                                  select Animadores;
            animadoresBindingSource.DataSource = listaAnimadores.ToList();
        }

        private bool dadosPreenchidosAnimadores()
        {
            if(tbNomeAnimadores.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                tbNomeAnimadores.Focus();
                return false;
            }

            if(tbMoradaAnimadores.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                tbMoradaAnimadores.Focus();
                return false;
            }

            if(tbCodPostalAnimadores.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                tbCodPostalAnimadores.Focus();
                return false;
            }

            if(tbLocalidadeAnimadores.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                tbLocalidadeAnimadores.Focus();
                return false;
            }

            if(tbTelefoneAnimadores.Text.Trim() == string.Empty && tbTelemovelAnimadores.Text.Trim() == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !\n(**) Preencher um dos campos !");
                tbTelefoneAnimadores.Focus();
                return false;
            }

            return true;
        }

        private void btAdicionarAnimadores_Click(object sender, EventArgs e)
        {
            dgvAnimadores.ClearSelection();
            btAdicionarAnimadores.Enabled = false;
            btGuardarAnimadores.Enabled = true;
            btCancelClean.Enabled = true;
            tbNomeAnimadores.Enabled = true;
            tbMoradaAnimadores.Enabled = true;
            tbCodPostalAnimadores.Enabled = true;
            tbLocalidadeAnimadores.Enabled = true;
            tbTelefoneAnimadores.Enabled = true;
            tbTelemovelAnimadores.Enabled = true;
            tbMailAnimadores.Enabled = true;
            tbEspecialidadeAnimadores.Enabled = true;
        }

        private void btEditarAnimadores_Click(object sender, EventArgs e)
        {
            btEditarAnimadores.Enabled = false;
            btGuardarAnimadores.Enabled = true;
            btCancelClean.Enabled = true;
            tbNomeAnimadores.Enabled = true;
            tbMoradaAnimadores.Enabled = true;
            tbCodPostalAnimadores.Enabled = true;
            tbLocalidadeAnimadores.Enabled = true;
            tbTelefoneAnimadores.Enabled = true;
            tbTelemovelAnimadores.Enabled = true;
            tbMailAnimadores.Enabled = true;
            tbEspecialidadeAnimadores.Enabled = true;
        }

        private void btGuardarAnimadores_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja guardar as alterações efectuadas ?",
                "Guardar", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                try
                {
                    Animadores animador = (Animadores)dgvAnimadores.SelectedRows[0].DataBoundItem;
                    if (dadosPreenchidosAnimadores())
                    {
                        btAdicionarAnimadores.Enabled = false;
                        animador.Nome = tbNomeAnimadores.Text;
                        animador.Morada = tbMoradaAnimadores.Text;
                        animador.CodPostal = tbCodPostalAnimadores.Text;
                        animador.Localidade = tbLocalidadeAnimadores.Text;
                        animador.Telefone = tbTelefoneAnimadores.Text;
                        animador.Telemovel = tbTelemovelAnimadores.Text;
                        animador.Mail = tbMailAnimadores.Text;
                        animador.Especialidade = tbEspecialidadeAnimadores.Text;
                    }
                    BookidsContainer.SaveChanges();                   
                    carregarAnimadores();
                    limparDados();
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    if (dadosPreenchidosAnimadores())
                    {
                        Animadores novo = new Animadores()
                        {
                            Nome = tbNomeAnimadores.Text,
                            Morada = tbMoradaAnimadores.Text,
                            CodPostal = tbCodPostalAnimadores.Text,
                            Localidade = tbLocalidadeAnimadores.Text,
                            Telefone = tbTelefoneAnimadores.Text,
                            Telemovel = tbTelemovelAnimadores.Text,
                            Mail = tbMailAnimadores.Text,
                            Especialidade = tbEspecialidadeAnimadores.Text
                        };
                        BookidsContainer.AnimadoresSet.Add(novo);
                        BookidsContainer.SaveChanges();                       
                        carregarAnimadores();
                        limparDados();
                    }
                }
            }
        }

        private void dgvAnimadores_Click(object sender, EventArgs e)
        {
            try
            {
                Animadores animador = (Animadores)dgvAnimadores.SelectedRows[0].DataBoundItem;
                if(animador != null)
                {
                    btAdicionarAnimadores.Enabled = false;
                    btEditarAnimadores.Enabled = true;
                    btApagarAnimadores.Enabled = true;
                    btCancelClean.Enabled = true;

                    tbNomeAnimadores.Text = animador.Nome;
                    tbMoradaAnimadores.Text = animador.Morada;
                    tbCodPostalAnimadores.Text = animador.CodPostal;
                    tbLocalidadeAnimadores.Text = animador.Localidade;
                    tbTelefoneAnimadores.Text = animador.Telefone;
                    tbTelemovelAnimadores.Text = animador.Telemovel;
                    tbMailAnimadores.Text = animador.Mail;
                    tbEspecialidadeAnimadores.Text = animador.Especialidade;
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {

            }
        }

        private void limparDados()
        {
            dgvAnimadores.ClearSelection();
            tbNomeAnimadores.Clear();
            tbMoradaAnimadores.Clear();
            tbCodPostalAnimadores.Clear();
            tbLocalidadeAnimadores.Clear();
            tbTelefoneAnimadores.Clear();
            tbTelemovelAnimadores.Clear();
            tbMailAnimadores.Clear();
            tbEspecialidadeAnimadores.Clear();
            tbNomeAnimadores.Enabled = false;
            tbMoradaAnimadores.Enabled = false;
            tbCodPostalAnimadores.Enabled = false;
            tbLocalidadeAnimadores.Enabled = false;
            tbTelefoneAnimadores.Enabled = false;
            tbTelemovelAnimadores.Enabled = false;
            tbMailAnimadores.Enabled = false;
            tbEspecialidadeAnimadores.Enabled = false;
            btAdicionarAnimadores.Enabled = true;
            btGuardarAnimadores.Enabled = false;
            btEditarAnimadores.Enabled = false;
            btApagarAnimadores.Enabled = false;
            btCancelClean.Enabled = false;
        }

        private void btApagarAnimadores_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem a certeza que deseja apagar este animador ?",
                "Apagar", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                Animadores animador = (Animadores)dgvAnimadores.SelectedRows[0].DataBoundItem;
                if(animador != null)
                {
                    BookidsContainer.AnimadoresSet.Remove(animador);
                    BookidsContainer.SaveChanges();
                    limparDados();
                    carregarAnimadores();
                }
            }
        }

        private void btCancelClean_Click(object sender, EventArgs e)
        {
            limparDados();
        }
    }
}
