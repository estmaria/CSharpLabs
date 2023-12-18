using System;
using static System.Console;
/* 
   Author: Maria Esteban
   Date Modified: Sept 1 2023
   Description: converts inches to centimeters
*/
class InchesToCentimeterslnteractive
{
    static void Main()
    {
        string entry;
        double enteredInches, centimeters;
        Write("Enter inches >> ");
        entry = ReadLine();
        enteredInches = Convert.ToDouble(entry);
        centimeters = enteredInches * 2.54;
        WriteLine("{0} inches are {1} centimeters", enteredInches, centimeters);
    }
}

