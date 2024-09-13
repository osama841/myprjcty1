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
    public partial class sender : Form
    {
        public sender()
        {
            InitializeComponent();
        }
        private void traingforsender(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                if (button.Text == "اخضر")
                    button4.BackColor = Color.Green;
                else if (button.Text == "احمر")
                    button4.BackColor = Color.Red;
                else if (sender == "اصفر")
                    button4.BackColor = Color.Yellow;
            }
            else if (sender is Label)
            {
                Label labl = (Label)sender;
                if (labl.Text == "جهاز1")
                    button4.Text = device1.Text;
                else if (labl.Text == "جهاز2")
                    button4.Text = device2.Text;
            }
        }

        private void sender_Load(object sender, EventArgs e)
        {
            butgren.Click += traingforsender;
            btnred.Click += traingforsender;
            btnyellow.Click += traingforsender;
            device1.Click += traingforsender;
            device2.Click += traingforsender;

        }
    }
}
