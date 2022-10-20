using System;

namespace Section_2_part_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("Please input forth numbers in format '123,123'");

            var firstNum = decimal.Parse(Console.In.ReadLine());
            var secondNum = decimal.Parse(Console.In.ReadLine());
            var thirdNum = decimal.Parse(Console.In.ReadLine());
            var fourthNum = decimal.Parse(Console.In.ReadLine());
            var maxNum = MaxNumberOfTwo(firstNum, secondNum);
            maxNum = MaxNumberOfTwo(maxNum, thirdNum);
            maxNum = MaxNumberOfTwo(maxNum, fourthNum);
            Console.Out.WriteLine($"{maxNum}");
        }

        private static decimal MaxNumberOfTwo(decimal a, decimal b)
        {
            switch (a >= b)
            {
                case true:
                    return a;
                case false:
                    return b;
            }
        }
    }
}