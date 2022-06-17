using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    public class Candidato
    {
        private string cargo, partido, numero;
        private int qtdVotos;

        public Candidato(string cargo,string partido, string numero)
        {
            this.cargo = cargo;
            this.partido = partido;
            this.numero = numero;
            this.qtdVotos = 0; 
        }

        public string getCargo() { return cargo; }

        public string getPartido() { return partido; }

        public string getNum() { return numero; }

        public int getVotos() { return qtdVotos; }

        public void recebeVotos() { qtdVotos++; }

    }
}
