﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp185
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.Write("Array intArray contain:");
            DisplayArray(intArray);
            Console.Write("Array doubleArray contain:");
            DisplayArray(doubleArray);
            Console.Write("Array charArray contain:");
            DisplayArray(charArray);

        }

        private static void DisplayArray(int[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine();
        }
        private static void DisplayArray(double[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine();
        }
        private static void DisplayArray(char[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
