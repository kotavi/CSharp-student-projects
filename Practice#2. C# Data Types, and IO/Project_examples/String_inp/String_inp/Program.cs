using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_inp
{
    class CSharp_For_Starters
    {
        static void Main(string[] args)
        {
            //1
            string strNumber;
            Console.Write("Enter any string: ");
            strNumber = Console.ReadLine();
            Console.WriteLine("Entered string: {0}", strNumber);
            Console.ReadKey();

            //2
            int k;
            string line;
            Console.Write("\nEnter any number: ");
            line = Console.ReadLine();
            Console.WriteLine("\nNumber as a string: {0}", line);
            Console.ReadKey();
            k = Int32.Parse(line);
            Console.WriteLine("\nNumber as an int: {0}", k);
            Console.ReadKey();
            Console.WriteLine("\nNumber as an int (k*k): {0}", k*k);


            Console.ReadKey();
        }
    }
}
