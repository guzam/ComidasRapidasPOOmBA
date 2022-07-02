using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Pedido
    {
        int idPedido;
        List<Detalle> listaDetalle;
        double totalAPagar;

        public Pedido() { }
        public Pedido(int id)
        {
            IdPedido = id;
        }
        public Pedido(int id, List<Detalle> lista)
        {
            IdPedido = id;
            ListaDetalle = lista;
        }


        public int IdPedido { get => idPedido; set => idPedido = value; }
        public List<Detalle> ListaDetalle { get => listaDetalle; set => listaDetalle = value; }
        public double TotalAPagar { get => totalAPagar; set => totalAPagar = value; }


        public void ingresarAPedido(Detalle item)
        {
            ListaDetalle.Add(item);
        }

        public void confirmarPedido()
        {

        }

        public void pagarPedido()
        {

        }

        public double sumaTotal(Pedido pedido)
        {
            var aux = 0d;

            foreach (var item in pedido.listaDetalle)
            {
                aux += item.Subtotal;
            }
            return aux;
        }

    }
}
