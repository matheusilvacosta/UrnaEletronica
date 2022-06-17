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
    public partial class FormZeresima : Form
    {
        private Urna urna = new Urna();

        public FormZeresima()
        {
            InitializeComponent();
        }

        private void FormZeresima_Load(object sender, EventArgs e)
        {
            labelCandidatos.Text = urna.mensagemZeresima();
        }

        private void labelCandidatos_Click(object sender, EventArgs e)
        {

        } 
    }
}
