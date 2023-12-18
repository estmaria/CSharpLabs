using System;
using static System.Console;
/* 
   Author: Maria Esteban
   Date Modified: Sept 1 2023
   Description: gets the number of eggs produced in a month by four chickens and display the total in dozens and eggs
*/
class EggsInteractive
{
   static void Main()
   {
      const int DOZEN = 12;
      int total;
      int dozens, leftOver;
      string chicken1, chicken2, chicken3, chicken4;
      Write("Enter eggs for the first chicken >> ");
      chicken1 = ReadLine();
      Write("Enter eggs for the second chicken >> ");
      chicken2 = ReadLine();
      Write("Enter eggs for the third chicken >> ");
      chicken3 = ReadLine();
      Write("Enter eggs for the fourth chicken >> ");
      chicken4 = ReadLine();

      total = Convert.ToInt32(chicken1) + Convert.ToInt32(chicken2) + Convert.ToInt32(chicken3) + Convert.ToInt32(chicken4);
      dozens = total / DOZEN;
      leftOver = total % DOZEN;
      WriteLine("There are {0} eggs, which are {1} dozens and {2} eggs",
         total, dozens, leftOver);
   }
}