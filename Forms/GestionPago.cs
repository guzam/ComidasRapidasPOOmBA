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

namespace ComidasRapidasPOOmBA.Forms
{
    public partial class GestionPago : Form
    {
        
        bool efectivo = false;
        Pedido pedido = new Pedido();
        public GestionPago()
        {
            InitializeComponent();
        }
        public GestionPago(Pedido ped)
        {
            InitializeComponent();
            pedido = ped;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverGP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (efectivo)
                {
                    MessageBox.Show("Se realizará la impresión del ticket \n Por favor retire el ticket y dirijase a una de las cajas para realizar el pago y retirar el pedido ");
                    this.Close();
                }
                else
                {
                    var total = float.Parse(lblTotalDetalle.Text);
                    Pago pago = new Pago(total);

                    pago.realizarPago(total,pedido);
                }
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        private void txtNroTarjeta1_TextChanged(object sender, EventArgs e)
        {
            //if (txtNroTarjeta1.Text.Length == 4)
            //{
            //    txtNroTarjeta2.Focus();
            //}
        }

        private void txtNroTarjeta2_TextChanged(object sender, EventArgs e)
        {
            //if (txtNroTarjeta2.Text.Length == 4)
            //{
            //    txtNroTarjeta3.Focus();
            //}
            //else
            if (txtNroTarjeta2.Text.Length < 1)
            {
                txtNroTarjeta1.Focus();
            }
        }

        private void txtNroTarjeta3_TextChanged(object sender, EventArgs e)
        {
            //if (txtNroTarjeta3.Text.Length == 4)
            //{
            //    txtNroTarjeta4.Focus();
            //}
            //else 
            if (txtNroTarjeta3.Text.Length < 1)
            {
                txtNroTarjeta2.Focus();
            }
        }

        private void txtNroTarjeta4_TextChanged(object sender, EventArgs e)
        {
            //if (txtNroTarjeta4.Text.Length == 4)
            //{
            //    txtVencimiento.Focus();
            //}
            //else 
            if (txtNroTarjeta4.Text.Length < 1)
            {
                txtNroTarjeta3.Focus();
            }
        }

        private void txtVencimiento_TextChanged(object sender, EventArgs e)
        {
            //if (txtVencimiento.Text.Length == 7)
            //{
            //    txtCodSeguridad.Focus();
            //}
            //else 
            if (txtVencimiento.Text.Length < 1)
            {
                txtNroTarjeta4.Focus();
            }
        }

        private void txtCodSeguridad_TextChanged(object sender, EventArgs e)
        {
            if (txtCodSeguridad.Text.Length == 3)
            {
                btnConfirmarPago.Enabled = true;
            }
            else if (txtCodSeguridad.Text.Length < 3 && txtCodSeguridad.Text.Length >= 1)
            {
                btnConfirmarPago.Enabled = false;
            }
            else if (txtCodSeguridad.Text.Length < 1)
            {
                txtVencimiento.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNroTarjeta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void txtNroTarjeta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void txtNroTarjeta3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void txtNroTarjeta4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void txtVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void txtCodSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerico(sender, e);
        }

        private void validarNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void validarContinuar(KeyEventArgs e)
        {
            //if (e.KeyCode != Keys.Back)
           // {
                if (txtNroTarjeta1.Text.Length == 4 &&
                    txtNroTarjeta2.Text.Length == 4 &&
                    txtNroTarjeta3.Text.Length == 4 &&
                    txtNroTarjeta4.Text.Length == 4 &&
                    txtCodSeguridad.Text.Length == 3)
                {
                    btnConfirmarPago.Enabled = true;
                }
                else
                {
                    btnConfirmarPago.Enabled = false;
                }
        
        //}


        }

        private void txtVencimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back && txtVencimiento.Text.Length == 2)
            {
                txtVencimiento.AppendText("/");
            }
        }
        private void txtNroTarjeta1_KeyUp(object sender, KeyEventArgs e)
        {
            validarContinuar(e);
            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && txtNroTarjeta1.Text.Length == 4)
            {
                txtNroTarjeta2.Focus();
            }
        }
        private void txtNroTarjeta2_KeyUp(object sender, KeyEventArgs e)
        {
            validarContinuar(e);
            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && txtNroTarjeta2.Text.Length == 4)
            {
                txtNroTarjeta3.Focus();
            }
        }

        private void txtNroTarjeta3_KeyUp(object sender, KeyEventArgs e)
        {
            validarContinuar(e);
            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && txtNroTarjeta3.Text.Length == 4)
            {
                txtNroTarjeta4.Focus();
            }
        }

        private void txtNroTarjeta4_KeyUp(object sender, KeyEventArgs e)
        {
            validarContinuar(e);
            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && txtNroTarjeta4.Text.Length == 4)
            {
                txtVencimiento.Focus();
            }
        }

        private void txtVencimiento_KeyUp(object sender, KeyEventArgs e)
        {
            validarContinuar(e);
            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Left && txtVencimiento.Text.Length == 7)
            {
                txtCodSeguridad.Focus();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            gbMedioPago.Visible = false;
            gbTarjeta.Visible = true;
            efectivo = false;
            btnConfirmarPago.Enabled = false;
        }

        private void gbTarjeta_Enter(object sender, EventArgs e)
        {

        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            efectivo = true;
            btnConfirmarPago.Enabled = true;
        }

        private void lblTotalDetalle_Click(object sender, EventArgs e)
        {

        }
    }
}
