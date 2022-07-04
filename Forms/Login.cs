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
        BDInterna objetobd;
        public Login()
        {
            objetobd = new BDInterna();
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            var PantallaInicial = new FormularioMenu();
            PantallaInicial.Show();

        //List<Detalle> ListaD = new List<Detalle>();
        //Pedido pedido = new Pedido(1, ListaD);
            
            
            
        }


        //*******************ver de que es esto
        private void label1_Click(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {           
            var registroNuevo = new registro(objetobd, this);//?????
            this.Hide();
            registroNuevo.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {          
            
            var lista = objetobd.getUsuarios();

            var usuarioIngresando = new Usuario();
            usuarioIngresando.Usu = txtUsuario.Text;
            usuarioIngresando.Password = txtPass.Text;

            var user = lista.Find(item => item.Usu == usuarioIngresando.Usu);
            if (user == null) MessageBox.Show("Usuario/Password incorrecto. Cod 1");
            else        
            {
                if (user.Password == usuarioIngresando.Password)
                {
                    var menu = new FormularioMenu(user, this);
                    menu.Show();
                    this.Hide();
                    txtPass.Text = "";
                    txtUsuario.Text = "";
                } 
                else MessageBox.Show("Usuario/Password incorrecto.Cod 2"); 
            }
                                            
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            var nosotros = new AcercaDe();
            nosotros.Show();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
        //*************************************
    }
}
