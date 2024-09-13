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
    public partial class form2 : Form
    {

        double x, y,z;
        string[] op = { "+", "-", "*", "/" };
        public form2()
        {
            InitializeComponent();
            //comb.Items.Add("+");
            //comb.Items.Add("-");
            //comb.Items.Add("*");
            //comb.Items.Add("/");
            //comb.SelectedIndex = 0;
            comb.Items.Add(op);
            comb.SelectedIndex = 0;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = null;
        }
        private void sender_Load(object sender, EventArgs e)
        {
            //comb.Items.Add("+");
            //comb.Items.Add("-");
            //comb.Items.Add("*");
            //comb.Items.Add("/");
            //comb.SelectedIndex = 0;
            textBox3.ReadOnly = true;
            comb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        x = Convert.ToDouble(textBox1.Text);
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("تحذير", "الدد الاول غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        //        textBox1.Text = "";
        //        textBox1.Focus();
        //        return;
        //    }
        //    try
        //    {
        //        y = Convert.ToDouble(textBox2.Text);
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("تحذير", "الدد الثاني غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        //        textBox2.Text = "";
        //        textBox2.Focus();
        //        return;
        //    } bool f = true;
        //    switch (comb.SelectedIndex)
        //    {
        //        default: break;
        //        case 0: z = x + y; break;
        //        case 1: z = x - y; break;
        //        case 2: z = x * y; break;
        //        case 3: if (y != 0)
        //            {
        //                z = x / y;
        //                break;
        //            }
        //            else
        //            {
        //                MessageBox.Show("لا يمكن القسمه على صفر");
        //                f = false;
        //                textBox3.Text = null;
        //            }
        //            break;
        //    }
        //    if (f) ;
        //    textBox3.Text = z.ToString();
        //}

        private void comb_SelectedIndexChanged(object sender, EventArgs e)
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
            switch (comb.SelectedIndex)
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



