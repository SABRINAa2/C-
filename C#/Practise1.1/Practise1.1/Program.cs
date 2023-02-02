using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a + 2;
            bool test = true;

            float f;//declaration variable
            f = 10.2f;//initialization
            float g = 11.5f;//declare and initialize

            double d = 10.5;
            string s = "Fahim";
            string m = "Rahman";
            Console.WriteLine("My Name is:"+s+" "+m);
            char c = 'b';
            int x = 3;

            //for using var type,we must initialize the value.
            var y = 4;
            var n=14;



            Console.WriteLine("the value of x:"+x+" is smallest number");

            Console.WriteLine("the value of f is:"+f) ;
            Console.WriteLine(g+"this is value of g:");




            Console.WriteLine(a+" "+b);
            Console.WriteLine(test);
            Console.ReadLine();

        }
    }
}
