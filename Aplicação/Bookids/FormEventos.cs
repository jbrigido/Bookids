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
    }
}
