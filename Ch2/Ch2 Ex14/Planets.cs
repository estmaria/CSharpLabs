using System;
using static System.Console;
/* 
   Author: Maria Esteban
   Date Modified: Sept 1 2023
   Description: prompts the user for a numeric position and display the name of the planet that is in the requested position
*/
class Planets
{
    enum Planet
    {
        MERCURY = 1, VENUS, EARTH, MARS,
        JUPITER, SATURN, URANUS, NEPTUNE
    }
    static void Main()
    {
        Write("Enter a number>> ");
        string entry;
        int number;
        Planet planet;
        entry = ReadLine();
        number = Convert.ToInt32(entry);
        planet = (Planet)number;

        WriteLine("The planet number {0} is {1}", number, planet);
    }
}

