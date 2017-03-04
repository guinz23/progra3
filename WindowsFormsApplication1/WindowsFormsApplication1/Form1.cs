using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (txtvalorUno.Text == "" && txtValorDos.Text == "")
            {
                MessageBox.Show("Por favor ingresar los valores correspodientes");
                return;
            }
            int uno = Convert.ToInt32(txtvalorUno.Text);
            int dos = Convert.ToInt32(txtValorDos.Text);
            calculadora c = new calculadora(uno, dos);
            if (rbresta.Checked == true)
            {
                txtResultado.Text = (Convert.ToString(c.resta()));
                return;
            }
            else if (rbSuma.Checked == true)
            {
                txtResultado.Text = (Convert.ToString(c.suma()));
                return;
            }
            else if (rbMultiplicacion.Checked==true)
            {
                txtResultado.Text = (Convert.ToString(c.multiplicacion()));
                return;
            }
           
        }
    }
}
