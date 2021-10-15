using System;
using System.Collections.Generic;
using System.Text;
using UbuntoWar.Interfaces;

namespace UbuntoWar.Entities
{
    class Jogador : IPlayer
    {
        private string Nome { get; set; }
        private string Idade { get; set; }
        private string Sexo { get; set; }
        private string Porta1 { get; set; }
        private string Porta2 { get; set; }
        private string Porta3 { get; set; }
        private string Porta4 { get; set; }
        private string Porta5 { get; set; }
        private string Vencedor { get; set; }

        public void setIdade(string idade)
        {
            Idade = idade;
        }

        public string getIdade()
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

        public void setPorta1(string porta)
        {
            Porta1 = porta;
        }
        public void setPorta2(string porta)
        {
            Porta2 = porta;
        }
        public void setPorta3(string porta)
        {
            Porta3 = porta;
        }
        public void setPorta4(string porta)
        {
            Porta4 = porta;
        }
        public void setPorta5(string porta)
        {
            Porta5 = porta;
        }

        public string getPorta1()
        {
            return Porta1;
        }
        public string getPorta2()
        {
            return Porta2;
        }
        public string getPorta3()
        {
            return Porta3;
        }
        public string getPorta4()
        {
            return Porta4;
        }
        public string getPorta5()
        {
            return Porta5;
        }

        public void setVencedor(string vencedor)
        {
            Vencedor = vencedor;
        }
        public string getVencedor()
        {
            return Vencedor;
        }
    }
}
