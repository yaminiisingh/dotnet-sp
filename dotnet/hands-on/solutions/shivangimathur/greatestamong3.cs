﻿using System; // namespace - library file


    class MainClass
    {
        static void Main(string[] args)
        {
          int a;
          int b;
        int c;
        int large;
        Console.Write("Enter first number : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number : ");
        c = Convert.ToInt32(Console.ReadLine());
        if (a > b && a > c)
            large = a;
        else if (b > a && b > c)
            large = b;
        else
            large = c;
        Console.WriteLine("Lagest number is {0} ",large);
       
        }
    }

