﻿namespace ConsoleApplication.Basics.Exercises
{
    public class OddOrEvenChecker
    {
        public void Demo()
        {
            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;
            Console.WriteLine(remainder);

            num1 = 11;
            remainder = num1 % num2;
            Console.WriteLine(remainder);
        }
    }
}
