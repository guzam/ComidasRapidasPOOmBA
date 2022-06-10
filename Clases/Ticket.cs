using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Ticket
    {
        DateTime fecha;
        int idTicket;
        string nombreLocal;
        string afip; //condicion del cliente frente a afip? podria llamarse condicionAfip?


        public int IdTicket
        {
            get
            {
                return idTicket;
            }
            set
            {
                idTicket = value;
            }
        }
        public string Afip
        {
            get
            {
                return afip;
            }
            set
            {
                afip = value;
            }
        }
        public Ticket()
        {
            fecha = DateTime.Now;

            nombreLocal = "Mc POOmBA";
            afip = "";
        }
        /*
        public void imprimir()
        {

        }
        */

    }
}
