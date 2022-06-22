using ComidasRapidasPOOmBA.Clases;
using ComidasRapidasPOOmBA.Clases.Productos;
using ComidasRapidasPOOmBA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComidasRapidasPOOmBA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            var registroNuevo = new registro();
            registroNuevo.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {          
            var objetobd = new BDInterna();
            var lista = objetobd.initListaUsuarios();

            var usuarioIngresando = new Usuario();
            usuarioIngresando.Usu = txtUsuario.Text;
            usuarioIngresando.Password = txtPass.Text;

            var user = lista.Find(item => item.Usu == usuarioIngresando.Usu);
            if (user == null) MessageBox.Show("Usuario/Password incorrecto. Cod 1");
            else        
            {
                if (user.Password == usuarioIngresando.Password)
                {
                    var menu = new Menu();
                    menu.Show();
                } 
                else MessageBox.Show("Usuario/Password incorrecto.Cod 2"); 
            }
                                            
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            var nosotros = new AcercaDe();
            nosotros.Show();
        }
    }
}
