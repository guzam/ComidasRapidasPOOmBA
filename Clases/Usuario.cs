using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    
    class Usuario //: IComparable;
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
        public Usuario(string nom, string usu, string tipoU, string em, string pass)
        {
            nombre = nom;
            usuario = usu;
            tipoUsuario = tipoU;
            email = em;
            password = pass;
            idUsuarioGeneral++;
            idUsuario = idUsuarioGeneral;           
        }
        public string user { get => usuario; set => usuario = value; }
        public string nom { get => nombre; }  //set string value; }
        public string em { get => email; }  //set string value; }
        public string pass { get => password; }  //set string value; }

        public int ComparteTo( object? item ) //compara por usuario
        {
            if ( item == null)
                return 1;
            var aux = (Usuario) item; //var aux = item as Usuario;
            return String.Compare(this.usuario, aux.usuario);
        }

        // var us = usuarios.Find( item => item.user == txtUsuario ) si ecunetra un usuario igual que mande alert
        // if (us == null){ entonces puede seguir registrandose}
        // else "el usuario ya existe, ingrese otro nombre de usuario"

       // List<Usuario> usuarios = new List<Usuario>();
         //Usuario us1 = new Usuario("Lucas", "lucas123", "comun", "lucas@poomba.com", "che1234");
         //usuarios.Add(us1);
        //usuarios.Add ( new Usuario("Juan"; "juanca23", "comun", juancarlos@hotmail.com", "juan2020"));

        /*para validad usuario cuando esta ingresando
         * var usarioPorPantalla = txtUsuario;
         * var passPorPantalla = txtPass
         * 
         * var usu = usuarios.Find ( item => item.user == usuarioPorPantalla );
         * if ( usu == null ) MessageBox.Show "Usuario/Password incorrecto. Cod 1"; //por cartel
         * else { if (usu.pass == passPorPantalla) MessageBox.Show "Usuario aceptado"; // ingresa a menu
         *        else MessageBox.Show "Usuario/Password incorrecto.Cod 2";  //por cartel
         * 
         */
        //var usuarios = new List<Usuario>();     hhkñlñlk



    }


}
