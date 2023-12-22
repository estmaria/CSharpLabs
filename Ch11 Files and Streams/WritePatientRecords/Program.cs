using System;
using static System.Console;
using System.IO;

/* 
   Author: Maria Esteban
   Date Modified: Nov 22 2023
   Description: allows a doctor’s staff to enter data about patients and saves the data to a file 
   called Patients.txt. The output should be in the following format: p#, PATIENT_NAME, BALANCE
*/

namespace WritePatientRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string id, name;
            int balance;
            
            FileStream outFile = new FileStream("Patients.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            

            Write("Enter patient ID number or 999 to quit >> ");
            id = ReadLine();

            while (id!="999")
            {

                Write("Enter last name >> ");
                name = ReadLine();

                bool validBalance = false;
                do
                {
                    Write("Enter balance >> ");
                    if (!int.TryParse(ReadLine(), out balance))
                    {
                        WriteLine("Error. Enter a valid balance.");
                    }
                    else
                    {
                        validBalance = true;
                    }
                } while (!validBalance);


                Patient patient = new Patient(id, name, balance);
                writer.WriteLine(patient.ToString());

                Write("Enter patient ID number or 999 to quit >> ");
                id = ReadLine();

            }
            
            writer.Close();
            outFile.Close();
            

            
            
        }
    }
}
