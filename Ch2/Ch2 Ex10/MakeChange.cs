using System;
using static System.Console;
/* 
   Author: Maria Esteban
   Date Modified: Sept 1 2023
   Description: displays the conversion of an entered number of dollars to twenties, tens, fives, and ones
*/
class MakeChange
{
    static void Main()
    {
        string entry;
        int dollars, twenties, tens, fives, ones;
        Write("Enter amount of dollars >> ");
        entry = ReadLine();
        dollars = Convert.ToInt32(entry);
        twenties = dollars / 20;
        dollars %= 20;
        tens = dollars / 10;
        dollars %= 10;
        fives = dollars / 5;
        dollars %= 5;
        ones = dollars;
        WriteLine("${0} are {1} twenties, {2} tens, {3} fives and {4} ones", entry, twenties, tens, fives, ones);
    }
}