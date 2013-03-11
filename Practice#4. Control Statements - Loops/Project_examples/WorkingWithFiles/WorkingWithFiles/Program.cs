using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dl = new DirectoryInfo("Data");
            dl.Create();//folder will be created in the same directory bin/Debug/Data
            StreamWriter sw = File.CreateText("Data\\Output.txt");
            
            Console.Write("\n Enter a and b: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a + b;

            sw.Write("\n {0} + {1} = {2} ", a, b, c);
            sw.Close();

            Console.ReadLine();

            //if (dl.Exists)
            //    dl.Delete(true);

            if (Directory.Exists("CopyOfData"))
                Directory.Delete("CopyOfData", true);
            Console.ReadLine();
            //Directory.CreateDirectory("CopyOfData");
            Directory.Move("Data", "CopyOfData");
            Console.ReadLine();
            Directory.CreateDirectory("Copy");
            //File.Create("Copy\\CopiedFile.txt");
            File.Copy("CopyOfData\\Output.txt", "Copy\\CopiedFile.txt");
            Console.ReadLine();
        }
    }
}
