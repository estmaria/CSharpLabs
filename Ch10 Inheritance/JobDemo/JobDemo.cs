using System;
using static System.Console;

/* 
   Author: Maria Esteban
   Date Modified: Nov 11 2023
   Description: the job class has five properties that include a job number, customer name, 
   job description, estimated hours, and price for the job. The JobDemo application declares
   a few Job objects, sets their values, and demonstrates that all the methods work as expected
*/

class JobDemo
{
   static void Main()
   {
      Job job1 = new Job(111, "Smith", "exterior paint", 20);
      Job job2 = new Job(222, "Vega", "gutter clean", 4);
      Job job3 = new Job(111, "Land", "blacktop drive", 10);
      WriteLine(job1.ToString());
      WriteLine(job2.ToString());
      WriteLine(job3.ToString());
      CompareNumbers(job1, job2);
      CompareNumbers(job1, job3);
   }
   internal static void CompareNumbers(Job job1, Job job2)
   {
       if(job1.Equals(job2))
         WriteLine("{0} for {1} has the same job " +
         "number as " + "{2} for {3}",
         job1.JobNumber, job1.Customer,
         job2.JobNumber, job2.Customer);
   }
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
   public int JobNumber {get; set;}
   public string Customer {get; set;}
   public string Description {get; set;}
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
