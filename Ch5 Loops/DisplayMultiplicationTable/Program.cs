using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   Author: Maria Esteban
   Date Modified: Sept 22 2023
   Description: displays a table of the products of every combination of two integers from 1 through 10
*/


namespace DisplayMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("     ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,5}",i);
            }
            //Console.WriteLine("\n");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,2}  |", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0,5}",i*j);
                }
                Console.WriteLine();
            }
        }
    }
}
