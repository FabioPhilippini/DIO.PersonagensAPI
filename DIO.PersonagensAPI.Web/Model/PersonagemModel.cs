using DIO.PersonagensAPI.Entidade;
using DIO.PersonagensAPI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.PersonagensAPI.Web.Model
{
    public class PersonagemModel
    {
        public int Id { get; set; }
        public Classe Classe { get; set; }
        public string NomeJogador { get; set; }
        public string NomePersonagem { get; set; }
        public string Raca { get; set; }
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Vitalidade { get; set; }
        public int Energia { get; set; }
        public bool Removido { get; set; }

        public PersonagemModel()
        {
        }

        public PersonagemModel(Personagem personagem)
        {
            Id = personagem.RetornaId();
            Classe = personagem.RetornaClasse();
            NomeJogador = personagem.RetornaNomeJogador();
            NomePersonagem = personagem.RetornaNomePersonagem();
            Raca = personagem.RetornaRaca();
            Forca = personagem.RetornaForca();
            Destreza = personagem.RetornaDestreza();
            Vitalidade = personagem.RetornaVitalidade();
            Energia = personagem.RetornaEnergia();
            Removido = personagem.RetornaRemovido();

        }

        public Personagem ToPersonagem()
        {
            return new Personagem(Id, Classe, NomeJogador, NomePersonagem, Raca, Forca, Destreza, Vitalidade, Energia);
        }
            
        
    }
}
