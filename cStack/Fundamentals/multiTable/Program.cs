using System;

namespace multiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] arr = new int[10,10];
            for (int i = 0; i < 10; i++)
            {
                int val = i + 1;
                for (int j = 0; j < 10; j++)
                {
                    int val2 = j + 1;
                    arr[i,j] = val * val2;
                }
            }
            for (int x = 0; x < 10; x++)
            {
                Console.Write("[");
                for (int y = 0; y < 10; y++)
                {
                    Console.Write(arr[x,y]+", ");
                }
                Console.WriteLine("]");
            }
        }
    }
}
