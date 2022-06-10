using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Detalle
    {
        DateTime fecha;
        int cantidad;
        Producto item;

        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
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

        public void cantidadXProducto()
        {

        }
    }
}
