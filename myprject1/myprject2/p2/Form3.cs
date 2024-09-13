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
    public partial class Form3 : Form
    {
        double x, y, z;
        string[] op = { "+", "-", "*", "/" };
        public Form3()
        {
            InitializeComponent();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = null;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            list.SelectionMode = SelectionMode.One;
            list.Items.AddRange(op);
            list.SelectedIndex = 0;
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformCalculation();
        }
        
        private void PerformCalculation()
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير", "العدد الأول غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }

            try
            {
                y = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير", "العدد الثاني غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox2.Text = "";
                textBox2.Focus();
                return;
            }

            bool f = true;
            switch (list.SelectedIndex)
            {
                case 0: z = x + y; break;
                case 1: z = x - y; break;
                case 2: z = x * y; break;
                case 3:
                    if (y != 0)
                    {
                        z = x / y;
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن القسمة على صفر");
                        f = false;
                        textBox3.Text = "";
                    }
                    break;
            }

            if (f)
            {
                textBox3.Text = z.ToString();
            }
        }

        
    }
}


