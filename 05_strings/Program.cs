using System;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);


            string firstName = "Jenn";
            string lastName = "Williams";

            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);

            //result: Her name is Jenn Williams.



            string firstName = "Robin";
            string lastName = "Holler";
            //1                 //2
            Console.WriteLine($"Her name is {firstName} {lastName}");
        }
    }
}
