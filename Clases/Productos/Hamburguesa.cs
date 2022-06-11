using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Hamburguesa : Comida
    {
        int cantHamburguesas;

        public int CantHamburguesas
        {
            get => cantHamburguesas;
            set => cantHamburguesas = value;
        }
    }
}
