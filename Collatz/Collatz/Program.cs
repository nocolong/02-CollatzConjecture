using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentStep = 0;
            //Ask the user for a number
            Console.Write("Enter a number greater than 1:");
            //Get that # and store it in variable entry
            string entry = Console.ReadLine();

            //Parse will convert the number to an integer and store in variable number
            int number = int.Parse(entry);

            int largestStep = 0;
            int largestNumber = number;
            //This while loop runs until the result of a cycle equals 1. != means "not equal to"
            while (number != 1)
            {
               

                if(number > largestNumber)
                {
                    /*if the number given is larger than the largest number that has passed through the loop so far,
                    it's stored into largestNumber*/
                    largestNumber = number;
                    //currentStep iterator adds one every cycle and stores the total in largestStep
                    largestStep = currentStep;
                }

                //This parameter I found on google to check if number is even
                if (number % 2 == 0)
                {
                    //This takes the even number and divides by 2
                    number = number / 2;
                    Console.WriteLine(number);
                }
                else
                {
                    //If its odd, this block runs and multiplies by 3, adds 1
                    number = number * 3 + 1;
                    Console.WriteLine(number);
                }
                //Shorthand iterator to add 1 every loop cycle
                currentStep++;
            }
            //These 2 lines print results in the console
            Console.WriteLine("It takes " + currentStep + " steps to reach 1 from " + entry + ".");
            Console.WriteLine("The value reaches its peak of " + largestNumber + " at step " + largestStep + ".");
            //Added bc the program would automatically close without it
            Console.ReadLine();
        }
    }
}
