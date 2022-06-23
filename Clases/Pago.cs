using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    class Pago
    {
        int idPago;
        DateTime fechaPago;
        float montoTotal;
        bool pagado;

        public Pago()
        {

        }

        public Pago(float monto)
        {
            IdPago++;
            MontoTotal = monto;
        }

        public int IdPago { get => idPago; set => idPago = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public float MontoTotal { get => montoTotal; set => montoTotal = value; }
        public bool Pagado { get => pagado; set => pagado = value; }
    }
}
