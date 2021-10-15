using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UbuntoWar.Interfaces;

namespace UbuntoWar.Entities
{
    class Porta : Door
    {
        private string PortaA = "A";
        private string PortaB = "B";
        private string PortaC = "C";

        public string getPortaA()
        {
            return PortaA;
        }

        public string getPortaB()
        {
            return PortaB;
        }

        public string getPortaC()
        {
            return PortaC;
        }
        

    }
}
