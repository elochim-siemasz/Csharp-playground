﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static public int Add(params int[] arg)
        {
            int sum = 0;
            foreach (int i in arg)
            {
                sum += i;
            }
            return sum;
        }
        
        static void Main(string[] args)
        {
            int before = 3;
            int after = before;
            int[] lol = new int[] { 5, 6 };


            Console.WriteLine("before: {0}, after: {1}", before, after);
            after++;
            Console.WriteLine("before: {0}, after: {1}", before, after);

            

            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
