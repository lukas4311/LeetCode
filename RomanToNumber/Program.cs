﻿using System;

namespace RomanToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roman to number!");
            Solution solution = new Solution();
            solution.RomanToInt("XXVII");
        }
    }
}
