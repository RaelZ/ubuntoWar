using System;
using System.Collections.Generic;
using System.Text;
using UbuntoWar.Interfaces;

namespace UbuntoWar.Entities
{
    class Jogador : IPlayer
    {
        private string Nome { get; set; }
        private int Idade { get; set; }
        private string Sexo { get; set; }

        public void setIdade(int idade)
        {
            Idade = idade;
        }

        public int getIdade()
        {
            return Idade;
        }

        public void setNome(string nome)
        {
            if (nome == string.Empty)
            {
                Nome = "Jogador Anônimo";
            } else
            {
                Nome = nome;
            }
        }
        public string getNome()
        {
            return Nome;
        }

        public void setSexo(string sexo)
        {
            Sexo = sexo;
        }
        public string getSexo()
        {
            return Sexo;
        }
    }
}
