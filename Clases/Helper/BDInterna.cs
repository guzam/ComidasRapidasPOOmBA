using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases.Productos
{
    public class BDInterna
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        public BDInterna()
        {          
            listaUsuarios.Add(new Usuario("Lucas M P", "luc012", "33.123.456","admin", "lucas@gmail.com", 41, "1234"));
            listaUsuarios.Add(new Usuario("Gustavo Z", "guszam", "34.456.456", "admin", "gustavo@gmail.com", 32, "1234"));
            listaUsuarios.Add(new Usuario("Monica N", "moni01", "40.123.345", "admin", "monica@gmail.com", 38, "1234"));
            listaUsuarios.Add(new Usuario("Fede B", "fede33", "39.888.789", "admin", "fede@gmail.com", 41, "1234"));
            listaUsuarios.Add(new Usuario("Nene", "nene10", "48.000.000", "admin", "nene@gmail.com", 11, "1234"));
        }
        
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
        public List<Usuario> getUsuarios()
        {          
            return listaUsuarios;                     
        }
        public int agregarUsuarios(Usuario usu)
        {
            listaUsuarios.Add(usu);

            return 1;
        }
        public List<Producto> initListaProductos()
        {
            List<Producto> listProductos = new List<Producto>()
            {
            new Producto(){Codigo = 01, Nombre = "Hamburguesa de Carne", Stock = 100, CodTamanio = 01, Tamanio = "chico", Precio = 500, Tipo = "300gr"},
            new Producto(){Codigo = 01, Nombre = "Hamburguesa de Carne", Stock = 100, CodTamanio = 01, Tamanio = "chico", Precio = 500, Tipo = "300gr"}
            };

            return listProductos;
        }

        }
    }

