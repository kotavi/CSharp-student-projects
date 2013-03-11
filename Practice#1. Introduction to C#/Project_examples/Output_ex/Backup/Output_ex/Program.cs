using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Output_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PART 1.--------------------------------------------");

            Console.WriteLine("1. What is your name?");
            Console.WriteLine("- My name is Peter");
            Console.WriteLine("2. How old are you?");
            Console.WriteLine("- I am 23");
            Console.WriteLine("3. Where are you from?");
            Console.WriteLine("- I am from UK");
            Console.WriteLine("4. What school did you graduate from?");
            Console.WriteLine("- I graduated from...");

            Console.WriteLine();

            Console.WriteLine("PART 2.--------------------------------------------");
           
            string name = "Peter";
            int old = 23;
            var from = "Ukraine, Crimea";

            Console.WriteLine("1. What is your name?");
            Console.WriteLine("- My name is {0}", name);
            Console.WriteLine("2. How old are you?");
            Console.WriteLine("- I am {0}", old);
            Console.WriteLine("3. Where are you from?");
            Console.WriteLine("- I am from {0}", from);
            Console.WriteLine("4. What school did you graduate from?");
            Console.WriteLine("- I graduated from...");

            Console.ReadLine();
      
        }
    }
}
