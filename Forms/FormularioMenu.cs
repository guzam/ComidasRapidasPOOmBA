using ComidasRapidasPOOmBA.Clases;
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
    
    public partial class FormularioMenu : Form
    {
        
        Pedido pedido = new Pedido(new List<Detalle>());
        Usuario usuLogueado = new Usuario();
        Hamburguesa hC, hP, hV, h;
        Ensalada eC, eG, eIv;
        Guarnicion pFritas, pCheddar, pPoomba;
        bebida gaseosa, agua, cerveza;
        Postre helado, budin, flan;

        public FormularioMenu()
        {
            InitializeComponent();
        }

        public FormularioMenu(Usuario usu)
        {
            InitializeComponent();
            usuLogueado = usu;
        }
        //*****************************METODO OCULTAR GROUPBOX********************************************
        public void ocultarGroupBoxMenoselSeleccionado(GroupBox abrir, GroupBox cerrar1, GroupBox cerrar2, GroupBox cerrar3, GroupBox cerrar4)
        {
            abrir.Visible = true;
            cerrar1.Visible = false;
            cerrar2.Visible = false;
            cerrar3.Visible = false;
            cerrar4.Visible = false;
        }
        //*****************************BOTONES CLICK QUE USAN EL METODO OCULTAR GROUPBOX******************
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
       //******************************METODOS HAMBURGUESAS PARA PRECIO Y ETC*****************************
        public Hamburguesa calculoParaGrandeDoble(Hamburguesa h)
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
        public Hamburguesa calculoParaRegularSimple(Hamburguesa h)
        {
            h.Precio = float.Parse(txtHamburguesaRegSimple.Text);
            h.CantMedallones = 1;
            h.Tamanio = "Regular";
            h.CodTamanio = 1;
            return h;
        }
        
        //*****************************VALORES HAMBURGUESAS DE CARNE**************************************
        public Hamburguesa valoresHarcodeadosHcarne(Hamburguesa hC)
        {
            hC.Codigo = 111;
            hC.Stock = 100;
            hC.Tipo = "Comida";
            return hC;
        }
        public Hamburguesa valoresPorPantallaHcarne(Hamburguesa hC)
        {
            hC.Nombre = lblHdeCarne.Text;
            if (checkBoxDobleHdeCarne.Checked == true && checkHdeCarneGrande.Checked == true)
            {
                hC = calculoParaGrandeDoble(hC);
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
                        hC = calculoParaRegularSimple(hC);
                    }
                }
            }

            if (checkBoxAderezoHdeCarne.Checked)
                hC.Aderezo = "si";
            else
                hC.Aderezo = "no";
            
            return hC;
        }
        
        //*****************************VALORES HAMBURGUESAS DE POLLO**************************************
        public Hamburguesa valoresHarcodeadosHPollo(Hamburguesa hP)
        {
            hP.Codigo = 222;
            hP.Stock = 200;
            hP.Tipo = "Comida";
            return hP;
        }
        public Hamburguesa valoresPorPantallaHPollo(Hamburguesa hP)
        {
            hP.Nombre = lblHdePollo.Text;
            if (checkBoxDobleHdePollo.Checked == true && checkHdePolloGrande.Checked == true)
            {
                hP = calculoParaGrandeDoble(hP);
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
                        hP = calculoParaRegularSimple(hP);
                    }
                }
            }

            if (checkBoxAderezoHdePollo.Checked)
                hP.Aderezo = "si";
            else
                hP.Aderezo = "no";

            return hP;
        }

        //*****************************VALORES HAMBURGUESAS VEGGIE****************************************
        public Hamburguesa valoresHarcodeadosHVeggie(Hamburguesa hV)
        {
            hV.Codigo = 333;
            hV.Stock = 300;
            hV.Tipo = "Comida";
            return hV;
        }
        public Hamburguesa valoresPorPantallaHVeggie(Hamburguesa hV)
        {
            hV.Nombre = lblHdeVeggan.Text;
            if (checkBoxDobleHdeVeggie.Checked == true && checkHdeVeggieGrande.Checked == true)
            {
                hV = calculoParaGrandeDoble(hV);
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
                        hV = calculoParaRegularSimple(hV);
                    }
                }
            }

            if (checkBoxAderezoHdeVeggie.Checked)
                hV.Aderezo = "si";
            else
                hV.Aderezo = "no";

            return hV;
        }

        //*****************************VALORES ENSALADA CAPRESE*******************************************
        public Ensalada valoresHarcodeadosEcaprese(Ensalada eC)
        {
            eC.Codigo = 444;
            eC.Stock = 400;
            eC.Tipo = "Comida";
            return eC;
        }
        public Ensalada valoresPorPantallaEcaprese(Ensalada eC)
        {
            eC.Nombre = lblEnsaladaCaprese.Text;
            if (checkBoxAderezoCaprese.Checked)
                eC.Aderezo = "si";
            else
                eC.Aderezo = "no";
            if (checkBoxCapreseGrande.Checked)
            {
                eC.Tamanio = "Grande";
                eC.CodTamanio = 2;
                eC.Precio = int.Parse(txtEnsaladaGrande.Text);
            }
            else
            {
                eC.Tamanio = "Regular";
                eC.CodTamanio = 1;
                eC.Precio = int.Parse(txtEnsaladaRegular.Text);
            }
            if (checkBoxSalCaprese.Checked)
                eC.Sal = "si";
            else
                eC.Sal = "no";
            return eC;
        }
        
        //*****************************VALORES ENSALADA GRIEGA********************************************
        public Ensalada valoresHarcodeadosEgriega(Ensalada eG)
        {
            eG.Codigo = 555;
            eG.Stock = 500;
            eG.Tipo = "Comida";
            return eG;
        }
        public Ensalada valoresPorPantallaEgriega(Ensalada eG)
        {
            eG.Nombre = lblEnsaladaGriega.Text;
            if (checkBoxAderezoGriega.Checked)
                eG.Aderezo = "si";
            else
                eG.Aderezo = "no";
            if (checkBoxGriegaGrande.Checked)
            {
                eG.Tamanio = "Grande";
                eG.CodTamanio = 2;
                eG.Precio = int.Parse(txtEnsaladaGrande.Text);
            }
            else
            {
                eG.Tamanio = "Regular";
                eG.CodTamanio = 1;
                eG.Precio = int.Parse(txtEnsaladaRegular.Text);
            }
            if (checkBoxSalGriega.Checked)
                eG.Sal = "si";
            else
                eG.Sal = "no";
            return eG;
        }
        
        //*****************************VALORES ENSALADA ITALIANA VEGANA***********************************
        public Ensalada valoresHarcodeadosEiV(Ensalada eIv)
        {
            eIv.Codigo = 666;
            eIv.Stock = 600;
            eIv.Tipo = "Comida";
            return eIv;
        }
        public Ensalada valoresPorPantallaEiV(Ensalada eIv)
        {
            eIv.Nombre = lblEnsaladaGriega.Text;
            if (checkBoxAderezoItaliana.Checked)
                eIv.Aderezo = "si";
            else
                eIv.Aderezo = "no";
            if (checkBoxItalianaGrande.Checked)
            {
                eIv.Tamanio = "Grande";
                eIv.CodTamanio = 2;
                eIv.Precio = int.Parse(txtEnsaladaGrande.Text);
            }
            else
            {
                eIv.Tamanio = "Regular";
                eIv.CodTamanio = 1;
                eIv.Precio = int.Parse(txtEnsaladaRegular.Text);
            }
            if (checkBoxSalItaliana.Checked)
                eIv.Sal = "si";
            else
                eIv.Sal = "no";
            return eIv;
        }

        //*****************************VALORES GUARNICION PAPAS FRITAS************************************
        public Guarnicion valoresHarcodeadosPfritas(Guarnicion pFritas)
        {
            pFritas.Codigo = 777;
            pFritas.Stock = 700;
            pFritas.Tipo = "Comida";
            return pFritas;
        }
        public Guarnicion valoresPorPantallaPfritas(Guarnicion pFritas)
        {
            pFritas.Nombre = lblPapasFritas.Text;
            if (checkBoxAderezoPapas.Checked)
                pFritas.Aderezo = "si";
            else
                pFritas.Aderezo = "no";
            if (checkBoxPapasGrande.Checked)
            {
                pFritas.Tamanio = "Grande";
                pFritas.CodTamanio = 2;
                pFritas.Precio = int.Parse(txtGuarnicionGrande.Text);
            }
            else
            {
                pFritas.Tamanio = "Regular";
                pFritas.CodTamanio = 1;
                pFritas.Precio = int.Parse(txtGuarnicionRegular.Text);
            }
            if (checkBoxSalPapas.Checked)
                pFritas.Sal = "si";
            else
                pFritas.Sal = "no";
            return pFritas;
        }
        
        //*****************************VALORES GUARNICION PAPAS CHEDDAR***********************************
        public Guarnicion valoresHarcodeadosPcheddar(Guarnicion pCheddar)
        {
            pCheddar.Codigo = 888;
            pCheddar.Stock = 800;
            pCheddar.Tipo = "Comida";
            return pCheddar;
        }
        public Guarnicion valoresPorPantallaPcheddar(Guarnicion pCheddar)
        {
            pCheddar.Nombre = lblPapasFritasConCheddar.Text;
            if (checkBoxSalPapasCheddar.Checked)
                pCheddar.Aderezo = "si";
            else
                pCheddar.Aderezo = "no";
            if (checkBoxPapasCheddarGrande.Checked)
            {
                pCheddar.Tamanio = "Grande";
                pCheddar.CodTamanio = 2;
                pCheddar.Precio = int.Parse(txtGuarnicionGrande.Text);
            }
            else
            {
                pCheddar.Tamanio = "Regular";
                pCheddar.CodTamanio = 1;
                pCheddar.Precio = int.Parse(txtGuarnicionRegular.Text);
            }
            if (checkBoxSalPapasCheddar.Checked)
                pCheddar.Sal = "si";
            else
                pCheddar.Sal = "no";
            return pCheddar;
        }
        
        //*****************************VALORES GUARNICION PAPAS POOMBA************************************
        public Guarnicion valoresHarcodeadosPpoomba(Guarnicion pPoomba)
        {
            pPoomba.Codigo = 999;
            pPoomba.Stock = 900;
            pPoomba.Tipo = "Comida";
            return pPoomba;
        }
        public Guarnicion valoresPorPantallaPpoomba(Guarnicion pPoomba)
        {
            pPoomba.Nombre = lblPapasFritasPoomba.Text;
            if (checkBoxAderezoPapasPoomba.Checked)
                pPoomba.Aderezo = "si";
            else
                pPoomba.Aderezo = "no";
            if (checkBoxPapasPoombaGrande.Checked)
            {
                pPoomba.Tamanio = "Grande";
                pPoomba.CodTamanio = 2;
                pPoomba.Precio = int.Parse(txtGuarnicionGrande.Text);
            }
            else
            {
                pPoomba.Tamanio = "Regular";
                pPoomba.CodTamanio = 1;
                pPoomba.Precio = int.Parse(txtGuarnicionRegular.Text);
            }
            if (checkBoxSalPapasCheddar.Checked)
                pPoomba.Sal = "si";
            else
                pPoomba.Sal = "no";
            return pPoomba;
        }

        //*****************************VALORES BEBIDA GASEOSA*********************************************
        public bebida valoresHarcodeadosGaseosa(bebida gaseosa)
        {
            gaseosa.Codigo = 1122;
            gaseosa.Stock = 100;
            gaseosa.Tipo = "Bebida";
            gaseosa.Tamanio = "Regular";
            gaseosa.CodTamanio = 1;
            gaseosa.Diet = "No";
            gaseosa.ConHielo = "No";
            return gaseosa;
        }
        public bebida valoresPorPantallaGaseosa(bebida gaseosa)
        {
            gaseosa.Nombre = lblGaseosa.Text;
            gaseosa.Precio=int.Parse(txtBebidaRegular.Text);

            if (checkBoxGaseosaGrande.Checked)
            {
                gaseosa.Tamanio = "Grande";
                gaseosa.CodTamanio = 2;
                gaseosa.Precio = int.Parse(txtBebidaGrande.Text);
            }
            if (checkBoxHieloGaseosa.Checked)
                gaseosa.ConHielo = "Si";
            if (checkBoxLightGaseosa.Checked)
                gaseosa.Diet = "Si";
            return gaseosa;
        }
        //*****************************VALORES BEBIDA AGUA*********************************************
        public bebida valoresHarcodeadosAgua(bebida agua)
        {
            agua.Codigo = 1133;
            agua.Stock = 200;
            agua.Tipo = "Bebida";
            agua.Tamanio = "Regular";
            agua.CodTamanio = 1;
            agua.ConHielo = "No";
            return agua;
        }
        public bebida valoresPorPantallaAgua(bebida agua)
        {
            agua.Nombre = lblAguaMineral.Text;
            agua.Precio = int.Parse(txtBebidaRegular.Text);

            if (checkBoxAguaGrande.Checked)
            {
                agua.Tamanio = "Grande";
                agua.CodTamanio = 2;
                agua.Precio = int.Parse(txtBebidaGrande.Text);
            }
            if (checkBoxHieloAgua.Checked)
                agua.ConHielo = "Si";
            
            return agua;
        }
        //*****************************VALORES BEBIDA CERVEZA*********************************************
        public bebida valoresHarcodeadosCerveza(bebida cerveza)
        {
            cerveza.Codigo = 1144;
            cerveza.Stock = 300;
            cerveza.Tipo = "Bebida";
            cerveza.Tamanio = "Regular";
            cerveza.CodTamanio = 1;
            return cerveza;
        }
        public bebida valoresPorPantallaCerveza(bebida cerveza)
        {
            cerveza.Nombre = lblCerveza.Text;
            cerveza.Precio = int.Parse(txtBebidaRegular.Text);
            if (checkBoxCervezaGrande.Checked)
            {
                cerveza.Tamanio = "Grande";
                cerveza.CodTamanio = 2;
                cerveza.Precio = int.Parse(txtBebidaGrande.Text);
            }
            return cerveza;
        }

        //*****************************VALORES POSTRE HELADO**********************************************
        public Postre valoresHarcodeadosHelado(Postre helado)
        {
            helado.Codigo = 5555;
            helado.Stock = 100;
            helado.Tipo = "Postre";
            helado.Tamanio = "Regular";
            helado.CodTamanio = 1;
            return helado;
        }
        public Postre valoresPorPantallaHelado(Postre helado)
        {
            helado.Nombre = lblHelado.Text;
            helado.Precio = int.Parse(txtPostreRegular.Text);

            if (checkBoxHeladoGrande.Checked)
            {
                helado.Tamanio = "Grande";
                helado.CodTamanio = 2;
                helado.Precio = int.Parse(txtPostreGrande.Text);
            }
            return helado;
        }
        //*****************************VALORES POSTRE BUDIN***********************************************
        public Postre valoresHarcodeadosBudin(Postre budin)
        {
            budin.Codigo = 6666;
            budin.Stock = 100;
            budin.Tipo = "Postre";
            budin.Tamanio = "Regular";
            budin.CodTamanio = 1;
            return budin;
        }
        public Postre valoresPorPantallaBudin(Postre budin)
        {
            budin.Nombre = lblBudinDePan.Text;
            budin.Precio = int.Parse(txtPostreRegular.Text);
            if (checkBoxBudinGrande.Checked)
            {
                budin.Tamanio = "Grande";
                budin.CodTamanio = 2;
                budin.Precio = int.Parse(txtPostreGrande.Text);
            }
            return budin;
        }
        //*****************************VALORES POSTRE QUEREMOS FLAN***************************************
        public Postre valoresHarcodeadosFlan(Postre flan)
        {
            flan.Codigo = 7777;
            flan.Stock = 100;
            flan.Tipo = "Postre";
            flan.Tamanio = "Regular";
            flan.CodTamanio = 1;
            return flan;
        }
        public Postre valoresPorPantallaFlan(Postre flan)
        {
            flan.Nombre = lblQueremosFlan.Text;
            flan.Precio = int.Parse(txtPostreRegular.Text);
            if (checkBoxFlanGrande.Checked)
            {
                flan.Tamanio = "Grande";
                flan.CodTamanio = 2;
                flan.Precio = int.Parse(txtPostreGrande.Text);
            }
            return flan;
        }

        

        //*****************************METODOS DETALLE****************************************************
        public Hamburguesa gestionDetalle(int c, Hamburguesa h)
        {
            var detalle = new Detalle(c, h);
            var subtotal = detalle.subtotalPorProducto(c, h);
            pedido.ingresarAPedido(detalle);
            return h;
        }
        public Ensalada gestionDetalle(int c, Ensalada e)
        {
            var detalle = new Detalle(c, e);
            var subTotal = detalle.subtotalPorProducto(c, e);
            pedido.ingresarAPedido(detalle);
            return e;
        }
        public Guarnicion gestionDetalle(int c, Guarnicion g)
        {
            var detalle = new Detalle(c, g);//creo el objeto detalle
            var subTotal = detalle.subtotalPorProducto(c, g);//calculo el subtotal de ese item
            pedido.ingresarAPedido(detalle);//agrego el item a la lista
            return g;
        }
        public bebida gestionDetalle(int c, bebida b)
        {
            var detalle = new Detalle(c, b);
            var subTotal = detalle.subtotalPorProducto(c, b);
            pedido.ingresarAPedido(detalle);
            return b;
        }
        public Postre gestionDetalle(int c, Postre p)
        {
            var detalle = new Detalle(c, p);
            var subTotal = detalle.subtotalPorProducto(c, p);
            pedido.ingresarAPedido(detalle);
            return p;
        }

        //*****************************BOTON AGREGAR HAMBURGUESAS*****************************************
        private void btnAgregarHamburguesas_Click(object sender, EventArgs e)
        {
           if (numericUpDownHamburguesaDeCarne.Value != 0)
            {
                gbHamburguesas.Visible = false;
                hC = new Hamburguesa();
                hC = valoresHarcodeadosHcarne(hC);
                hC = valoresPorPantallaHcarne(hC);
                var cant = (int)numericUpDownHamburguesaDeCarne.Value;
                hC = gestionDetalle(cant, hC);
            }
            
            if (numericUpDownHamburguesaDePollo.Value != 0)
            {
                gbHamburguesas.Visible = false;
                hP = new Hamburguesa();
                hP = valoresHarcodeadosHPollo(hP);
                hP = valoresPorPantallaHPollo(hP);
                var cant = (int)numericUpDownHamburguesaDePollo.Value;
                hP = gestionDetalle(cant, hP);
            }
                        
            if (numericUpDownHamburguesaVeggie.Value != 0)
            {
                gbHamburguesas.Visible = false;
                hV = new Hamburguesa();
                hV = valoresHarcodeadosHVeggie(hV);
                hV = valoresPorPantallaHVeggie(hV);
                var cant = (int)numericUpDownHamburguesaVeggie.Value;
                hV = gestionDetalle(cant, hV);
            }

            actualizarListaDetalle();
        }
        
        //*****************************BOTON AGREGAR ENSALADAS********************************************
        private void btnAgregarEnsaladas_Click(object sender, EventArgs e)
        {
            if (numericUpDownEnsaladaCaprese.Value != 0)
            {
                gbEnsaladas.Visible = false;
                eC = new Ensalada();
                valoresHarcodeadosEcaprese(eC);
                valoresPorPantallaEcaprese(eC);
                var cant = (int)numericUpDownEnsaladaCaprese.Value;
                eC = gestionDetalle(cant, eC);
            }

            if (numericUpDownensaladaGriega.Value != 0)
            {
                gbEnsaladas.Visible = false;
                eG = new Ensalada();
                valoresHarcodeadosEgriega(eG);
                valoresPorPantallaEgriega(eG);
                var cant = (int)numericUpDownensaladaGriega.Value;
                eG = gestionDetalle(cant, eG);
            }

            if (numericUpDownensaladaItalianaVegana.Value != 0)
            {
                gbEnsaladas.Visible = false;
                eIv = new Ensalada();
                valoresHarcodeadosEiV(eIv);
                valoresPorPantallaEiV(eIv);
                var cant = (int)numericUpDownensaladaItalianaVegana.Value;
                eIv = gestionDetalle(cant, eIv);
            }

            actualizarListaDetalle();
        }
        
        //*****************************BOTON AGREGAR GUARNICIONES*****************************************
        private void btnAgregarGuarniciones_Click(object sender, EventArgs e)
        {

            if (numericUpDownPapasFritas.Value != 0)
            {
                gbGuarniciones.Visible = false;
                pFritas = new Guarnicion();
                valoresHarcodeadosPfritas(pFritas);
                valoresPorPantallaPfritas(pFritas);
                var cant = (int)numericUpDownPapasFritas.Value;
                pFritas = gestionDetalle(cant, pFritas);
            }

            if (numericUpDownPapasFritasConCheddar.Value != 0)
            {
                gbGuarniciones.Visible = false;
                pCheddar = new Guarnicion();
                valoresHarcodeadosPcheddar(pCheddar);
                valoresPorPantallaPcheddar(pCheddar);
                var cant = (int)numericUpDownPapasFritasConCheddar.Value;
                pCheddar = gestionDetalle(cant, pCheddar);
            }

            if (numericUpDownPapasFritasPoomba.Value != 0)
            {
                gbGuarniciones.Visible = false;
                pPoomba = new Guarnicion();
                valoresHarcodeadosPpoomba(pPoomba);
                valoresPorPantallaPpoomba(pPoomba);
                var cant = (int)numericUpDownPapasFritasPoomba.Value;
                pPoomba = gestionDetalle(cant, pPoomba);
            }

            actualizarListaDetalle();
        }
        //*****************************BOTON AGREGAR BEBIDAS**********************************************
       private void btnAgregarBebidas_Click_1(object sender, EventArgs e)
        {
            /*if (numericUpDownGaseosa.Value != 0)
            {
                gbBebidas.Visible = false;
                gaseosa = new bebida();
                valoresHarcodeadosGaseosa(gaseosa);
                valoresPorPantallaGaseosa(gaseosa);
                var cant = (int)numericUpDownGaseosa.Value;
                gaseosa = gestionDetalle(cant, gaseosa);
            }

            if (numericUpDownAguaMineral.Value != 0)
            {
                gbBebidas.Visible = false;
                agua = new bebida();
                valoresHarcodeadosAgua(agua);
                valoresPorPantallaAgua(agua);
                var cant = (int)numericUpDownAguaMineral.Value;
                agua = gestionDetalle(cant, agua);
            }

            if (numericUpDownCerveza.Value != 0)
            {
                if (usuLogueado.Edad >= 18)
                {
                    gbBebidas.Visible = false;
                    cerveza = new bebida();
                    valoresHarcodeadosCerveza(cerveza);
                    valoresPorPantallaCerveza(cerveza);
                    var cant = (int)numericUpDownCerveza.Value;
                    cerveza = gestionDetalle(cant, cerveza);
                }
                else
                {
                    MessageBox.Show("Para comprar cerveza debe ser mayor de 18 años, por favor seleccione otra bebida");
                }
            }

            actualizarListaDetalle();
        }


        //*****************************BOTON AGREGAR POSTRES**********************************************
        private void btnAgregarPostres_Click(object sender, EventArgs e)
        {
            if (numericUpDownHelado.Value != 0)
            {
                gbPostres.Visible = false;
                helado = new Postre();
                valoresHarcodeadosHelado(helado);
                valoresPorPantallaHelado(helado);
                var cant = (int)numericUpDownHelado.Value;
                helado = gestionDetalle(cant, helado);
            }
            
            if (numericUpDownBudinDePan.Value != 0)
            {
                gbPostres.Visible = false;
                budin = new Postre();
                valoresHarcodeadosBudin(budin);
                valoresPorPantallaBudin(budin);
                var cant = (int)numericUpDownBudinDePan.Value;
                budin = gestionDetalle(cant, budin);
            }

            if (numericUpDownQueremosFlan.Value != 0)
            {
                gbPostres.Visible = false;
                flan = new Postre();
                valoresHarcodeadosFlan(flan);
                valoresPorPantallaFlan(flan);
                var cant = (int)numericUpDownQueremosFlan.Value;
                flan = gestionDetalle(cant, flan);
            }
           
            actualizarListaDetalle();
        }

        //*****************************METODO ACTUALIZAR LISTA DETALLE************************************

        public void actualizarListaDetalle()
        {
            List<string> listAux = new List<string>();
            foreach (var det in pedido.ListaDetalle)
            {
                listAux.Add(det.Item.Nombre + " " + "Cantidad: " + det.Cantidad + " " + "Subtotal: " + det.Subtotal);
            }
            listBoxPedido.DataSource = listAux;
            var total = pedido.sumaTotal(pedido);
            MessageBox.Show("Total: " + total);
            txtTotal.Text = total.ToString();
        }

        //************************************************************************************************
        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            GestionPago gp = new GestionPago(pedido, usuLogueado);
            gp.Show();
        }

        private void FormularioMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarPedido_Click_1(object sender, EventArgs e)
        {
            GestionPago gp = new GestionPago(pedido, usuLogueado);
            gp.Show();
        }

    }
}
    


