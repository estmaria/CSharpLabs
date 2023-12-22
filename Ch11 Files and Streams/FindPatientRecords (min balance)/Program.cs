using System;
using static System.Console;
using System.IO;
using System.Globalization;

/* 
   Author: Maria Esteban
   Date Modified: Nov 22 2023
   Description: it prompts the user for a minimum balance due, reads the file Patients.txt, and displays all 
   the records containing a balance greater than or equal to the entered value
*/

namespace FindPatientRecords__min_balance_
{
    class Program
    {
        static void Main(string[] args)
        {
            int patientBalance;
            bool validBalance = false;
            bool found = false;
            int count = 0;
            do
            {
                Write("Enter minimum balance to display >> ");
                if (!int.TryParse(ReadLine(), out patientBalance))
                {
                    WriteLine("Error. Enter a valid balance.");
                }
                else
                {
                    validBalance = true;
                }
            } while (!validBalance);
            
            
            Patient patient = new Patient();
            FileStream inFile = new FileStream("Patients.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn;
            string[] fields;

            recordIn = reader.ReadLine();
            while (recordIn != null)
            {
                fields = recordIn.Split(',');
                patient.ID = fields[0];
                patient.Name = fields[1];
                patient.Balance = Convert.ToInt32(fields[2]);
                if (patient.Balance>= patientBalance)
                {
                    if (count == 0)
                    {
                        WriteLine("\n{0,-13}{1,-22}{2,7}\n", "IdNumber", "Name", "Balance");
                        count++;
                        found = true;
                    }
                        

                    WriteLine("{0,-12}{1,-22}{2,8}",
                patient.ID, patient.Name, patient.Balance.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                }

                recordIn = reader.ReadLine();
            }
            if (!found)
                WriteLine("There are not patients with a balance greater or equal than {0}", patientBalance.ToString("C", CultureInfo.GetCultureInfo("en-US")));

            reader.Close();
            inFile.Close();
        }
    }
}
