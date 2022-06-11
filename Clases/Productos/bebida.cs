using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class bebida : Producto
    {
        bool conHielo;
        bool diet;
        bool alcoholica;

        public bool ConHielo
        {
            get => conHielo;
            set => conHielo = value;
        }
        public bool Diet
        {
            get => diet;
            set => diet = value;
        }
        public bool Alcoholica
        {
            get => alcoholica;
            set => alcoholica = value;
        }
    }
}
