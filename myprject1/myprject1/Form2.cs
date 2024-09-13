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
    public partial class Form2 : Form
    {
        //keyprass    الداله  هاذي  برمجين تعمل كمثل     
          public static string all(string input)  
        {
            string result= "";
            foreach (char c in input)
            { 
                if (char.IsDigit(c))
                {
                    result += c;
                }
                else if (c == '+')
                {
                    result += c;
                }
                else if (c == '.')
                {
                    result += c;
                }
            }
            return result;
          }
        public Form2()
        {
            InitializeComponent();
        }     
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.TextChanged += textBox2_TextChanged;

            button1.Enabled = button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled= false;
            textBox3.ReadOnly = false;
            this.Text = " الة حاسبة بسيطة ";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //  هنا تم استدعاء الداله
            string s = all(textBox1.Text);
            textBox1.SelectionStart = textBox1.Text.Length;
            if (textBox1.Text != s)
            {
                textBox1.Text = s;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string x = all(textBox2.Text);
            textBox2.SelectionStart = textBox2.Text.Length;
            if (textBox2.Text != x)
            {
                textBox2.Text = x;
            }

            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    button1.Enabled = button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;

                }
            }
        }
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
              ;
              textBox3.BackColor = Color.SaddleBrown;
          }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ادخل العدد االول");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("ادخل العدد الثاني");
            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = x * y;
                textBox3.Text = z.ToString();
                ;
                textBox3.BackColor = Color.Red;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ادخل العدد االول");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("ادخل العدد الثاني");
            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = x / y;
                textBox3.Text = z.ToString();
                textBox3.BackColor = Color.Red;
               }
            }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ادخل العدد االول");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("ادخل العدد الثاني");
            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = x - y;
                textBox3.Text = z.ToString();
                textBox3.BackColor = Color.Red;
            }
        }
        }
      }
        

    


