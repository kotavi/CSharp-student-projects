﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            string myInput;
            int myInt;

        begin:

            Console.Write("Please enter a number between 1 and 3: ");
            myInput = Console.ReadLine();
            myInt = Int32.Parse(myInput);

            // switch with integer type
            switch (myInt)
            {
                case 1:
                    Console.WriteLine("Your number is {0}.", myInt);
                    break;
                case 2:
                    Console.WriteLine("Your number is {0}.", myInt);
                    break;
                case 3:
                    Console.WriteLine("Your number is {0}.", myInt);
                    break;
                default:
                    Console.WriteLine("Your number {0} is not between 1 and 3.", myInt);
                    break;
            }

        decide:

            Console.Write("Type \"continue\" to go on or \"quit\" to stop: ");
            myInput = Console.ReadLine();

            // switch with string type
            switch (myInput)
            {
                case "continue":
                    goto begin;
                case "quit":
                    Console.WriteLine("Bye.");
                    break;
                default:
                    Console.WriteLine("Your input {0} is incorrect.", myInput);
                    goto decide;
            }

        }
    }
}
