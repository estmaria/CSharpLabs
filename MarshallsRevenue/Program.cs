using System;
using System.Linq;
using static System.Console;

/*This program prompts a user for the number of interior and exterior murals 
 * scheduled to be painted during a month and computes the expected revenue for each type of mural.
 * 
 * @author - Kamal Yusuf, Sanders Tshinyama and Maria Esteban
 * @version - 1.7 (10-09-23)
 * @since - 09-20-23
 */

enum Month
{
    JANUARY = 1, FEBRUARY, MARCH, APRIL,
    MAY, JUNE, JULY, AUGUST,
    SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
}

enum STYLE
{
    LANDSCAPE = 'L', SEASCAPE = 'S', ABSTRACT = 'A', CHILDRENS = 'C', OTHER = 'O'
}

public class ConsoleApp
{
    private const int INTWALLCOST = 500;
    private const int EXTWALLCOST = 750;
    private const int INTWALLPROMOCOST = 450;
    private const int EXTWALLPROMOCOST = 699;

    private static string[][] intWallData; // contains both the names and codes for interior murals
    private static string[][] extWallData; // contains both the names and codes for exterior murals

    private static readonly string[] AVAILABLECODES = { "L", "S", "A", "C", "O" };

    public static void Main()
    {
        //Error checking in the inputs
        int intWallNum = GetNumMurals("Number of interior wall mural(0 - 30): ");
        int extWallNum = GetNumMurals("Number of exterior wall mural(0 - 30): ");
        int monthNum = GetMonth();

        intWallData = DataEntry(intWallNum, "Names of customers for each interior walls (put a comma between each): ");
        extWallData = DataEntry(extWallNum, "Names of customers for each exterior walls (put a comma between each): ");

        int result = CalculateStatement(intWallNum, extWallNum, monthNum);
        WriteLine($"The total revenue expected is {result:C0}");

        string inputCode;
        do
        {
            Write("Enter a mural code to display jobs (enter q to quit): ");
            inputCode = ReadLine().ToUpper();

            if (!AVAILABLECODES.Contains(inputCode) && inputCode != "Q") // checking if the entered code is valid or the sentinal value
            {
                WriteLine("Error: Invalid code entered");
                continue;
            }

            if (inputCode == "Q")
                break;

            GetSelectedMurals(inputCode);

        }
        while (inputCode != "Q");

    }

    private static string[][] DataEntry(int numCustomer, string prompt)
    {
        string[][] result = new string[2][];
        Write(prompt);

        result[0] = ReadLine().Split(','); // seperates the input where there is a comma and store each element in an array

        while (result[0].Length != numCustomer)
        {
            WriteLine("Error: You've got to enter a customer name for each mural");
            Write(prompt);
            result[0] = ReadLine().Split(',');
        }

        result[1] = new string[result[0].Length]; // initializing the array containing mural codes

        for (int i = 0; i < result[1].Length; ++i)
        {
            bool valid;
            string code;
            do
            {
                Write($"Mural style for {result[0][i]}: ");
                code = ReadLine().ToUpper();

                valid = AVAILABLECODES.Contains(code);

                if (!valid)
                    WriteLine("Error: invalid style entered");
            }
            while (!valid);

            result[1][i] = code; // appends code to the murals codes array
        }

        return result;
    }

    private static void GetSelectedMurals(string code)
    {
        bool isEmpty = true;
        char[] chars = code.ToCharArray(); // turns the code into an array of characters

        WriteLine($"{code} ({(STYLE)chars[0]}):"); // {(STYLE) chars[0]} converts the first char of the code string into a STYLE

        int maxValue = Math.Max(intWallData[0].Length, extWallData[0].Length);

        for (int i = 0; i < maxValue; i++)
        {
            if (i < intWallData[0].Length) // makes sure that the index does not go out of bounds
            {
                if (intWallData[1][i] == code)
                {
                    isEmpty = false;
                    WriteLine($"{intWallData[0][i]} - interior mural");
                }
            }

            if (i < extWallData[0].Length)  // makes sure that the index does not go out of bounds
            {
                if (extWallData[1][i] == code)
                {
                    isEmpty = false;
                    WriteLine($"{extWallData[0][i]} - exterior mural");
                }
            }
        }

        if (isEmpty)
            WriteLine($"There is no job with the code {code} ({(STYLE)chars[0]})."); // {(STYLE) chars[0]} converts the first char of the code string into a STYLE
    }

    private static int GetMonth()
    {
        int monthNum;
        bool valid, outOfRange;
        do
        {
            Write("Month number (1 - 12): ");
            valid = int.TryParse(ReadLine(), out monthNum);
            outOfRange = monthNum < 1 || monthNum > 12;

            if (!valid)
            {
                WriteLine("Error: Invalid number entered");
            }

            if (outOfRange)
            {
                WriteLine("Error: Number of out range");
            }
        }
        while (outOfRange || !valid);

        return monthNum;
    }

    private static int GetNumMurals(string prompt)
    {
        int numMurals;
        bool valid, outOfRange;

        do
        {
            Write(prompt);
            valid = int.TryParse(ReadLine(), out numMurals);
            outOfRange = numMurals < 0 || numMurals > 30;

            if (!valid)
            {
                WriteLine("Error: Invalid number entered");
            }

            if (outOfRange)
            {
                WriteLine("Error: Number of out range");
            }
        }
        while (outOfRange || !valid);

        return numMurals;
    }

    private static int CalculateStatement(int intNum, int extNum, int monthNum)
    {
        int intTotal;
        int extTotal;
        int total;

        if (monthNum == 12 || monthNum == 1 || monthNum == 2)
        {
            extNum = 0;
            extTotal = extNum * EXTWALLCOST;
            intTotal = intNum * INTWALLCOST;
        }
        else if (monthNum == 4 || monthNum == 5 || monthNum == 9 || monthNum == 10)
        {
            extTotal = extNum * EXTWALLPROMOCOST;
            intTotal = intNum * INTWALLCOST;
        }
        else if (monthNum == 7 || monthNum == 8)
        {
            intTotal = intNum * INTWALLPROMOCOST;
            extTotal = extNum * EXTWALLCOST;
        }
        else
        {
            intTotal = intNum * INTWALLCOST;
            extTotal = extNum * EXTWALLCOST;
        }

        WriteLine($"Interior wall revenue: {intTotal:C0}" +
            $"\nExterior wall revenue: {extTotal:C0}");
        total = extTotal + intTotal;

        return total;
    }
}
