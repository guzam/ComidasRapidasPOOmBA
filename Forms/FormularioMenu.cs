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
    public partial class FormularioMenu : Form
    {
        public List<Detalle> ListaD = new List<Detalle>();
        Pedido pedido = new Pedido(new List<Detalle>());//se crea el objeto pedido
        Hamburguesa hC, hP, hV, h;
        public FormularioMenu()
        {
            InitializeComponent();
        }

        //*********************************************************************************
        public void ocultarGroupBoxMenoselSeleccionado(GroupBox abrir, GroupBox cerrar1, GroupBox cerrar2, GroupBox cerrar3, GroupBox cerrar4)
        {
            abrir.Visible = true;
            cerrar1.Visible = false;
            cerrar2.Visible = false;
            cerrar3.Visible = false;
            cerrar4.Visible = false;
        }
        //***********************************************************************************
        private void btnHamburguesas_Click(object sender, EventArgs e)
        {
            //ocultar groupbox cuando selecciono uno
            ocultarGroupBoxMenoselSeleccionado(gbHamburguesas, gbEnsaladas, gbGuarniciones, gbBebidas, gbPostres);
        }
        private void btnEnsalada_Click(object sender, EventArgs e)
        {
            ocultarGroupBoxMenoselSeleccionado(gbEnsaladas, gbGuarniciones, gbBebidas, gbPostres, gbHamburguesas);
        }
        private void btnGuarniciones_Click(object sender, EventArgs e)
        {
            ocultarGroupBoxMenoselSeleccionado(gbGuarniciones, gbBebidas, gbPostres, gbHamburguesas, gbEnsaladas);
        }
        private void btnBebidas_Click(object sender, EventArgs e)
        {
            ocultarGroupBoxMenoselSeleccionado(gbBebidas, gbPostres, gbHamburguesas, gbEnsaladas, gbGuarniciones);
        }

        private void btnSugerencia_Click(object sender, EventArgs e)
        {
            ocultarGroupBoxMenoselSeleccionado(gbGuarniciones, gbHamburguesas, gbEnsaladas, gbBebidas, gbPostres);
        }
        private void btnPostres_Click(object sender, EventArgs e)
        {
            ocultarGroupBoxMenoselSeleccionado(gbPostres, gbHamburguesas, gbEnsaladas, gbGuarniciones, gbBebidas);
        }
       
        //*************************************************************************
        public Hamburguesa calculoParaDobleGrande(Hamburguesa h)
        {
            h.Precio = float.Parse(txtHamburguesaGrandeDoble.Text);
            h.CantMedallones = 2;
            h.Tamanio = "Grande";
            h.CodTamanio = 2;
            return h;
        }
        public Hamburguesa calculoParaRegularDoble(Hamburguesa h)
        {
            h.Precio = float.Parse(txtHamburguesaRegDoble.Text);
            h.CantMedallones = 2;
            h.Tamanio = "Regular";
            h.CodTamanio = 1;
            return h;
        }
        public Hamburguesa calculoParaGrandeSimple(Hamburguesa h)
        {
            h.Precio = float.Parse(txtHamburguesaGrandeSimple.Text);
            h.CantMedallones = 1;
            h.Tamanio = "Grande";
            h.CodTamanio = 2;
            return h;
        }
        public Hamburguesa calculoParaRegularsimple(Hamburguesa h)
        {
            h.Precio = float.Parse(txtHamburguesaRegSimple.Text);
            h.CantMedallones = 1;
            h.Tamanio = "Regular";
            h.CodTamanio = 1;
            return h;
        }
        
        //*******************************************************************************
        public Hamburguesa valoresHarcodeadosHcarne(Hamburguesa hC)
        {
            hC.Codigo = 111;
            hC.Nombre = lblHdeCarne.Text;
            hC.Stock = 100;
            hC.Tipo = "Comida";
            return hC;
        }
        public Hamburguesa valoresPorPantallaHcarne (Hamburguesa hC)
        {
            if (checkBoxDobleHdeCarne.Checked == true && checkHdeCarneGrande.Checked == true)
            {
                hC = calculoParaDobleGrande(hC);
            }
            else
            {
                if (checkBoxDobleHdeCarne.Checked == true)
                {
                    hC = calculoParaRegularDoble(hC);
                }
                else
                {
                    if (checkHdeCarneGrande.Checked == true)
                    {
                        hC = calculoParaGrandeSimple(hC);
                    }
                    else
                    {
                        hC = calculoParaRegularsimple(hC);
                    }
                }
            }

            if (checkBoxAderezoHdeCarne.Checked)
                hC.Aderezo = "si";
            else
                hC.Aderezo = "no";
            
            return hC;
        }
        
        //*****************************************************************************
        public Hamburguesa valoresHarcodeadosHPollo(Hamburguesa hP)
        {
            hP.Codigo = 222;
            hP.Nombre = lblHdePollo.Text;
            hP.Stock = 200;
            hP.Tipo = "Comida";
            return hP;
        }
        public Hamburguesa valoresPorPantallaHPollo(Hamburguesa hP)
        {
            if (checkBoxDobleHdePollo.Checked == true && checkHdePolloGrande.Checked == true)
            {
                hP = calculoParaDobleGrande(hP);
            }
            else
            {
                if (checkBoxDobleHdePollo.Checked == true)
                {
                    hP = calculoParaRegularDoble(hP);
                }
                else
                {
                    if (checkHdePolloGrande.Checked == true)
                    {
                        hP = calculoParaGrandeSimple(hP);
                    }
                    else
                    {
                        hP = calculoParaRegularsimple(hP);
                    }
                }
            }

            if (checkBoxAderezoHdePollo.Checked)
                hP.Aderezo = "si";
            else
                hP.Aderezo = "no";

            return hP;
        }
        
        //**********************************************************************
        public Hamburguesa valoresHarcodeadosHVeggie(Hamburguesa hV)
        {
            hV.Codigo = 333;
            hV.Nombre = lblHdeVeggan.Text;
            hV.Stock = 300;
            hV.Tipo = "Comida";
            return hV;
        }
        public Hamburguesa valoresPorPantallaHVeggie(Hamburguesa hV)
        {
            if (checkBoxDobleHdeVeggie.Checked == true && checkHdeVeggieGrande.Checked == true)
            {
                hV = calculoParaDobleGrande(hV);
            }
            else
            {
                if (checkBoxDobleHdeVeggie.Checked == true)
                {
                    hV = calculoParaRegularDoble(hV);
                }
                else
                {
                    if (checkHdeVeggieGrande.Checked == true)
                    {
                        hV = calculoParaGrandeSimple(hV);
                    }
                    else
                    {
                        hV = calculoParaRegularsimple(hV);
                    }
                }
            }

            if (checkBoxAderezoHdeVeggie.Checked)
                hV.Aderezo = "si";
            else
                hV.Aderezo = "no";

            return hV;
        }

        //*****************************************************************************************

        public Hamburguesa gestionDetalle(int c, Hamburguesa h)
        {
            var detalle = new Detalle(c, h);//creo el objeto detalle
            var subTotal = detalle.subtotalPorProducto(c, h);//calculo el subtotal de ese item
            pedido.ingresarAPedido(detalle);//agrego el item a la lista
            return h;
        }

        //********************************************************************************************
        private void btnAgregarHamburguesas_Click(object sender, EventArgs e)
        {
           if (numericUpDownHamburguesaDeCarne.Value != 0)//si marco carne y el numero es > que cero
            {
                gbHamburguesas.Visible = false; //escondo group box
                hC = new Hamburguesa();
                hC = valoresHarcodeadosHcarne(hC);
                hC = valoresPorPantallaHcarne(hC);
                var cant = (int)numericUpDownHamburguesaDeCarne.Value;//cantidad de hamburguesas
                hC = gestionDetalle(cant, hC);
                MessageBox.Show("Codigo: " + hC.Codigo + "-" + "Nombre: " + hC.Nombre + "-" + "Stock: " + hC.Stock + "-" + "Precio individual: " + hC.Precio + "-" + "Medallones: " + hC.CantMedallones + "-" + "Tipo: " + hC.Tipo + "-" + "Cod.Tamanio: " + hC.CodTamanio + "-" + "Tamanio: " + hC.Tamanio + "-" + "Aderezo: " + hC.Aderezo);

            }
            else
                MessageBox.Show("No hay objeto de carne");
            
            if (numericUpDownHamburguesaDePollo.Value != 0)//si marco carne y el numero es > que cero
            {
                gbHamburguesas.Visible = false; //escondo group box
                hP = new Hamburguesa();
                hP = valoresHarcodeadosHPollo(hP);
                hP = valoresPorPantallaHPollo(hP);
                var cant = (int)numericUpDownHamburguesaDePollo.Value;//cantidad de hamburguesas
                hP = gestionDetalle(cant, hP);
                MessageBox.Show("Codigo: " + hP.Codigo + "-" + "Nombre: " + hP.Nombre + "-" + "Stock: " + hP.Stock + "-" + "Precio individual: " + hP.Precio + "-" + "Medallones: " + hP.CantMedallones + "-" + "Tipo: " + hP.Tipo + "-" + "Cod.Tamanio: " + hP.CodTamanio + "-" + "Tamanio: " + hP.Tamanio + "-" + "Aderezo: " + hP.Aderezo);

            }
            else
                MessageBox.Show("No hay objeto de pollo");
                        
            if (numericUpDownHamburguesaVeggie.Value != 0)
            {
                gbHamburguesas.Visible = false; //escondo group box
                hV = new Hamburguesa();
                hV = valoresHarcodeadosHVeggie(hV);
                hV = valoresPorPantallaHVeggie(hV);
                var cant = (int)numericUpDownHamburguesaVeggie.Value;//cantidad de hamburguesas
                hV = gestionDetalle(cant, hV);
                MessageBox.Show("Codigo: " + hV.Codigo + "-" + "Nombre: " + hV.Nombre + "-" + "Stock: " + hV.Stock + "-" + "Precio individual: " + hV.Precio + "-" + "Medallones: " + hV.CantMedallones + "-" + "Tipo: " + hV.Tipo + "-" + "Cod.Tamanio: " + hV.CodTamanio + "-" + "Tamanio: " + hV.Tamanio + "-" + "Aderezo: " + hV.Aderezo);
            }
            else
                MessageBox.Show("No hay objeto veggie");
            
            ListaD = pedido.ListaDetalle;
            List<string> listAux = new List<string>();
            foreach (var det in ListaD)
            {
                listAux.Add(det.Item.Nombre + " " + "Cantidad: " + det.Cantidad + " " + "Subtotal: " + det.Subtotal);
            }
            listBoxPedido.DataSource = listAux;
            var total=pedido.sumaTotal(pedido);
            MessageBox.Show("Total: "+total);
        }
    }
}

