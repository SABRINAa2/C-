using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name :");

            string myName = Console.ReadLine();
            Console.WriteLine("You have entered your name  " + myName);
            Console.ReadLine();
            Console.WriteLine("Enter the value of x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the summation of x and y is : " + (x + y));
            Console.WriteLine(the subtraction of x and y is : " +(x-y));

            
            
            
            
            Console.ReadLine();
        }


    }
}
