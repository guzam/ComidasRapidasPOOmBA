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
        BDInterna objetobd;
        Form form;
        public registro(BDInterna obj, Form login)
        {
            objetobd = obj;
            form = login;
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
         //if (txtNombre.Text == null) MessageBox.Show("Debe ingresar un nombre");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var lista = objetobd.getUsuarios();
            var usuarioPorPantalla = new Usuario();
            
            try
            {
                if(!txtNombre.Text.Equals("") && !txtUsuario.Text.Equals("") && !txtDni.Text.Equals("") && !txtMail.Text.Equals("")) 
                {
                    usuarioPorPantalla.Nombre = txtNombre.Text;
                    usuarioPorPantalla.Usu = txtUsuario.Text;
                    usuarioPorPantalla.DNI = txtDni.Text;
                    usuarioPorPantalla.Email = txtMail.Text;
                    usuarioPorPantalla.Password = txtPass.Text;
                    usuarioPorPantalla.TipoUsuario = "Comun";
                    usuarioPorPantalla.Edad = int.Parse(txtEdad.Text);


                    if (txtPass.Text.Equals(txtConfirmar.Text) && !txtPass.Text.Equals(""))
                    {
                        var us = lista.Find(item => item.Usu == usuarioPorPantalla.Usu);
                        if (us == null)
                        {
                            objetobd.agregarUsuarios(usuarioPorPantalla);
                            MessageBox.Show("Se registro correctamente \n Verifica en tu correo electrónico el mensaje de confirmación \n Ingrese");
                            form.Show();
                            this.Close();
                        }
                        else MessageBox.Show("El usuario ya se encunetra registrado \n Ingrese otro usuario");
                    }
                    else MessageBox.Show("Las contraseñas no coinciden");
                }
                else { MessageBox.Show("Completar campo vacio"); }

                
            }

            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un numero \n En el campo edad");
            }
         
        }

        //private bool validarCampos() { }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
           // validarNumerico(sender, e);
        }

       /* private void validarNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }*/

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
           // validarNumerico(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)//boton volver
        {
            form.Show();
            this.Close();
        }
    }
}
