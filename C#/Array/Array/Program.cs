using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "VOLBO", "FORD" };



            //Index change



            //Change index
            cars[2] = "Toyota";



            Console.WriteLine("After Update cars:" + cars[0] + " " + cars[1] + " " + cars[2]);






            int[] numbers = { 1, 2, 3 };



            // Console.WriteLine("Cars :" + cars[0] +" "+ cars[1]+" " + cars[2]);
            Console.WriteLine("Numbers : " + numbers[0] + " " + numbers[1] + " " + numbers[2]);








            //NON PRIMITIVE: STRING




            string firstName = "Alex";
            string lastName = "Doolean";



            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine("The full Name is :" + fullName);



            //Check index of a letter



            Console.WriteLine("The number of index of x is : " + firstName.IndexOf("x"));



            //Check letter of a index
            Console.WriteLine("The 3rd index value is : " + firstName[3]);





        }
    }

}
