using System;
using System.Collections.Generic;
using System.Text;

namespace UbuntoWar.Interfaces
{
    interface IPlayer
    {
        void setNome(string nome);
        void setIdade(string idade);
        void setSexo(string sexo);
    }
}
