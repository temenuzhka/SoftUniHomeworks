﻿namespace _09.PrintSequence
{
    using System;
    using System.Linq;

    internal class PrintSequence
    {
        // 9.Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
        static void Main()
        {
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
