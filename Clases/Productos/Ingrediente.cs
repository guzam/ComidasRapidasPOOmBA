using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Ingrediente
    {
        int idIngrediente;
        string nombre;
        string tipo;
        int cantidad;

        public int IdIngrediente
        {
            get => idIngrediente;
            set => idIngrediente = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
    }
}
