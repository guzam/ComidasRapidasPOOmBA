using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Impresora
    {
        public Impresora(Ticket ticket, Pedido pedido)
        {
            var pathArchivo = "..\\Tickets\\";
            var nomArchivo = pathArchivo + "Ticket_" + ticket.IdTicket + ".txt";
            var archivo = new System.IO.StreamWriter(nomArchivo);

            archivo.WriteLine(ticket.NombreFantasia);
            archivo.WriteLine(ticket.RazonSocial);
            archivo.WriteLine("CUIT Nro. " + ticket.Cuit);
            archivo.WriteLine(ticket.Direccion);
            archivo.WriteLine(ticket.Cp);
            archivo.WriteLine("I.B. " + ticket.IngresosBrutos + " - INI. ACT. " + ticket.InicioActividad);
            archivo.WriteLine(ticket.AfipLocal);
            archivo.WriteLine("A " + ticket.NombreUsuario + "IVA " + ticket.AfipUsuario);
            archivo.WriteLine("Nro. Ticket " + ticket.IdTicket);
            archivo.WriteLine("Fecha " + ticket.Fecha);
            archivo.WriteLine();

            archivo.WriteLine("Nro. Pedido " + pedido.IdPedido);
            
            archivo.WriteLine();

            
            foreach (var detalle in pedido.ListaDetalle)
            {
                archivo.WriteLine(detalle.Cantidad + " x " + detalle.Item.Precio);
                archivo.WriteLine(detalle.Item.Nombre + "       " + detalle.Subtotal);
            }
            archivo.WriteLine();
            
            archivo.WriteLine("TOTAL " + pedido.TotalAPagar);

            

        }
    }
}
