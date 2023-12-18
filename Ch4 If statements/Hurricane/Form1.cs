using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
   Author: Maria Esteban
   Date Modified: Sept 15 2023
   Description: classifies hurricanes into five categories numbered 1 through 5 based on the user’s input of the wind speed
*/

namespace Hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double windSpeed;
            string category;
            windSpeed = Convert.ToDouble(textBox1.Text);
            if (windSpeed >= 157)
                category = "is catergory 5";
            else if (windSpeed >= 130)
                category = "is catergory 4";
            else if (windSpeed >= 111)
                category = "is catergory 3";
            else if (windSpeed >= 96)
                category = "is catergory 2";
            else if (windSpeed >= 74)
                category = "is catergory 1";
            else
                category = "is not a hurricane";

            label2.Text = "This hurricane "+category;
        }
    }
}
