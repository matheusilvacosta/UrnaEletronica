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
    public partial class FormDepFed : Form
    {
        private Urna urna;
        private Candidato candidato;

        private int controleConfirma, controleBranco;

        public FormDepFed()
        {
            InitializeComponent();
            controleConfirma = 0;
            controleBranco = 0;
        }

        private void FormDepFed_Load(object sender, EventArgs e)
        {
            urna = new Urna();

            FormZeresima z = new FormZeresima();
            z.ShowDialog();

            //MessageBox.Show(urna.mensagemZeresima());
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 5) textCandidato.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 5) textCandidato.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 5) textCandidato.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 5) textCandidato.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 5) textCandidato.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 5) textCandidato.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 5) textCandidato.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 5) textCandidato.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 5) textCandidato.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 5) textCandidato.Text += "0";
        }

        private void buttonCorrige_Click(object sender, EventArgs e)
        {
            controleConfirma = 0;
            controleBranco = 0;
            labelConfirmaVoto.Text = "";
            labelPartido.Text = "";
            textCandidato.Clear();
        }
        public void buttonConfirma_Click(object sender, EventArgs e)
        {
            if (textCandidato.Text != "" && (textCandidato.Text).Length == 5)
            {
                if (controleConfirma == 0)
                {
                    controleConfirma++;

                    candidato = urna.verificaCandidato(textCandidato.Text, "Deputado Federal");

                    if (candidato != null)
                    {
                        labelPartido.Text = candidato.getPartido();
                        labelConfirmaVoto.Text = "CONFIRMA?";
                    }
                    else
                    {
                        labelPartido.Text = "VOTO NULO";
                        labelConfirmaVoto.Text = "CONFIRMA?";
                    }

                }
                else
                {
                    if (candidato != null)
                    {
                        urna.confirmaCandidato(textCandidato.Text, "Deputado Federal");

                        this.Hide();
                        Form f = new FormDepEst(urna);
                        f.Closed += (s, args) => this.Close();
                        f.Show();
                    }
                    else
                    {
                        urna.votoNulo();

                        this.Hide();
                        Form f = new FormDepEst(urna);
                        f.Closed += (s, args) => this.Close();
                        f.Show();
                    }
                }
            }
            else if ((textCandidato.Text).Length < 5 && controleBranco == 0)
            {
                MessageBox.Show("Digitos Insuficientes, utilize 5 digitos para DEPUTADO FEDERAL");
            }
            else if (controleBranco == 1)
            {
                urna.votoBranco();

                this.Hide();
                Form f = new FormDepEst(urna);
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
        }
        private void buttonBranco_Click(object sender, EventArgs e)
        {
            if (controleBranco == 0)
            {
                controleBranco++;
                labelConfirmaVoto.Text = "VOTO BRANCO, CONFIRMA?";
                textCandidato.Text = "";
            }
        }
        public void labelPartido_Click(object sender, EventArgs e)
        {

        }
        private void labelPartidoDoisPontos_Click(object sender, EventArgs e)
        {

        }
    }
}
