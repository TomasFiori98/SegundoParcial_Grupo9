using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2lab2_FioriTomas_CabanayMauro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_precio_Click(object sender, EventArgs e)
        {
            if (rbtmPantalon.Checked == false && rbtmCamisa.Checked == false)
            {
                MessageBox.Show("Debe llenar todas las casillas para calcular el precio final.", "ERROR");
            }

            if (rbtmCamisa.Checked == true)
            {
                try
                {
                    parcial2lab2_FioriTomas_CabanayMauro.Camisa c1 = new Camisa(Convert.ToDouble(txtPrecio.Text),
                                                                            Convert.ToInt32(txtCantidad.Text),
                                                                            rbtmPremium.Checked.Equals(true),
                                                                            cbxManga_corta.Checked.Equals(true));
                    if (rbtmCamisa.Checked == true)
                    {
                        MessageBox.Show("Precio final: " + c1.calcularPrecio(Convert.ToDouble(txtPrecio.Text),
                            Convert.ToInt32(txtCantidad.Text), rbtmPremium.Checked.Equals(true)), "PRECIO FINAL");
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Debe llenar todas las casillas para calcular el precio final.", "ERROR");
                }
            }
            
            if (rbtmPantalon.Checked == true)
            {
                try
                {
                    parcial2lab2_FioriTomas_CabanayMauro.Pantalon p1 = new Pantalon(Convert.ToDouble(txtPrecio.Text),
                                                                                Convert.ToInt32(txtCantidad.Text),
                                                                                rbtmPremium.Checked.Equals(true),
                                                                                cbxBermuda.Checked.Equals(true));
                    if (rbtmPantalon.Checked == true)
                    {
                        MessageBox.Show("Precio final: " + p1.calcularPrecio(Convert.ToDouble(txtPrecio.Text),
                            Convert.ToInt32(txtCantidad.Text), rbtmPremium.Checked.Equals(true)), "PRECIO FINAL");
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Debe llenar todas las casillas para calcular el precio final.", "ERROR");
                }
            }
            
        }

        private void rbtmCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtmCamisa.Checked == true)
            {
                cbxBermuda.Enabled = false;
                cbxManga_corta.Enabled = true;
            }
        }

        private void rbtmPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtmPantalon.Checked == true)
            {
                cbxBermuda.Enabled = true;
                cbxManga_corta.Enabled = false;
            }
        }

        private void cbxManga_corta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxBermuda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
