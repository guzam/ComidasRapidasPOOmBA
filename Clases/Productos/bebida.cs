using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class bebida : Producto
    {
        string conHielo;
        string diet;
        string alcoholica;

        public string ConHielo
        {
            get => conHielo;
            set => conHielo = value;
        }
        public string Diet
        {
            get => diet;
            set => diet = value;
        }
        public string Alcoholica
        {
            get => alcoholica;
            set => alcoholica = value;
        }
    }
}
