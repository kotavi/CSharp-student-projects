using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace if_and_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b) Console.WriteLine("a>b - if statement");

            if (a < b) Console.WriteLine("a<b - if statement");

            //(a>b)? Console.WriteLine("a>b - Ternary operator"):

            if (a > b)
            {
                a = a + 2;
                Console.WriteLine("\na>b - if-else statement");
            }
            else Console.WriteLine("\na<b - if-else statement");

           // Console.WriteLine(); instead of this line the \n operator is used

            // does not work
            // (a > b) ? Console.WriteLine("\na>b - Ternary operator") : Console.WriteLine("a<b - Ternary operator");


            //variant 1
            //string gt = "a>b - Ternary operator";
            //string lt = "a<b - Ternary operator";
            string result;
           // result = (a > b) ? gt : lt;
            //Console.WriteLine("\n{0}", result);
            
            //variant 2
            result = (a > b) ? "a>b - Ternary operator" : "a<b - Ternary operator";
            Console.WriteLine("\n{0}", result);
            check:
            Console.WriteLine("\nDo you want to continue? (Y/N)");
            string ans = Console.ReadLine();

            switch (ans)
            {
                case "Y":
                    goto start;
                    break;
                case "N":
                    goto end;
                    break;
                default:
                    Console.WriteLine("Enter Y to continue or N to quit!");
                    goto check;
                    break;
            }
            end:
            Console.WriteLine("Bye!!!");

            Console.ReadKey();

        }
    }
}
