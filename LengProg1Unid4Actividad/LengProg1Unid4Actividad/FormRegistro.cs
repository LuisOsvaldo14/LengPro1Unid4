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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                textBox1.Text, 
                textBox2.Text, 
                textBox3.Text, 
                comboBox1.Text, 
                textBox4.Text,
                textBox5.Text,
                comboBox2.Text,
                textBox6.Text,
                textBox7.Text,
                comboBox3.Text,
                textBox8.Text,
                textBox9.Text
                );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); 
            textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
            textBox7.Clear(); textBox8.Clear(); textBox9.Clear();

            comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1; 
            comboBox3.SelectedIndex = -1;
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
