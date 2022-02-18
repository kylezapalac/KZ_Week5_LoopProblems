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

            // call problem 2 function
            Console.WriteLine("\n================= PROBLEM #2 ====================\n");
            ProblemTwo();

            // call problem 3 function
            Console.WriteLine("\n================= PROBLEM #3 ====================\n");
            ProblemThree();

            // call problem 4 function
            Console.WriteLine("\n================= PROBLEM #4 ====================\n");
            ProblemFour();

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

        // write a program that asks a user to enter numbers, then ok to exit, and print the sum of the entered numbers
        static void ProblemTwo()
        {
            // declare variables
            int sum = 0;
            string exitCheck = "";

            // repeat loop until user enters 'OK'
            while(exitCheck != "OK")
            {
                // get a number from user
                Console.Write("Enter number or 'OK' to exit: ");
                exitCheck = Console.ReadLine();
                
                // if exit condition has not been met, add latest number to sum
                if (exitCheck != "OK")
                    sum += int.Parse(exitCheck);
            }

            // print result (sum of entered numbers)
            Console.WriteLine("The sum of entered numbers is: " + sum);
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

        // write a program that picks a random number between 1 and 10. Give user 4 chances to guess or they lose
        static void ProblemFour()
        {
            // declare variables
            int num = 0;
            int guess = 0;
            int guessCount = 1; // first guess is guessCount 1
            int answer = -1;

            // create random object
            Random random = new Random();

            // use random object to generate random number between 1 and 10
            answer  = random.Next(1, 10);

            // uncomment the following line for testing purposes
            // Console.WriteLine(answer);

            // while guess is not equal to answer, and guess limit not exceeded, repeat loop
            do
            {
                // collect guess
                Console.Write("Guess a number between 1 and 10: ");
                guess = int.Parse(Console.ReadLine());

                
                // if guess = answer, congratulate user, otherwise tell them to try again
                if (guess == answer)
                    Console.WriteLine("You won!");
                else if (guessCount < 4) // check if guess count limit reached, try again if not
                    Console.WriteLine("Try again!");
                else // check if guess count limit reached, user loses if so
                    Console.WriteLine("You lost!");
             
                // increment counter for # of next guess
                guessCount++;

            } while (guess != answer && guessCount <= 4);

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

