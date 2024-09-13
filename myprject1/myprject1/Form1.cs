using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p3
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            
        }    
        //البرنامج الاول بي الدوال والاحداث  تبع المربعات
        private void button1_Click(object sender, EventArgs e)
           {
          if (textBox1.Text.Trim() == "")
          {
           MessageBox.Show  ("ادخل العدد االول");
            }
          else if (textBox2.Text.Trim() == "")
          {
              MessageBox.Show("ادخل العدد الثاني");
          }
          else
          {
              double x = Convert.ToDouble(textBox1.Text);
              double y = Convert.ToDouble(textBox2.Text);
              double z = x + y;
              textBox3.Text = z.ToString();
          }
        }       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) ;
            {
                if (e.KeyChar == '.' && textBox1.SelectionStart == 0 && !textBox1.Text.Contains('-'))
                {
                    return;
                }
                if (e.KeyChar == '.' && textBox1.Text.Contains('.'))
                {
                    return;
                }
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) ;
            {
                if (e.KeyChar == '.' && textBox2.SelectionStart == 0 && !textBox2.Text.Contains('-'))
                {
                    return;
                }
                if (e.KeyChar == '.' && textBox2.Text.Contains('.'))
                {
                    return;
                }
                e.Handled = true;
            }           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
