using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
   Author: Maria Esteban
   Date Modified: Oct 26 2023
   Description: includes two overloaded methods - one that accepts a meal price and a tip as doubles, and one that 
   accepts a meal price as a double and a tip amount as an integer. It displays meal price, the tip as a percentage 
   of the meal price, the tip in dollars, and the total of the meal plus the tip.
*/

namespace TipCalculation
{
    class Program
    {
        public static void CalcTip(double meal_price, double tip)
        {
            double tip_amount = tip * meal_price;
            WriteLine("Meal price: {0}", meal_price.ToString("C"));
            WriteLine("Tip percentege: {0}%", (tip*100).ToString("F"));
            WriteLine("Tip amount: {0}", tip_amount.ToString("C"));
            WriteLine("Total price: {0}", (meal_price+tip_amount).ToString("C"));
        }
        
        public static void CalcTip(double meal_price, int tip_amount)
        {
            double tip = tip_amount/meal_price;
            WriteLine("Meal price: {0}", meal_price.ToString("C"));
            WriteLine("Tip percentege: {0}%", (tip * 100).ToString("F"));
            WriteLine("Tip amount: {0}", tip_amount.ToString("C"));
            WriteLine("Total price: {0}", (meal_price + tip_amount).ToString("C"));
        }

        static void Main(string[] args)
        {
            CalcTip(20, 0.15);
            WriteLine();
            CalcTip(23, 4);
        }
    }
}