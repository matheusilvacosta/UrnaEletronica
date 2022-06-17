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
    public partial class FormDepEst : Form
    {
        private Urna urna;
        private Candidato candidato;

        private int controleConfirma, controleBranco;
        public FormDepEst(Urna urna)
        {
            InitializeComponent();
            this.urna = urna;

            controleConfirma = 0;
            controleBranco = 0;
        }
        private void FormDepEst_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 4) textCandidato.Text += "1";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 4) textCandidato.Text += "2";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 4) textCandidato.Text += "3";
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 4) textCandidato.Text += "4";
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 4) textCandidato.Text += "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 4) textCandidato.Text += "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 4) textCandidato.Text += "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 4) textCandidato.Text += "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 4) textCandidato.Text += "9";
        }

        private void button0_Click_1(object sender, EventArgs e)
        {
            if ((textCandidato.Text).Length < 4) textCandidato.Text += "0";
        }

        private void buttonBranco_Click_1(object sender, EventArgs e)
        {
            if (controleBranco == 0)
            {
                controleBranco++;
                labelConfirmaVoto.Text = "VOTO BRANCO, CONFIRMA?";
                textCandidato.Text = "";
            }
        }
        private void buttonCorrige_Click_1(object sender, EventArgs e)
        {
            controleConfirma = 0;
            controleBranco = 0;
            labelConfirmaVoto.Text = "";
            labelPartido.Text = "";
            textCandidato.Clear();
        }
        private void buttonConfirma_Click_1(object sender, EventArgs e)
        {
            if (textCandidato.Text != "" && (textCandidato.Text).Length == 4)
            {
                if (controleConfirma == 0)
                {
                    controleConfirma++;

                    candidato = urna.verificaCandidato(textCandidato.Text, "Deputado Estadual");

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
                        urna.confirmaCandidato(textCandidato.Text, "Deputado Estadual");

                        this.Hide();
                        Form f = new FormSenador(urna);
                        f.Closed += (s, args) => this.Close();
                        f.Show();
                    }
                    else
                    {
                        urna.votoNulo();

                        this.Hide();
                        Form f = new FormSenador(urna);
                        f.Closed += (s, args) => this.Close();
                        f.Show();
                    }
                }
            }
            else if ((textCandidato.Text).Length < 4 && controleBranco == 0)
            {
                MessageBox.Show("Digitos Insuficientes, utilize 4 digitos para DEPUTADO ESTADUAL");
            }
            else if (controleBranco == 1)
            {
                urna.votoBranco();

                this.Hide();
                Form f = new FormSenador(urna);
                f.Closed += (s, args) => this.Close();
                f.Show();
            }

        }
    }
}
