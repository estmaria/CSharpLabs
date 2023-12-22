using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
   Author: Maria Esteban
   Date Modified: Oct 11 2023
   Description:  prompts a user for length and width of a room in feet and calculates how much would it cost to paint that room
*/


namespace PaintingEstimate
{
    class Program
    {
        public static double CalcPrice(double width, double length)
        {
            const int HEIGHT= 9;
            const int PRICE_PER_SQUARE_FOOT = 6;
            return PRICE_PER_SQUARE_FOOT*(2*length*HEIGHT+2*width*HEIGHT);
        }
        static void Main(string[] args)
        {
            Write("Enter width in feet: ");
            double width = Convert.ToInt32(ReadLine());
            Write("Enter length in feet: ");
            double length = Convert.ToInt32(ReadLine());
            WriteLine("The total pricce for this room is {0}", (CalcPrice(length, width)).ToString("C"));
        }
    }
}
