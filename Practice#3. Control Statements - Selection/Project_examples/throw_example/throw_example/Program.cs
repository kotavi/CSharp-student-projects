using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace throw_example
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            if (s == null)
            {
                throw new ArgumentNullException();
            }

            Console.Write("The string s is null"); // not executed
        }
    }
}
