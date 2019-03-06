using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Array = {1,-2,3,-4,5,-6,7,8,9};
            basic13.PrintNumbers(255);
            basic13.returnOdds(255);
            basic13.PrintSum(255);
            basic13.LoopArray(Array);
            basic13.MaxMinAvg(Array);
            basic13.FindMax(Array);
            int [] result = basic13.OddArray();
            basic13.GetAverage(Array);
            Console.WriteLine(result);
            Console.WriteLine(basic13.GreaterThanY(Array, 2));
            Console.WriteLine(basic13.SquareArrayValues(Array));
            Console.WriteLine(basic13.EliminateNegatives(Array));
            Console.WriteLine(basic13.ShiftValues(Array));
            Console.WriteLine(basic13.NumToString(Array));
        }
    }
}
