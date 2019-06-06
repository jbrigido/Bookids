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
    public partial class FormEventos : Form
    {
        private ModelBookidsContainer BookidsContainer;

        public FormEventos()
        {
            InitializeComponent();
            BookidsContainer = new ModelBookidsContainer();
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            carregarEventos();
            carregarComboAnimadores();
            carregarComboEscolas();
            carregarComboFilhos();
            tbNumeroEvento.Enabled = false;
            dtpDataEventos.MinDate = DateTime.Now;
            limparDadosEventos();
        }

        private void carregarEventos()
        {
            var listaEventos = from Eventos in BookidsContainer.EventosSet
                               orderby Eventos.NrEvento
                               select Eventos;
            eventosBindingSource.DataSource = listaEventos.ToList();
        }

        private void carregarComboAnimadores()
        {
            var listaAnimadores = from Animadores in BookidsContainer.AnimadoresSet
                                  orderby Animadores.Nome
                                  select Animadores;
            cbAnimadores.DataSource = listaAnimadores.ToList<Animadores>();
        }

        private void carregarComboEscolas()
        {
            var listaEscolas = from Escolas in BookidsContainer.EscolasSet
                               orderby Escolas.Nome
                               select Escolas;
            cbEscolas.DataSource = listaEscolas.ToList<Escolas>();
        }

        private void carregarComboFilhos()
        {
            var listaFilhos = from Filhos in BookidsContainer.FilhosSet
                              orderby Filhos.Nome
                              select Filhos;
            cbFilhos.DataSource = listaFilhos.ToList<Filhos>();
        }

        private bool dadosPreenchidosEventos()
        {
            if(tbDescricaoEvento.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !");
                tbDescricaoEvento.Focus();
                return false;
            }

            if(tbLocalEvento.Text == string.Empty)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !");
                tbLocalEvento.Focus();
                return false;
            }

            if (dtpDataEventos.Value == null)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !");
                return false;
            }

            if (nmLimiteParticipantes.Value == 0)
            {
                MessageBox.Show("(*) Campos de preenchimento obrigatório !");
                nmLimiteParticipantes.Focus();
                return false;
            }

            return true;
        }

        private void limparDadosEventos()
        {
            dgvEventos.ClearSelection();
            tbDescricaoEvento.Clear();
            tbNumeroEvento.Clear();
            nmLimiteParticipantes.ResetText();
            tbLocalEvento.Clear();
            dtpDataEventos.ResetText();
            tbHorasEvento.Clear();
            tbTipoEvento.Clear();
            nmIdadeMin.ResetText();
            nmIdadeMax.ResetText();
            tbDescricaoEvento.Enabled = false;
            nmLimiteParticipantes.Enabled = false;
            tbLocalEvento.Enabled = false;
            dtpDataEventos.Enabled = false;
            tbHorasEvento.Enabled = false;
            tbTipoEvento.Enabled = false;
            nmIdadeMin.Enabled = false;
            nmIdadeMax.Enabled = false;
            btCriarEvento.Enabled = true;
            btEditarEvento.Enabled = false;
            btGuardarEvento.Enabled = false;
            btApagarEvento.Enabled = false;
            btCancelClean.Enabled = false;
            cbAnimadores.Enabled = false;
            btAdicionarAnimador.Enabled = false;
            btRemoverAnimador.Enabled = false;
            cbEscolas.Enabled = false;
            btAdicionarEscola.Enabled = false;
            btRemoverEscola.Enabled = false;
            cbFilhos.Enabled = false;
            checkBoxFilhoConfirmado.Enabled = false;
            btAdicionarFilho.Enabled = false;
            btRemoverFilho.Enabled = false;
            dgvEventos.Enabled = true;
        }

        private void btCriarEvento_Click(object sender, EventArgs e)
        {
            dgvEventos.ClearSelection();
            btCriarEvento.Enabled = false;
            btGuardarEvento.Enabled = true;
            btCancelClean.Enabled = true;
            tbDescricaoEvento.Enabled = true;
            nmLimiteParticipantes.Enabled = true;
            tbLocalEvento.Enabled = true;
            dtpDataEventos.Enabled = true;
            tbHorasEvento.Enabled = true;
            tbTipoEvento.Enabled = true;
            nmIdadeMin.Enabled = true;
            nmIdadeMax.Enabled = true;
            dgvEventos.Enabled = false;
        }

        private void btEditarEvento_Click(object sender, EventArgs e)
        {
            btCriarEvento.Enabled = false;
            btGuardarEvento.Enabled = true;
            btApagarEvento.Enabled = true;
            btCancelClean.Enabled = true;
            tbDescricaoEvento.Enabled = true;
            nmLimiteParticipantes.Enabled = true;
            tbLocalEvento.Enabled = true;
            dtpDataEventos.Enabled = true;
            tbHorasEvento.Enabled = true;
            tbTipoEvento.Enabled = true;
            nmIdadeMin.Enabled = true;
            nmIdadeMax.Enabled = true;
            dgvEventos.Enabled = false;
        }

        private void btGuardarEvento_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja guardar as alterações efectuadas ?",
                "Guardar", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                try
                {
                    Eventos evento = (Eventos)dgvEventos.SelectedRows[0].DataBoundItem;
                    if (dadosPreenchidosEventos())
                    {
                        DateTime dtDataHora = getDataHora(dtpDataEventos.Value, tbHorasEvento.Text);

                        btCriarEvento.Enabled = false;
                        evento.Descricao = tbDescricaoEvento.Text;
                        evento.LimiteParticipacoes = (Int32)nmLimiteParticipantes.Value;
                        evento.Local = tbLocalEvento.Text;
                        evento.DataHora = dtDataHora;
                        evento.TipoEvento = tbTipoEvento.Text;
                        evento.IdadeInferior = (Int32)nmIdadeMin.Value;
                        evento.IdadeSuperior = (Int32)nmIdadeMax.Value;
                    }
                    BookidsContainer.SaveChanges();
                    carregarEventos();
                    limparDadosEventos();
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    if (dadosPreenchidosEventos())
                    {
                        DateTime dtDataHora = getDataHora(dtpDataEventos.Value, tbHorasEvento.Text);
                        Eventos novo = new Eventos()
                        {
                            Descricao = tbDescricaoEvento.Text,
                            LimiteParticipacoes = (Int32)nmLimiteParticipantes.Value,
                            Local = tbLocalEvento.Text,
                            DataHora = dtDataHora,
                            TipoEvento = tbTipoEvento.Text,
                            IdadeInferior = (Int32)nmIdadeMin.Value,
                            IdadeSuperior = (Int32)nmIdadeMax.Value
                        };
                        BookidsContainer.EventosSet.Add(novo);
                        BookidsContainer.SaveChanges();
                        carregarEventos();
                        limparDadosEventos();
                    }
                }
            }
        }

        private void dgvEventos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Eventos evento = (Eventos)dgvEventos.SelectedRows[0].DataBoundItem;
                if(evento != null)
                {
                    btCriarEvento.Enabled = false;
                    btEditarEvento.Enabled = true;
                    btApagarEvento.Enabled = true;
                    btCancelClean.Enabled = true;

                    tbDescricaoEvento.Text = evento.Descricao;
                    tbNumeroEvento.Text = Convert.ToString(evento.NrEvento);
                    nmLimiteParticipantes.Value = evento.LimiteParticipacoes;
                    tbLocalEvento.Text = evento.Local;
                    dtpDataEventos.Value = evento.DataHora;
                    tbHorasEvento.Text = getHora(evento.DataHora);
                    tbTipoEvento.Text = evento.TipoEvento;
                    nmIdadeMin.Value = (int)evento.IdadeInferior;
                    nmIdadeMax.Value = (int)evento.IdadeSuperior;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void btCancelClean_Click(object sender, EventArgs e)
        {
            limparDadosEventos();
        }

        private void btApagarEvento_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem a certeza que deseja apagar esta escola ?",
                "Apagar", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                Eventos evento = (Eventos)dgvEventos.SelectedRows[0].DataBoundItem;
                if(evento != null)
                {
                    BookidsContainer.EventosSet.Remove(evento);
                    BookidsContainer.SaveChanges();
                    limparDadosEventos();
                    carregarEventos();
                }
            }
        }

        private DateTime getDataHora(DateTime data, string hora)
        {
            int ihora = Convert.ToInt32(hora.Substring(0, 2));
            int imin = Convert.ToInt32(hora.Substring(5, 2));
            DateTime dt = new DateTime(data.Year, data.Month, data.Day, ihora, imin, 0);
            return dt;
        }

        private string getHora(DateTime data)
        {
            string hora = string.Format("{0:0#} : {1:0#}", data.Hour, data.Minute);
            return hora;
        }
    }
}
