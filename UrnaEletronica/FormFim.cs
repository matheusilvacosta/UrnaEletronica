using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class FormFim : Form
    {
        private Urna urna;
        public FormFim(Urna urna)
        {
            InitializeComponent();
            this.urna = urna;
        }

        private void buttonConfirma_Click(object sender, EventArgs e)
        {
            MessageBox.Show(urna.mensagemBoletim());
        }

        private void buttonCorrige_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormFim_Load(object sender, EventArgs e)
        {

        }
    }
}
