// Kyle Zapalac, 18-Feb-2022, GAME-1343 (SP 2022)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5_LoopProblems_KZ
{
    class Program
    {
        // use main to call 3 functions that are solving problems
        static void Main(string[] args)
        {
            // call problem 1 function
            Console.WriteLine("================= PROBLEM #1 ====================\n");
            ProblemOne();

            // call problem 3 function
            Console.WriteLine("\n================= PROBLEM #3 ====================\n");
            ProblemThree();

            // call problem 5 function
            Console.WriteLine("\n================= PROBLEM #5 ====================\n");
            ProblemFive();

            // end output
            Console.WriteLine("\n=================================================\n");
        }

        // count how many numbers between 1 and 100 are divisible by 3 with no remainder, display count on console
        static void ProblemOne()
        {
            // declare variables
            int counter = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    counter++;
            }

            // print result (count of numbers divisible by 3)
            Console.WriteLine("There are " + counter + " numbers between 1 and 100 divisible by 3!");
        }

        // write a program to compute the factorial of a number that is entered by the user
        static void ProblemThree()
        {
            // declare variables
            int num = 0;
            int result = 1;

            // get a number from user
            Console.Write("Choose a number: ");
            num = int.Parse(Console.ReadLine());

            // multiple the number times all values between the number itself and 1
            for (int i = num; i > 0; i--)
            {
                result *= i;
            }

            // print result (number factorial)
            Console.WriteLine("The factorial of " + num + " is " + result + "!");
        }

        // write a program to find the maximum from a user provided list of numbers
        static void ProblemFive()
        {
            // declare variables
            string numList = "";
            int max = 0;

            // get series of numbers separated by comma from user
            Console.Write("Enter your series of numbers (separated by commas): ");
            numList = Console.ReadLine();

            // break string into array using comma as delimeter 
            string[] numArray = numList.Split(',');

            // repeat loop for each element of our numArray 
            foreach(string s in numArray)
            {
                // if current number being evaluated (s) is higher than max, set max equal to current number
                if ((int.Parse(s)) > max)
                    max = int.Parse(s);
            }

            // print result (max number from user list)
            Console.WriteLine("The highest number from your list is " + max + "!");
        }
    }
}

