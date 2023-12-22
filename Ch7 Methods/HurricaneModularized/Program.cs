using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
   Author: Maria Esteban
   Date Modified: Oct 11 2023
   Description: prompts the uuser for the wind speed of the hurricane and classifies it into 
   five categories using the Saffir-Simpson Hurricane Scale
*/
namespace HurricaneModularized
{
    class Program
    {
        public static void CalcCategory(double windSpeed)
        {
            string category;
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

            WriteLine("This hurricane {0}", category);
        }
        static void Main(string[] args)
        {
            Write("Enter a wind speed in mph: ");
            CalcCategory(Convert.ToDouble(ReadLine()));
        }
    }
}
