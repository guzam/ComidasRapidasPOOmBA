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
        string razonSocial;
        string nombreFantasia;
        string cuit;
        string direccion;
        string cp;
        string ib;
        string inicioActvidad;
        string afipLocal;
        string nombreUsuario;
        string afiplUsuario;
        static int incrementarId;

        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int IdTicket { get { return idTicket; } set { idTicket = value; } }
        public string NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        public string AfipLocal { get { return afipLocal; } set { afipLocal = value; } }
        public string AfipUsuario { get { return afiplUsuario; } set { afiplUsuario = value; } }
        public string RazonSocial { get { return razonSocial; } set { razonSocial = value; } }
        public string NombreFantasia { get { return nombreFantasia; } set { nombreFantasia = value; } }
        public string Cuit { get { return cuit; } set { cuit = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Cp { get { return cp; } set { cp = value; } }
        public string IngresosBrutos { get { return ib; } set { ib = value; } }
        public string InicioActividad { get { return inicioActvidad; } set { inicioActvidad = value; } }






        public Ticket()
        {
            fecha = DateTime.Now;
            incrementarId++;
            idTicket = incrementarId;
            nombreFantasia = "POOmBA - LA MEJOR COMIDA RAPIDA";

            razonSocial = "POOmBA S.A.";
            cuit = "20-99093303-8";
            direccion = "Av. Corrientes 602";
            cp = "C.P. (1005) - C.A.B.A.";
            ib = "901-030363-6";
            inicioActvidad = "01/12/2012";
            afipLocal = "IVA Responsable Inscripto";
            nombreUsuario = "";
            afiplUsuario = "";
        }

        public int verIdTicket()
        {
            return idTicket;
        }
        public DateTime verFecha()
        {
            return fecha;
        }
        /*
        public void imprimir()
        {

        }
        */

    }
}
