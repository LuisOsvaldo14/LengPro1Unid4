using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LengProg1Unid4Actividad
{
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            double Cambio_A_Dollar = 0;
            double Monto_A_Cambiar = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            // Transforme todas las monedas al dólar para no tener que definir tantas condiciones.
            if (comboBox1.Text == "Peso dominicano")
            {
                Cambio_A_Dollar = Monto_A_Cambiar / 60.09;
            }
            else if (comboBox1.Text == "Euro")
            {
                Cambio_A_Dollar = Monto_A_Cambiar / 0.86;
            }
            else if (comboBox1.Text == "Dólar estadounidense")
            {
                Cambio_A_Dollar = Monto_A_Cambiar;
            }
            // Aquí se transforma el dólar a la moneda que escogiste.
            if (comboBox2.Text == "Peso dominicano")
            {
                textBox2.Text = (Cambio_A_Dollar * 60.09).ToString("N2", CultureInfo.InvariantCulture);
            }
            else if (comboBox2.Text == "Euro")
            {
                textBox2.Text = (Cambio_A_Dollar * 0.86).ToString("N2", CultureInfo.InvariantCulture);
            }
            else if (comboBox2.Text == "Dólar estadounidense")
            {
                textBox2.Text = (Cambio_A_Dollar).ToString("N2", CultureInfo.InvariantCulture);
            }
        }
    }
}
