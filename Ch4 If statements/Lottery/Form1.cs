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
   Description: generates three numbers between 1 and 4 and lets the user guess them. 
   Then it compares the numbers and assigns a prize depending on how many matches there are
*/

namespace Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userNum1, userNum2, userNum3, randNum1, randNum2, randNum3, prize;
            Random rnd = new Random();
            randNum1 = rnd.Next(1, 5);
            randNum2 = rnd.Next(1, 5);
            randNum3 = rnd.Next(1, 5);
            userNum1 = Convert.ToInt32(textBox1.Text);
            userNum2 = Convert.ToInt32(textBox2.Text);
            userNum3 = Convert.ToInt32(textBox3.Text);



            int matches = 0;

            if (userNum1 == randNum1)
            {
                matches = 1;
                if (userNum2 == randNum2)
                {
                    matches = 2;
                    if (userNum3 == randNum3)
                        matches = 3;
                }
                else if (userNum2 == randNum3)
                    matches = 2;
                if (userNum3 == randNum2)
                    matches = 3;
            }

            else if (userNum1 == randNum2)
            {
                matches = 1;
                if (userNum2 == randNum1)
                {
                    matches = 2;
                    if (userNum3 == randNum3)
                        matches = 3;
                }
                else if (userNum2 == randNum3)
                    matches = 2;
                    if (userNum3 == randNum1)
                        matches = 3;
            }

            else if (userNum1 == randNum3) {
                matches = 1;
                if (userNum2 == randNum1)
                {
                    matches = 2;
                    if (userNum3 == randNum2)
                        matches = 3;
                }
                else if (userNum3 == randNum1)
                    matches = 2;
                    if (userNum2 == randNum2)
                        matches = 3;
            }


            else if (userNum2 == randNum1) { 
                matches = 1;
                if (userNum1 == randNum2)
                {
                    matches = 2;
                    if (userNum3 == randNum3)
                        matches = 3;
                }
                else if (userNum1 == randNum3)
                    matches = 2;
                    if (userNum3 == randNum2)
                        matches = 3;
            }

            else if (userNum2 == randNum2) { 
                matches = 1;
                if (userNum1 == randNum1)
                {
                    matches = 2;
                    if (userNum3 == randNum3)
                        matches = 3;
                }
                else if (userNum1 == randNum3)
                    matches = 2;
                    if (userNum3==randNum1)
                            matches = 3;
            }

            else if (userNum2 == randNum3) 
            { 
                matches = 1;
                if (userNum1 == randNum1)
                {
                    matches = 2;
                    if (userNum3 == randNum2)
                        matches = 3;
                }
                else if (userNum3 == randNum1)
                    matches = 2;
                    if (userNum1 == randNum2)
                        matches = 3;
            }

            
            else if (userNum3 == randNum1) { 
                matches = 1;
                if (userNum1 == randNum2)
                {
                    matches = 2;
                    if (userNum2 == randNum3)
                        matches = 3;
                }
                else if (userNum1 == randNum3)
                    matches = 2;
                    if (userNum2 == randNum2)
                        matches = 3;
            }

            else if (userNum3 == randNum2) { 
                matches = 1;
                if (userNum1 == randNum1)
                {
                    matches = 2;
                    if (userNum2 == randNum3)
                        matches = 3;
                }
                else if (userNum1 == randNum3)
                    matches = 2;
                    if (userNum2==randNum1)
                            matches = 3;
            }

            else if (userNum3 == randNum3) { 
                matches = 1;
                if (userNum1 == randNum1)
                {
                    matches = 2;
                    if (userNum2 == randNum2)
                        matches = 3;
                }
                else if (userNum1 == randNum2)
                    matches = 2;
                    if (userNum2 == randNum1)
                        matches = 3;
            }



              
            

           
           
           
            switch (matches)
            {
                case 1:
                    prize = 10;
                    break;
                case 2:
                    prize = 100;
                    break;
                case 3:
                    if (userNum1 == randNum1 && userNum2 == randNum2 && userNum3 == randNum3)
                        prize = 10000;
                    else
                        prize = 1000;
                    break;
                default:
                    prize = 0;
                    break;
            }

            label4.Text = "The random numbers are " + randNum1 + ", " + randNum2 + " and " + randNum3;
            label5.Text= "You guessed " + userNum1 + ", " + userNum2 + " and " + userNum3;
            label6.Text = "You won $" + prize;
        }
    }
}
