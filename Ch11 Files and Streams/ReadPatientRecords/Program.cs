using System;
using static System.Console;
using System.IO;
using System.Globalization;

/* 
   Author: Maria Esteban
   Date Modified: Nov 22 2023
   Description: reads the file Patients.txt and displays each patient’s data on the screen
*/

namespace ReadPatientRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            FileStream inFile = new FileStream("Patients.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn;
            string[] fields;
            WriteLine("\n{0,-13}{1,-22}{2,7}\n",
            "IdNumber", "Name", "Balance");
            recordIn = reader.ReadLine();
            while (recordIn != null)
            {
                fields = recordIn.Split(',');
                patient.ID = fields[0];
                patient.Name = fields[1];
                patient.Balance = Convert.ToInt32(fields[2]);
                WriteLine("{0,-12}{1,-22}{2,8}",
                patient.ID, patient.Name, patient.Balance.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
        }
    }
}
