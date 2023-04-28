using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_Programa_Calorias
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCaloria_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttEnvio_Click(object sender, EventArgs e)
        {
            string lanche = " ";
            string bebida = " ";
            string acomp = " ";
            int calorias = 0;

            if (rbtHotdog.Checked)
            {
                lanche = rbtHotdog.Text;
                calorias += 150;
            }
            else if (rbtMistoquente.Checked)
            {
                lanche = rbtMistoquente.Text;
                calorias += 180;
            }
            else if (rbtXsalada.Checked)
            {
                lanche = rbtXsalada.Text;
                calorias += 180;
            }
            else if (rbtXbacon.Checked)
            {
                lanche = rbtXbacon.Text;
                calorias += 180;
            }
            else
            {
                lanche = rbtXburger.Text;
                calorias += 160;
            }
            if (rbtSuco.Checked)
            {
                bebida = rbtSuco.Text;
                calorias += 60;
            }
            else if (rbtAgua.Checked)
            {
                bebida = rbtAgua.Text;
                calorias += 0;
            }
            else if (rbtChopp.Checked) 
            {
                bebida = rbtChopp.Text;
                calorias += 90;
            }
            else if (rbtRefri.Checked)
            {
                bebida = rbtRefri.Text;
                calorias += 80;
            }
            else
            {
                bebida = rbtCerveja.Text;
                calorias += 120;
            }
             
            if (rbtBatata.Checked)
            {
                acomp = rbtBatata.Text;
                calorias += 170;
            }
            else if (rbtProvolone.Checked)
            {
                acomp = rbtProvolone.Text;
                calorias += 220;
            }
            else if (rbtMandioca.Checked)
            {
                acomp = rbtMandioca.Text;
                calorias += 190;
            }
            else if (rbtPolenta.Checked)
            {
                acomp = rbtPolenta.Text;
                calorias += 160;
            }
            else
            {
                acomp = rbtSalada.Text;
                calorias += 30;
            }
            txtPedido.Text = string.Format("Lanche: {0}. Bebida: {1}. " +
                "Acompanhamento : {2}.", lanche, bebida, acomp);
            txtCaloria.Text = string.Format("{0} kcal", calorias);
        }

        private void rbtXbacon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
