using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    class Usuario
    {
        string nombre;
        int idUsuario;
        static int idUsuarioGeneral;
        string tipoUsuario;
        string email;
        string password;
        bool ingresoPermitido;

        public Usuario(string nom, int idUs, string tipoU, string em, string pass, bool ingP)
        {
            nombre = nom;
            idUsuario = idUs;
            tipoUsuario = tipoU;
            email = em;




        }


    }
}
