using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Detalle
    {
        public int cantidad;
        Producto item;
        double subtotal;
        public override string ToString()
        {
            return "Item: "+ item + "Cantidad: "+cantidad;

        }

        public Detalle(int cant, Producto item)
        {
            Cantidad = cant;
            Item = item;
            Subtotal = subtotalPorProducto(cant, item);
        }
        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
        public Producto Item
        {
            get => item;
            set => item = value;
        }

        public double Subtotal
        {
            get => subtotal;
            set => subtotal = value;
        }
        public double subtotalPorProducto(int cantidad, Producto item)
        {
           return item.Precio * cantidad;
        }
    }
}
