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
        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            FormMenuPrincipal hijoprincipal = new FormMenuPrincipal();
            hijoprincipal.MdiParent = this;
            hijoprincipal.Dock = DockStyle.Fill;
            hijoprincipal.Show();

        }
    }
}
