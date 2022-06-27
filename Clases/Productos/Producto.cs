using ComidasRapidasPOOmBA.Clases.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Producto : IProducto
    {
        int codigo;
        string nombre;
        int stock;
        double precio;
        string tipo;
        int codTamanio;
        string tamanio;

        public int Codigo { 
            get => codigo; 
            set => codigo = value; 
        }
        public string Nombre { 
            get => nombre; 
            set => nombre = value; 
        }
        public int Stock
        {
            get => stock;
            set => stock = value;
        }
        public double Precio {
            get => precio;
            set => precio = value;
        }
        public string Tipo {
            get => tipo;
            set => tipo = value;
        }
        public int CodTamanio
        {
            get => codTamanio;
            set => codTamanio = value;
        }
        public string Tamanio {
            get => tamanio;
            set => tamanio = value;
        }

        public void agrandarTamanio(Producto producto, int codTamanio)
        {
            throw new NotImplementedException();
        }

        public void agregarStock(int codProducto, int cantidad)
        {
            throw new NotImplementedException();
        }

        public void descontarStock(int codProducto, int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
