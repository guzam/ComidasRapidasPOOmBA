using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases.Productos
{
    public class BDInterna
    {
        public List<Ingrediente> initListaIngredientes()
        {
            List<Ingrediente> listIngredientes = new List<Ingrediente>()
            {
            new Ingrediente(){IdIngrediente = 01, Nombre = "Hamburguesa de Carne", Tipo = "300gr", Cantidad = 200},
            new Ingrediente(){IdIngrediente = 02, Nombre = "Hamburguesa de Pollo", Tipo = "300gr", Cantidad = 100},
            new Ingrediente(){IdIngrediente = 03, Nombre = "Hamburguesa de Carne", Tipo = "150gr", Cantidad = 200},
            new Ingrediente(){IdIngrediente = 04, Nombre = "Hamburguesa de Pollo", Tipo = "150gr", Cantidad = 200},
            new Ingrediente(){IdIngrediente = 05, Nombre = "Pan de Campo", Tipo = "Trigo", Cantidad = 200},
            new Ingrediente(){IdIngrediente = 06, Nombre = "Pan de Hamburguesa", Tipo = "Con Sesamo", Cantidad = 200},
            new Ingrediente(){IdIngrediente = 07, Nombre = "Pan de Hamburguesa", Tipo = "Integral", Cantidad = 200},
            new Ingrediente(){IdIngrediente = 08, Nombre = "Lechuga", Tipo = "manteca", Cantidad = 200},
            new Ingrediente(){IdIngrediente = 09, Nombre = "Tomate", Tipo = "redondo", Cantidad = 200},
            new Ingrediente(){IdIngrediente = 10, Nombre = "Huevo", Tipo = "", Cantidad = 200},
            new Ingrediente(){IdIngrediente = 11, Nombre = "Queso", Tipo = "", Cantidad = 200}

            };

            return listIngredientes;
        }

    }

}
