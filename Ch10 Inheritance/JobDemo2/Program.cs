using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
   Author: Maria Esteban
   Date Modified: Nov 11 2023
   Description: creates an array of five Job objects and prompts the user for values for each Job. It does not allow duplicate 
   job numbers. When five valid objects have been entered, display them all, plus a total of all prices.
*/
namespace JobDemo2
{
    class Program
    {
        static bool CheckReapeated(Job[] jobs, int n, int num)
        {
            for (int i = 0; i < n; i++)
            {
                if (jobs[i].JobNumber == num)
                    return true;
            }
            return false;
        }

        static double CalcTotal(Job[] jobs)
        {
            double total = 0;
            for(int i=0; i<jobs.Length; i++)
            {
                total += jobs[i].Price;
            }
            return total;
        }

        static void Main(string[] args)
        {
            Job[] jobs = new Job[5];
            for (int i=0; i<jobs.Length; i++)
            {
                Write("Enter customer name: ");
                string cust = ReadLine();
                Write("Enter job decription: ");
                string desc = ReadLine();
                Write("Enter estimated hours for job: ");
                double hrs = Convert.ToDouble(ReadLine());
                Write("Enter job number: ");
                int num = Convert.ToInt32(ReadLine());
                if (!(CheckReapeated(jobs, i, num)))
                {
                    jobs[i] = new Job(num, cust, desc, hrs);
                }
                else
                {
                    WriteLine("The job number is repeated. Enter another job please.");
                }
                WriteLine();
            }
            WriteLine("Sumary:");
            WriteLine();
            for (int i=0; i< jobs.Length; i++)
            {
                WriteLine(jobs[i].ToString());
            }
            WriteLine();
            WriteLine("Total for all jobs is {0}", CalcTotal(jobs).ToString("C"));

        }

        class Job
        {
            private double hours;
            private double price;
            public const double RATE = 45.00;
            public Job(int num, string cust, string desc, double hrs)
            {
                JobNumber = num;
                Customer = cust;
                Description = desc;
                Hours = hrs;
            }
            public int JobNumber { get; set; }
            public string Customer { get; set; }
            public string Description { get; set; }
            public double Hours
            {
                get
                {
                    return hours;
                }
                set
                {
                    hours = value;
                    price = hours * RATE;
                }
            }
            public double Price
            {
                get
                {
                    return price;
                }
            }

            public override int GetHashCode()
            {
                return JobNumber;
            }

            public override bool Equals(object obj)
            {
                Job otherJob = (Job)obj;
                return this.JobNumber == otherJob.JobNumber;
            }

            public override string ToString()
            {
                return $"Job " + this.JobNumber + " " + this.Customer + " " + this.Description + " " + this.Hours
                    + " hours @" + RATE.ToString("C") + " per hour. Total price is " + price.ToString("C"); 
            }
        }
    }
}
