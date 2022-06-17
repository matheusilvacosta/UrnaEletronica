using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    public class Urna
    {
        List<Candidato> candidatosCadastrados = new List<Candidato>();
        List<string> candidatosVotados = new List<string>();

        private int qtdVotoBranco, qtdVotoNulo;

        public Urna()
        {
            //===============DEPUTADO FEDERAL============================
            candidatosCadastrados.Add(new Candidato("Deputado Federal", "PT", "13000"));
            candidatosCadastrados.Add(new Candidato("Deputado Federal", "MDB", "15000"));
            candidatosCadastrados.Add(new Candidato("Deputado Federal", "PSDB", "45000"));
            candidatosCadastrados.Add(new Candidato("Deputado Federal", "PDT", "12000"));
            candidatosCadastrados.Add(new Candidato("Deputado Federal", "PCdoB", "65000"));
            candidatosCadastrados.Add(new Candidato("Deputado Federal", "PSOL", "50000"));

            //===============DEPUTADO ESTADUAL============================
            candidatosCadastrados.Add(new Candidato("Deputado Estadual", "PT", "1300"));
            candidatosCadastrados.Add(new Candidato("Deputado Estadual", "MDB", "1500"));
            candidatosCadastrados.Add(new Candidato("Deputado Estadual", "PSDB", "4500"));
            candidatosCadastrados.Add(new Candidato("Deputado Estadual", "PDT", "1200"));
            candidatosCadastrados.Add(new Candidato("Deputado Estadual", "PCdoB", "6500"));
            candidatosCadastrados.Add(new Candidato("Deputado Estadual", "PSOL", "5000"));

            //===============SENADORES====================================
            candidatosCadastrados.Add(new Candidato("Senador", "PT", "130"));
            candidatosCadastrados.Add(new Candidato("Senador", "MDB", "150"));
            candidatosCadastrados.Add(new Candidato("Senador", "PSDB", "450"));
            candidatosCadastrados.Add(new Candidato("Senador", "PDT", "120"));
            candidatosCadastrados.Add(new Candidato("Senador", "PCdoB", "650"));
            candidatosCadastrados.Add(new Candidato("Senador", "PSOL", "500"));

            //===============GOVERNADORES=================================
            candidatosCadastrados.Add(new Candidato("Governador", "PT", "13"));
            candidatosCadastrados.Add(new Candidato("Governador", "MDB", "15"));
            candidatosCadastrados.Add(new Candidato("Governador", "PSDB", "45"));
            candidatosCadastrados.Add(new Candidato("Governador", "PDT", "12"));
            candidatosCadastrados.Add(new Candidato("Governador", "PCdoB", "65"));
            candidatosCadastrados.Add(new Candidato("Governador", "PSOL", "50"));

            //===============PRESIDENTES==================================
            candidatosCadastrados.Add(new Candidato("Presidente", "PT", "13"));
            candidatosCadastrados.Add(new Candidato("Presidente", "MDB", "15"));
            candidatosCadastrados.Add(new Candidato("Presidente", "PSDB", "45"));
            candidatosCadastrados.Add(new Candidato("Presidente", "PDT", "12"));
            candidatosCadastrados.Add(new Candidato("Presidente", "PCdoB", "65"));
            candidatosCadastrados.Add(new Candidato("Presidente", "PSOL", "50"));

        }
        public Candidato verificaCandidato(string numCandidato, string cargo)
        {
            foreach (Candidato candidato in candidatosCadastrados)
            {
                if (numCandidato != null)
                {
                    if (candidato.getCargo().Equals(cargo))
                    {
                        if (candidato.getNum().Equals(numCandidato))
                        {
                            return candidato;
                        }
                    }
                } 
            } return null; 
        }
        public void confirmaCandidato(string numCandidato, string cargo)
        {
            foreach (Candidato candidato in candidatosCadastrados)
            {
                if (numCandidato != null)
                {
                    if (candidato.getCargo().Equals(cargo))
                    {
                        if (candidato.getNum().Equals(numCandidato))
                        {
                            candidato.recebeVotos();
                        }
                    }
                }
            }
        }
        public void votoBranco()
        {
            qtdVotoBranco++;
        }
        public int getBranco()
        {
            return qtdVotoBranco;
        }
        public void votoNulo()
        {
            qtdVotoNulo++;
        }
        public int getNulo()
        {
            return qtdVotoNulo;
        }
        public string mensagemZeresima()
        {
            string zeresima = "**************************************************\n";

            foreach (Candidato candidato in candidatosCadastrados)
            {
                zeresima += "Cargo: " + candidato.getCargo() + "\nPartido: " + candidato.getPartido() +"\nNúmero: " + candidato.getNum() + "\nQuantidade de Votos: " + candidato.getVotos() + "\n **************************************************\n" ;                
            }
            return zeresima;
        }
        public string mensagemBoletim()
        {
            string boletim = "********************BOLETIM********************\n";

            foreach (Candidato candidato in candidatosCadastrados)
            {
                if (candidato.getVotos() == 1) boletim += "Cargo: " + candidato.getCargo()+ "\nPartido: " + candidato.getPartido() + "\nNúmero: " + candidato.getNum() + "\nQuantidade de Votos: " + candidato.getVotos() + "\n ************************************************\n";               
            }
            boletim += "Votos Brancos: " + getBranco() + "\n ************************************************";
            boletim += "\nVotos Nulos: " + getNulo() + "\n ************************************************";

            return boletim;
        }

    }
}
