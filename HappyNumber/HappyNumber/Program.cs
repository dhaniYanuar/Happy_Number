using System;
using System.Collections.Generic;

namespace HappyNumber
{
    class Program
    {
        public static int GetNextNumber(int num)
        {
            int totalSum = 0;
            while (num > 0)
            {
                int d = num % 10;
                num = num / 10;
                totalSum += d * d;
            }
            return totalSum;
        }
        public static bool IsHappyNumber(int num)
        {
            List<int> prevNumber = new List<int>();
            while (num != 1 && !prevNumber.Contains(num))
            {
                prevNumber.Add(num);
                num = GetNextNumber(num);
            }
            return num == 1;
        }
        static void Main(string[] args)
        {
            int numberToTest = 13;
            Console.Write($"{numberToTest} is {IsHappyNumber(numberToTest)}");
        }
    }
}
