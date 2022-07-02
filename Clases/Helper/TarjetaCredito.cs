using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComidasRapidasPOOmBA.Clases.Helper
{
    public class TarjetaCredito
    {
        bool pagoAprobado;
        float limiteDisponible = 100000;

        public bool PagoAprobado { get => pagoAprobado; set => pagoAprobado = value; }
        public float LimiteDisponible { get => limiteDisponible; }

        public bool validarLimite(float aPagar)
        {
            if (aPagar <= LimiteDisponible)
            {
                //Se puede realizar el pago
                return true;
            }
            else
            {
                MessageBox.Show("El limite disponible de la tarjeta no alcanza para realizar el pago \n Por favor intente con otra tarjeta.");
                return false;
            }
        }

        public bool realizarPagoTarjeta(float monto)
        {
            if (validarLimite(monto))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
