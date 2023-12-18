using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthNamesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Month
        {
            January= 1, February, March, April, May, June, July, August, September, October, November, December
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

  
            int number;
            Month month;
            number = Convert.ToInt32(textBox1.Text);
            if (number>=1 && number <= 12)
            {
                month = (Month)number;
                label2.Text = "You entered the value for "+month;
            }
            else
            {
                label2.Text = "You entered an invalid number. Try again.";
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

