using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengProg1Unid4Actividad
{
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Limite = Double.Parse(textBox1.Text);
            Double Numero1 = 0;
            Double Numero2 = 1;
            Double ValorAnterior = 0;

            while (ValorAnterior <= Limite)
            {
                listBox1.Items.Add(ValorAnterior);
                Numero1 = ValorAnterior;
                ValorAnterior = Numero2;
                Numero2 = Numero1 + Numero2;
            }




        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal hijoprincipal = new FormMenuPrincipal();
            hijoprincipal.MdiParent = this.MdiParent;
            hijoprincipal.Dock = DockStyle.Fill;
            hijoprincipal.Show();
            this.Close();
        }
    }
}
