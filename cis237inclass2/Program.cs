using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for factorials or 2 for Tower of Hanoi.");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1" :
                    Factorial factorial = new Factorial();
                    break;

                case "2" :
                    Console.WriteLine("Enter number of disks on tower.  Try 5 or lower");
                    userInput = Console.ReadLine();
                    try
                    {
                        //DO Hanoi here
                        Hanoi hanoi = new Hanoi();
                        hanoi.MoveDisk(Convert.ToInt32(userInput), 'A', 'B', 'C');                        
                    }
                    catch
                    {
                        Console.WriteLine("You must Enter an int");
                    }

                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }            
        }
    }
}