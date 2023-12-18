using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshallsRevenueProgram
{
    enum Month
    {
        JANUARY = 1, FEBRUARY, MARCH, APRIL,
        MAY, JUNE, JULY, AUGUST,
        SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
    }
    public partial class Form1 : Form
    {
        private const int INTWALLCOST = 500;
        private const int EXTWALLCOST = 750;
        private const int INTWALLPROMOCOST = 450;
        private const int EXTWALLPROMOCOST = 699;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateStatementButton_Click(object sender, EventArgs e)
        {
            //Error checking in the inputs
            if (!int.TryParse(intWallInputTextBox.Text, out int intWallNum))
            {
                statementLabel.ForeColor = Color.Red;
                statementLabel.Text = "Error: invalid number entered for interior walls";
                return;
            }

            if (!int.TryParse(extWallInputTextBox.Text, out int extWallNum))
            {
                statementLabel.ForeColor = Color.Red;
                statementLabel.Text = "Error: invalid number entered for exterior walls";
                return;
            }

            if (!int.TryParse(monthInputTextBox.Text, out int monthNum))
            {
                statementLabel.ForeColor = Color.Red;
                statementLabel.Text = "Error: invalid number entered for month number";
                return;
            }

            if (monthNum < 1 || monthNum > 12)
            {
                statementLabel.ForeColor = Color.Red;
                statementLabel.Text = "Error: month number out range";
                return;
            }

            statementLabel.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            statementLabel.Text = CalculateStatement(intWallNum, extWallNum, monthNum);
        }

        private static string CalculateStatement(int intNum, int extNum, int monthNum)
        {    
            string result;
            int total;

            if (monthNum == 12 || monthNum == 1 || monthNum == 2)
            {
                extNum = 0;
                total = intNum * INTWALLCOST;
            }
            else if (monthNum == 4 || monthNum == 5 || monthNum == 9 || monthNum == 10)
            {
                total = (intNum * INTWALLCOST) + (extNum * EXTWALLPROMOCOST);
            }
            else if (monthNum == 7 || monthNum == 8)
            {
                total = (intNum * INTWALLPROMOCOST) + (extNum * EXTWALLCOST);
            }
            else
            {
                total = (intNum * INTWALLCOST) + (extNum * EXTWALLCOST);
            }

            if (intNum > extNum)
            {
                result = $"The total revenue expected is {total:C0}\nThere will be more interior walls than exterior walls painted in {(Month) monthNum}.";
            }
            else if (intNum < extNum)
            {
                result = $"The total revenue expected is {total:C0}\nThere will be more exterior walls than interior walls painted in {(Month) monthNum}.";
            }
            else
            {
                result = $"The total revenue expected is {total:C0}\nThere will the same amount of interior walls and exterior walls painted in {(Month) monthNum}.";
            }

            return result;
        }
    }
}