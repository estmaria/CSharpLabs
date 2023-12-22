using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
   Author: Maria Esteban
   Date Modified: Sept 26 2023
   Description: the user is prompt to guess a number between 1 and 11 and is critized for making a "dumb" guess
*/
namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int max = 11;
            int min = 1;
            int randNum = rand.Next(min, max);
            int guess=0;
            int count=0;
            int low = -1;
            int high = 100;
            Console.WriteLine("Your goal is to guess a number between {0} and {1}", min, max);
            while (guess != randNum)
            {
                Console.Write("Enter your guess:");
                guess = Convert.ToInt32(Console.ReadLine());
                count++;
                if (randNum == guess)
                {
                    Console.WriteLine("Your guess is correct");
                    break;
                }
                else if (randNum > guess)
                {
                    Console.WriteLine("Your guess is too low");
                    if (guess < low)
                        Console.WriteLine("and you alredy know it was more than {0}. Go higher!!!", low);
                    if (guess > low)
                        low = guess;
                }
                else
                {
                    Console.WriteLine("Your guess is too high");
                    if (guess > high)
                        Console.WriteLine("and you alredy knew it was less than {0}. Go lower!!!", high);
                    if (guess < high)
                        high = guess;
                }
                
            }
            if (count==1)
                Console.WriteLine("You got it in {0} guess", count);
            else
                Console.WriteLine("You got it in {0} guesses", count);
        }
    }
}
