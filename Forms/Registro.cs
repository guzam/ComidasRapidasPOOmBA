using ComidasRapidasPOOmBA.Clases;
using ComidasRapidasPOOmBA.Clases.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComidasRapidasPOOmBA.Forms
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == null) MessageBox.Show("Debe ingresar un nombre");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuarioPorPantalla = new Usuario();
            usuarioPorPantalla.Nombre = txtNombre.Text;
            usuarioPorPantalla.Usu = txtUsuario.Text;
            usuarioPorPantalla.Email = txtMail.Text;
            usuarioPorPantalla.Password = txtPass.Text;
            usuarioPorPantalla.TipoUsuario = "Comun";
            var aux = int.Parse(txtEdad.Text);
            usuarioPorPantalla.Edad = aux;
         
            BDInterna bd = new BDInterna();
            bd.agregarUsuarios(usuarioPorPantalla);

            var menu = new Menu();
            menu.Show();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //hacer comparacion para ver si ya existe ese usuario?
            Console.WriteLine();
        }
    }
}
