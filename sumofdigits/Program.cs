﻿using System;
class Exercise1
{
    static void Main(string[] args)
    {
        int n, sum;
        Console.Write("Input  a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum of the digits of the given number is: "+ sum);
        Console.ReadLine();
    }
}
