using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
   Author: Maria Esteban
   Date Modified: Oct 26 2023
   Description: a method that accepts and displays two parameters: a string name of a movie and an integer 
   running time in minutes. If not minutes are entered the default value is 90 minutes.
*/
namespace Movie
{
    class Program
    {
        public static void Movie (string name, int duration = 90)
        {
            WriteLine("Movie:{0}      Duration:{1} minutes", name, duration);
        }
        static void Main(string[] args)
        {
            Movie("Titanic", 194);
            Movie("Mamma Mia");
        }
    }
}
