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

        //**************ocultar groupbox cuando selecciono uno
        public void ocultarGroupBoxMenoselSeleccionado(GroupBox abrir, GroupBox cerrar1, GroupBox cerrar2, GroupBox cerrar3, GroupBox cerrar4, GroupBox cerrar5)
        {
            abrir.Visible = true;
            cerrar1.Visible = false;
            cerrar2.Visible = false;
            cerrar3.Visible = false;
            cerrar4.Visible = false;
            cerrar5.Visible = false;

        }

        //*************Funcion para ver si creo o no el objeto hamburguesas
        public bool creoUnObjeto(int code)    //le paso la cantidad de hamburgesas
        {

            switch (code)
            {
                case 1:
                    {
                        hC = new Hamburguesa();
                        hC.Codigo = code;
                        hC.Nombre = lblHdeCarne.Text;
                        hC.Stock = 100;
                        hC.Tipo = "Comida";
                        hC.CodTamamio = 111;
                        hC.Tamanio = "Chico";
                        hC.Precio = 500;
                        hC.CantHamburguesas = 1;//se refiere a medallones
                        hC.Aderezo = "no tiene";
                        return true;
                    }
                case 2:
                    {
                        hP = new Hamburguesa();
                        hP.Nombre = lblHdeCarne.Text;
                        hP.Stock = 150;
                        hP.Tipo = "Comida";
                        hP.CodTamamio = 111;
                        hP.Tamanio = "Chico";
                        hP.Precio = 500;
                        hP.CantHamburguesas = 1;//se refiere a medallones
                        hP.Aderezo = "no tiene";
                        return true;
                    }
                case 3:
                    {
                        hV = new Hamburguesa();
                        hV.Nombre = lblHdeCarne.Text;
                        hV.Stock = 200;
                        hV.Tipo = "Comida";
                        hV.CodTamamio = 111;
                        hV.Tamanio = "Chico";
                        hV.Precio = 500;
                        hV.CantHamburguesas = 1;//se refiere a medallones
                        hV.Aderezo = "no tiene";
                        return true;
                    }
                default:
                    return false;
            }
        }

        private void btnHamburguesas_Click(object sender, EventArgs e)
        {
            //ocultar groupbox cuando selecciono uno
            ocultarGroupBoxMenoselSeleccionado(gbHamburguesas, gbEnsaladas, gbGuarniciones, gbBebidas, gbPostres, gbSugerencia2);
        }
        private void btnEnsalada_Click(object sender, EventArgs e)
        {
            ocultarGroupBoxMenoselSeleccionado(gbEnsaladas, gbGuarniciones, gbBebidas, gbPostres, gbSugerencia2, gbHamburguesas);
        }
        private void btnGuarniciones_Click(object sender, EventArgs e)
        {
            ocultarGroupBoxMenoselSeleccionado(gbGuarniciones, gbBebidas, gbPostres, gbSugerencia2, gbHamburguesas, gbEnsaladas);
        }
        private void btnBebidas_Click(object sender, EventArgs e)
        {
            ocultarGroupBoxMenoselSeleccionado(gbBebidas, gbPostres, gbSugerencia2, gbHamburguesas, gbEnsaladas, gbGuarniciones);
        }
        private void btnPostres_Click(object sender, EventArgs e)
        {
            ocultarGroupBoxMenoselSeleccionado(gbPostres, gbSugerencia2, gbHamburguesas, gbEnsaladas, gbGuarniciones, gbBebidas);
        }
        private void btnSugerencia_Click(object sender, EventArgs e)
        {
            ocultarGroupBoxMenoselSeleccionado(gbSugerencia2, gbHamburguesas, gbEnsaladas, gbGuarniciones, gbBebidas, gbPostres);
        }


        private void btnAgregarHamburguesas_Click(object sender, EventArgs e)
        {
            gbHamburguesas.Visible = false; //escondo group box

            if(numericUpDownHamburguesaDeCarne.Value != 0)//si marco carne y el numero es > que cero
            {
                int code = 1;
                creoUnObjeto(code);//envio el codigo

                if (checkBoxDobleHdeCarne.Checked == true)
                {
                    hC.Precio = 800;
                    hC.CantHamburguesas = 2;//se refiere a medallones
                }
                if (checkBoxAderezoHdeCarne.Checked)
                    hC.Aderezo = checkBoxAderezoHdeCarne.Text;

                h = hC;
             
                MessageBox.Show("Codigo: " + h.Codigo + "-" + "Nombre: " + h.Nombre + "-" + "Stock: " + h.Stock + "-" + "Precio individual: " + h.Precio + "-" + "Medallones: " + h.CantHamburguesas + "-" + "Tipo: " + h.Tipo + "-" + "Cod.Tamanio: " + h.CodTamamio + "-" + "Tamanio: " + h.Tamanio + "-" + "Aderezo: " + h.Aderezo);

                var cant = (int)numericUpDownHamburguesaDeCarne.Value;//cantidad de hamburguesas

                var detalle = new Detalle(cant, h);
                
                var subTotal = detalle.subtotalPorProducto(cant, h);

                ListaD = pedido.ListaDetalle;
                //pedido.ListaDetalle = ListaD;

                pedido.ingresarAPedido(detalle);
                MessageBox.Show("Subtotal:" + subTotal);


                List<string> listAux = new List<string>();

                foreach (var det in ListaD)
                {
                    listAux.Add("Cantidad: "+det.Cantidad + " " + det.Item.Nombre + " " + det.Subtotal);
                }

                listBoxPedido.DataSource = null;
                listBoxPedido.DataSource = listAux;
                //Pedido_01.ListaDetalle.Add(detalle);
                //var Total=Pedido_01.sumaTotal(Pedido_01);
                //MessageBox.Show("Total:"+Total);

            }
            else
                MessageBox.Show("No hay objeto");

            if (numericUpDownHamburguesaDePollo.Value != 0)
            {
                //agregar h de poio
            }
            if (numericUpDownHamburguesaVeggie.Value != 0)
            {
                //agregar h veggie
            }



            //var detalle = new Detalle(2, h);
            //hp = metodoParaEvaluarSiCreoOnoUnObjeto(numericUpDownHamburguesaDePollo.Value, txtCodigoHp.Text);
            //hv = metodoParaEvaluarSiCreoOnoUnObjeto(numericUpDownHamburguesaVeggie.Value, txtCodigoHv.Text);
        }
    }
}

