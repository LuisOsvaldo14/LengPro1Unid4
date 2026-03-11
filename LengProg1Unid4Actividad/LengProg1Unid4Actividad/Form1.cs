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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void caculadorFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFibonacci hijoFibonacci = new FormFibonacci();
            hijoFibonacci.MdiParent = this;
            hijoFibonacci.Show();
        }

        private void conversorDivisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConversor hijoConversor = new FormConversor();
            hijoConversor.MdiParent = this;
            hijoConversor.Show();

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistro hijoRegistro = new FormRegistro();
            hijoRegistro.MdiParent = this;
            hijoRegistro.Show();
        }
    }
}
