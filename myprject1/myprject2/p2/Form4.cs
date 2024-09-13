using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p4
{
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int number3=1;
            textBox1.Focus();
             int number= int.Parse( textBox1.Text);
            for(int i=1;i<=number;i++)
              number3 += i;
            label2.Text = number3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int number3 = 1;
            textBox1.Focus();
            int number = int.Parse(textBox1.Text);
            for (int i = 1; i <= number; i++)
            number3 *= i;
            label3.Text = number3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number = int.Parse(textBox1.Text);
            double res = Math.Sqrt(number);
            label4.Text = res.ToString();
        }

    }
}
