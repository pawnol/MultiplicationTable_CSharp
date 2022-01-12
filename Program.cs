﻿/*
 * Multiplication Table
 * Pawelski
 * 1/11/2022
 * Read the code and run the program a few times to see what it does. 
 * Once you are familiar with the program, answer the questions found 
 * on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  |  0  1  2  3  4  5  6  7  8  9");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " |");
                for (int j = 0; j < 10; j++)
                {
                    int result = i * j;
                    Console.Write("{0, 3}", result);
                }
                Console.WriteLine();
            }
        }
    }
}
