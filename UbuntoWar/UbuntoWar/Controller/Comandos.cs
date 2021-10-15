using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UbuntoWar.Controller
{
    class Comandos
    {
        private string Resposta { get; set; }
        public void setInicio(string resposta)
        {
            Resposta = resposta;
        }
        public string getInicio()
        {
            return Resposta;
        }
        public int[] sortPorta()
        {
            int[] portaAleatoria = new int[3];
            portaAleatoria[2] = 1;
            Random aleatorio = new Random();
            for (int i = 0; i < portaAleatoria.Length - 1; i++)
            {
                int temp = aleatorio.Next(1, 900);
                portaAleatoria[i] = temp;
                for (int n = 0; n < portaAleatoria.Length - 1; n++)
                {
                    if (portaAleatoria[i] == portaAleatoria[n])
                    {
                        int tempinho = aleatorio.Next(1, 900);
                        portaAleatoria[n] = tempinho;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            portaAleatoria = portaAleatoria.OrderBy(x => aleatorio.Next()).ToArray();
            return portaAleatoria;
        }
        public void setReiniciar(string resposta)
        {
            Resposta = resposta;
        }
    }
}
