using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Factorial
    {
        public Factorial()
        {
            //Prompt the user for a number to compute
            Console.WriteLine("Input a number to calculate the factorial of:  ");

            try
            {
                //Get the number to perform factorial on from the user
                int factorialInt = Convert.ToInt32(Console.ReadLine());

                //Output what the problem to solve is.
                Console.WriteLine(Environment.NewLine + "Problem: " + factorialInt + "!");

                //Solve the problem and put it in an answerInt
                int answerInt = Calculate(factorialInt);
                Console.WriteLine(Environment.NewLine + "The answer is: " + answerInt + Environment.NewLine);
            }
            catch
            {
                Console.WriteLine("You did not enter a valid integer!");
            }
        }

        private int Calculate(int numberInt)     //Recursive method to calculate a factorial
        {
            if (numberInt == 1)
            {
                return 1;
                //Could also return number
            }

            //This is where recursion of method takes place, putting it in a loop without a while or for statement
            return numberInt * Calculate(numberInt - 1);        //This is a recursive call
        }
    }
}
