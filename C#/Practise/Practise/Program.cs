using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if - else statement
            int number = 10;
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }

            else
            {
                Console.WriteLine("The number is odd");
            }

            int age = 58;

            if (age <= 17)
            {
                Console.WriteLine("Kid");
            }
            else if (age >= 18 && age < 50)
            {
                Console.WriteLine("Young");
            }
            else { Console.WriteLine("Old"); }

            //conditional operator
        }
    }
}

