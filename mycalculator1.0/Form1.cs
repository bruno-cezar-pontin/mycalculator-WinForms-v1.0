using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycalculator1._0
{
    public partial class Form1 : Form
    {
        int valor1;
        int valor2;
        int res;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToInt32(textBox1.Text);

            textBox1.Text = Convert.ToString(valor1 + valor2);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();

        }
    }
}
