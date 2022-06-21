using ComidasRapidasPOOmBA.Clases;
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
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            var PantallaInicial = new FormularioMenu();
            PantallaInicial.Show();

        //List<Detalle> ListaD = new List<Detalle>();
        //Pedido pedido = new Pedido(1, ListaD);
            
            
            
        }
        
        
        //*******************ver de que es esto
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //*************************************
    }
}
