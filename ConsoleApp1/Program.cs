﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileStream file = new FileStream("data.txt", FileMode.OpenOrCreate))
            {
                Console.WriteLine("Created a file");
            }
                
        }
    }
}
