using ComidasRapidasPOOmBA.Clases.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Pago
    {
        int idPago;
        DateTime fechaCreacionPago;
        DateTime fechaPago;
        float montoTotal;
        bool pagado;

        public Pago()
        {
            //IdPago++;
            FechaCreacionPago = DateTime.Now;
            Pagado = false;
        }

        public Pago(float monto)
        {
            //IdPago++;
            MontoTotal = monto;
            FechaCreacionPago = DateTime.Now;
            Pagado = false;
        }

        public int IdPago { get => idPago; set => idPago = value; }
        public DateTime FechaCreacionPago { get => fechaCreacionPago; set => fechaCreacionPago = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public float MontoTotal { get => montoTotal; set => montoTotal = value; }
        public bool Pagado { get => pagado; set => pagado = value; }

        public void nuevoPago()
        {
            idPago++;
        }

        public void validarPago()
        {

        }

        public bool realizarPago(float monto, Pedido pedido)
        {
            nuevoPago();
            TarjetaCredito tc = new TarjetaCredito();

            if (tc.realizarPagoTarjeta(monto))
            {
                MessageBox.Show("El pago se realizó correctamente con la Tarjeta. \n");
                fechaPago = DateTime.Now;
                pagado = true;
                //Impresora imp = new Impresora(new Ticket(),pedido);
                Impresora imp = new Impresora();
                imp.imprimir(new Ticket(), pedido);

                return pagado;
            }
            else
            {
                MessageBox.Show("El pago no se pudo realizar.\n");
                pagado = false;
                return pagado;
            }
        }

        public bool realizarPagoEfectivo(float monto, Pedido pedido)
        {
            nuevoPago();
            MessageBox.Show("Se realizará la impresión del ticket \n Por favor retire el ticket y dirijase a una de las cajas para realizar el pago y retirar el pedido ");
            fechaPago = DateTime.Now;
            pagado = false;
            Impresora imp = new Impresora();
            imp.imprimir(new Ticket(), pedido);

            return pagado;
        }
    }
}
