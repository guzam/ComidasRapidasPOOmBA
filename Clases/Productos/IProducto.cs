using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases.Productos
{
    interface IProducto
    {
        public void agrandarTamanio(Producto producto, int codTamanio);
        public void agregarStock(int codProducto, int cantidad);
        public void descontarStock(int codProducto, int cantidad);
    }
}
