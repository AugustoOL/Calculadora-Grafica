using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbArea.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double area = Math.PI * Math.Pow(raio, 2);
                lbResultado.Text = "AREA =" + area.ToString("N3");
            }
            if (rbPerimetro.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double perimetro = 2 * Math.PI * raio;
                lbResultado.Text = "PERIMETRO = "
                    + perimetro.ToString("N3");
            }
            if (rbVolume.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double volume = 3f / 4f * Math.PI * Math.Pow(raio, 3);
                lbResultado.Text = "VOLUME =" + volume.ToString("N3");
            }
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
