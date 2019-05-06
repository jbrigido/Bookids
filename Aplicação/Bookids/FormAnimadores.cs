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
        public FormAnimadores()
        {
            InitializeComponent();
        }

        private void FormAnimadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookidsDBDataSet.PessoasSet_Animadores' table. You can move, or remove it, as needed.
            this.pessoasSet_AnimadoresTableAdapter.Fill(this.bookidsDBDataSet.PessoasSet_Animadores);

        }
    }
}
