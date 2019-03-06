using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int i = 1; i < 256; i++)
        {
          Console.WriteLine(i);
        }

        for (int j = 1; j < 100; j++)
        {
          if(j % 3 == 0 || j % 5 == 0)
          {
            if(j % 3 == 0 && j % 5 == 0)
            {
              continue;
            }
            Console.WriteLine(j);
          }
        }

        for (int k = 1; k < 100; k++)
        {
          if(k % 3 == 0)
          {
            Console.WriteLine("Fizz");
          }
          if(k % 5 == 0)
          {
            Console.WriteLine("Buzz");
          }
          if(k % 3 == 0 && k % 5 == 0 )
          {
            Console.WriteLine("FizzBuzz");
          }
        }

        }
    }
}
