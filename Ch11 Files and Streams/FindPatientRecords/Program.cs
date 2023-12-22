using System;
using static System.Console;
using System.IO;
using System.Globalization;

/* 
   Author: Maria Esteban
   Date Modified: Nov 22 2023
   Description: prompts the user for an ID number, reads records from Patients.txt, and displays
   data for the specified record. If the record does not exist it displays an error message
*/

namespace FindPatientRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            string patientID;
            bool found = false;
            Write("Enter patient ID number to find >> ");
            patientID = ReadLine();
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
                if (patient.ID.Equals(patientID))
                {
                    WriteLine("\n{0,-13}{1,-22}{2,7}\n", "IdNumber", "Name", "Balance");
                    WriteLine("{0,-12}{1,-22}{2,8}",
                patient.ID, patient.Name, patient.Balance.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    found = true;
                }
                
                recordIn = reader.ReadLine();
            }
            if (!found)
                WriteLine("No records found for patient ID number {0}", patientID);

            reader.Close();
            inFile.Close();
        }
    }
}
