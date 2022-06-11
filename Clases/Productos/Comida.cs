using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Comida : Producto
    {
        string aderezo;
        public string Aderezo
        {
            get => aderezo;
            set => aderezo = value;
        }
    }
}
