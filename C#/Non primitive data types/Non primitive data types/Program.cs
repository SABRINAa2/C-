using Non_primitive_data_types;
using Non_primitive_data_types.Gender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_primitive_data_types
{
    public class Student
    {

        public int Id;
        public string Name;
        public int Age;

        public void Identity()
        {

            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.ReadLine();

        }
    }

internal class Program
    {
        static void Main(string[] args)
        {
            Student Female = new Student();
            Female.Id =  44817;
            Female.Name = "Neha";
            Female.Age = 21;
            Female.Identity();

            Non_primitive_data_types.Gender.University.add


    }
}
