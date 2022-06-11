using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Ingrediente
    {
        string nombre;
        int cantidad;
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
    }
}
