﻿using System;

namespace CountToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inout a number that you want me to count to");
            int n = int.Parse(Console.ReadLine());
            for (int c=0;c<=n;c++)
            Console.WriteLine(c);
        }
    }
}
