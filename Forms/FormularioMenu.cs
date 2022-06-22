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
        public FormularioMenu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Hamburguesas_Click(object sender, EventArgs e)
        {
            if (groupBox5.Visible == true)
                groupBox5.Visible =false;
             


            //var hamburg1 = new Hamburguesa();
            //var pp = hamburg1.Codigo;
            groupBox6.Visible = true;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormularioMenu_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            //groupBox2.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = true;

        }
    }
}
