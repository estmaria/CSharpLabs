using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* 
   Author: Maria Esteban
   Date Modified: Sept 22 2023
   Description: a random number between 1 and 100 is generated and the user is prompt to enter values until the correct 
   guess is made displaying if tehir guess was too high or too low. Then, it displays how many guesses it took
*/

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumber = new Random();
            int randNum, userNum;
            int count = 0;
            randNum = ranNumber.Next(1,100);
            WriteLine("Welcome to the guessing game! You will have to guess a number between 1 and 100.");
            while (true)
            {
                count++;
                Write("Enter your guess:");
                userNum = Convert.ToInt32(ReadLine());
                if (userNum < randNum)
                    WriteLine("Your guess is too low. Try again!");
                else if (userNum > randNum)
                    WriteLine("Your guess is too high. Try again!");
                else
                {
                    WriteLine("Congratulations, your guess is right! It took you {0} guesses", count);
                    break;
                }

            }
        }
    }
}
