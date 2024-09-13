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
    public partial class Form1 : Form
    {
        //sender f2 =new sender();
        Form3 f2 = new Form3();
        public Form1()
        {
            InitializeComponent();

        }
    
        private void fon(object sender, EventArgs e)
        {
            double number1, number2, number3;
            string operation1 = textopratitn1.Text;
            string operation2 = textopratitn2.Text;
            double intermediateResult = 0.0, finalResult = 0.0;
           int x = 0;

            if (double.TryParse(textnumber1.Text, out number1) &&
                double.TryParse(textnumber2.Text, out number2) &&
                double.TryParse(textnumber3.Text, out number3))
            {
                if (operation1 == "/" || operation1 == "*")
                {
                    intermediateResult = PerformOperation(number1, number2, operation1);
                    x = 1;
                }
                else
                   intermediateResult = PerformOperation(number2, number3, operation2);
        
                if (double.IsNaN(intermediateResult))
                {
                    MessageBox.Show("العملية  غير صحيحة");
                    if (x > 0)
                    {
                        textopratitn1.Focus();
                        textopratitn1.Clear();
                        return;
                    }
                    else
                    {
                        textopratitn2.Focus();
                        textopratitn2.Clear();
                        return;
                    }

                }
                if (x == 1) 
                  finalResult = PerformOperation(intermediateResult, number3, operation2);
                 else
                      finalResult = PerformOperation(intermediateResult, number1, operation1);

                if (double.IsNaN(finalResult))
                {
                    MessageBox.Show("العملية  غير صحيحة");
                    if (x > 0)
                    {
                        textopratitn2.Focus();
                        textopratitn2.Clear();
                        return;    
                    }
                    else
                    {
                        textopratitn1.Focus();
                        textopratitn1.Clear();
                        return;
                    }
                   
                }
                textresult.Text = finalResult.ToString();
                }
             
            }   
        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2, number3;
            string operation1 = textopratitn1.Text;
            string operation2 = textopratitn2.Text;
            string intertmediatersult = "";
            string finalResult = "";

            if (double.TryParse(textnumber1.Text, out number1) &&
                double.TryParse(textnumber2.Text, out number2) &&
                double.TryParse(textnumber3.Text, out number3))
            {

                if (intertmediatersult == "NaN")
                {
                    MessageBox.Show("العمليه الاولى غير صحيحه");
                    textopratitn1.Focus();
                    return;
                }

                if (finalResult == "NaN")
                {
                    MessageBox.Show("العمليه الثانيه غير صحيحه");
                    textopratitn2.Focus();
                    return;
                }

                textresult.Text = finalResult;
            }
            else
            {
                MessageBox.Show("يرجو ادخال ارقام صحيحه");
            }
        }

        private double PerformOperation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num2 != 0 ? num1 / num2 : double.NaN;
                default:
                    return double.NaN;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2.Show();   
        }

        private void textopratitn1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
            textopratitn2.TextChanged += fon;
            textnumber3.TextChanged += fon;
            textnumber1.TextChanged += fon;
            textopratitn1.TextChanged += fon;
            textnumber2.TextChanged += fon;

            textnumber1.KeyPress += inumber;
            textnumber2.KeyPress += inumber;
            textnumber3.KeyPress += inumber;
        }
        private void inumber(object sender,  KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void textopratitn2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ////textnumber1.Text = textnumber2.Text = textnumber3.Text =null && textopratitn1=textopratitn2 = null;
;        }
    }
}