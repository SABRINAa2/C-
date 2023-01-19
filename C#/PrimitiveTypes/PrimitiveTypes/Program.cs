using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringVar = "Hello World!!";
            int intVar = 100;
            float floatVar = 10.2f;
            char charVar = 'A';
            bool boolVar = true;

            var firstName = "Sabrina Momotaz";
            var lastName = "Neha";
         

            Console.WriteLine(" First Name : " + firstName);
            Console.WriteLine("Last Name : " + lastName);
            Console.WriteLine("Full Name : ' + firstName + " " +lastName");
            Console.ReadLine();

            const float Pi = 3.1416f;
            var age = 22;
        }
    }
}
