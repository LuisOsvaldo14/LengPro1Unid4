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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFibonacci hijoFibonacci = new FormFibonacci();
            hijoFibonacci.MdiParent = this;
            hijoFibonacci.Dock = DockStyle.Fill;
            hijoFibonacci.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConversor hijoConversor = new FormConversor();
            hijoConversor.MdiParent = this;
            hijoConversor.Dock = DockStyle.Fill;
            hijoConversor.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegistro hijoRegistro = new FormRegistro();
            hijoRegistro.MdiParent = this;
            hijoRegistro.Dock = DockStyle.Fill;
            hijoRegistro.Show();
        }
    }
}
