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

            if (dtpDataHoraEventos.Value == null)
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
            nmLimiteParticipantes.ResetText();
            tbLocalEvento.Clear();
            dtpDataHoraEventos.ResetText();
            tbTipoEvento.Clear();
            nmIdadeMin.ResetText();
            nmIdadeMax.ResetText();
            tbDescricaoEvento.Enabled = false;
            nmLimiteParticipantes.Enabled = false;
            tbLocalEvento.Enabled = false;
            dtpDataHoraEventos.Enabled = false;
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
            dtpDataHoraEventos.Enabled = true;
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
            dtpDataHoraEventos.Enabled = true;
            tbTipoEvento.Enabled = true;
            nmIdadeMin.Enabled = true;
            nmIdadeMax.Enabled = true;
            dgvEventos.Enabled = false;
        }
    }
}
