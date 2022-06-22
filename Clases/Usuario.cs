using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Usuario //: IComparable;
    {
        string nombre;
        string usuario;
        string email;
        string password;
        int edad;
        int idUsuario;
        static int idUsuarioGeneral;
        string tipoUsuario;

        
        public Usuario()
        {
            
        }
        public Usuario(string nom, string usu, string tipoU, string em, int edad, string pass)
        {
            nombre = nom;
            usuario = usu;
            tipoUsuario = tipoU;
            email = em;
            password = pass;
            idUsuarioGeneral++;
            idUsuario = idUsuarioGeneral;           
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Usu { get => usuario; set => usuario = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Edad { get => edad; set => edad = value; }
        public string TipoUsuario { get => usuario; set => usuario = value; }

        /*public int ComparteTo( object? item ) //compara por usuario
        {
            if ( item == null)
                return 1;
            var aux = (Usuario) item; //var aux = item as Usuario;
            return String.Compare(this.usuario, aux.usuario);
        }*/

        // var us = usuarios.Find( item => item.user == txtUsuario ) si ecunetra un usuario igual que mande alert
        // if (us == null){ entonces puede seguir registrandose}
        // else "el usuario ya existe, ingrese otro nombre de usuario"



        //para validad usuario cuando esta ingresando
        
    }
}
