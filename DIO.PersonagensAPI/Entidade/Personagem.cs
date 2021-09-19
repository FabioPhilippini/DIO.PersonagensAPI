using DIO.PersonagensAPI.Enum;
using System;

namespace DIO.PersonagensAPI.Entidade
{
    public class Personagem : PersonagemBase
    {
        private Classe Classe { get; set; }
        private string NomeJogador { get; set; }

        private string NomePersonagem { get; set; }

        private string Raca { get; set; }

        private int Forca { get; set; }

        private int Destreza { get; set; }

        private int Vitalidade { get; set; }

        private int Energia { get; set; }

        private bool Removido { get; set; }

        public Personagem()
        {

        }

        public Personagem(int id, Classe classe, string nomeJogador, string nomePersonagem, string raca, int forca, int destreza, int vitalidade, int energia)
        {
            this.Id = id;
            this.Classe = classe;
            this.NomeJogador = nomeJogador;
            this.NomePersonagem = nomePersonagem;
            this.Raca = raca;
            this.Forca = forca;
            this.Destreza = destreza;
            this.Vitalidade = vitalidade;
            this.Energia = energia;
            this.Removido = false;
        }

        public Classe RetornaClasse()
        {
            return this.Classe;
        }

        public int RetornaVitalidade()
        {
            return this.Vitalidade;
        }

        public int RetornaEnergia()
        {
            return this.Energia;
        }

        public int RetornaDestreza()
        {
            return this.Destreza;
        }

        public int RetornaForca()
        {
            return this.Forca;
        }

        public string RetornaRaca()
        {
            return this.Raca;
        }

        public String RetornaNomeJogador()
        {
            return this.NomeJogador;
        }

        public String RetornaNomePersonagem()
        {
            return this.NomePersonagem;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public void Remover()
        {
            this.Removido = true;
        }

        public bool RetornaRemovido()
        {
            return this.Removido;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Classe: " + this.Classe + Environment.NewLine;
            retorno += "Nome do Jogador: " + this.NomeJogador + Environment.NewLine;
            retorno += "Nome do personagem: " + this.NomePersonagem + Environment.NewLine;
            retorno += "Raça: " + this.Raca + Environment.NewLine;
            retorno += "Força: " + this.Forca + Environment.NewLine;
            retorno += "Destreza: " + this.Destreza + Environment.NewLine;
            retorno += "Vitalidade: " + this.Vitalidade + Environment.NewLine;
            retorno += "Energia: " + this.Energia + Environment.NewLine;
            retorno += "Morto: " + this.Removido;
            return retorno;
        }
    }
}
