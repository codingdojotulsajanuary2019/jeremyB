using System;
using System.Collections.Generic;

namespace practice
{

    class basic13
    {
        public static void PrintNumbers(int num)
        {
          for (int i= 0; i < num+1; i++)
          {
            Console.WriteLine(i);
          }

        }
        public static void returnOdds(int num)
        {
          for (int i= 0; i < num+1; i++)
          {
            if(i % 2 != 0)
            {
              Console.WriteLine(i);
            }
          }
        }

        public static void PrintSum(int num)
        {
          int sum = 0;
          for (int i=0; i <=num; i++)
          {
            sum += i;
            Console.WriteLine("Number: "+i+" Sum: "+ sum);
          }

        }

        public static void LoopArray(int[] numbers)
        {
          foreach(int num in numbers)
          {
            Console.WriteLine(num);
          }
        }

        public static void FindMax(int [] numbers)
        {
          int max = numbers[0];
          foreach(int num in numbers)
          {
            if(num > max){
              max = num;
            }
          }
          Console.WriteLine(max);

        }

        public static void GetAverage(int[] numbers)
        {
          int sum = 0;
          foreach(int num in numbers)
          {
            sum += num;
          }
          Console.WriteLine(sum/numbers.Length);
        }

        public static int[] OddArray()
        {
          int count = 0;
          for(int i = 0; i <= 255; i++)
          {
              if(i % 2 !=0)
              {
                  count +=1;
              }
          }
          int [] arr = new int[count];
          int index = 0;
          for(int x = 0; x<=255; x++)
          {
              if(x % 2 != 0)
              {
                  arr[index] = x;
                  index += 1;
              }
          }
          return arr;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
          int count = 0;
          foreach(int num in numbers)
          {
            if(num > y)
            {
              count ++;
            }
          }
          return count;

        }

        public static int[] SquareArrayValues(int[] numbers)
        {
          for (int i = 0; i < numbers.Length; i++)
          {
            numbers[i] = numbers[i] * numbers[i];
          }
          return numbers;
        }

        public static int[] EliminateNegatives(int[] numbers)
        {
          for (int i = 0; i < numbers.Length; i++)
          {
            if(numbers[i] < 0)
            {
              numbers[i] = 0;
            }
          }
          return numbers;
        }

        public static void MaxMinAvg(int [] arr)
        {
          int min = arr[0];
          int max = arr[0];
          int sum = 0;
          foreach(int num in arr)
          {
            if(num < min)
            {
              min = num;
            }
            if(num > max)
            {
              max = num;
            }
            sum += num;
          }
          int avg = sum/arr.Length;
          Console.WriteLine($"Min: {min}, Max: {max}, Avg: {avg}");
        }

        public static int[] ShiftValues(int[] numbers)
        {
          for(int i =0;i<numbers.Length-1;i++)
          {
            numbers[i] = numbers[i+1];
          }
          numbers[numbers.Length-1] = 0;
          return numbers;

        }


        public static object[] NumToString(int[] numbers)
        {
          object[] x = new object [numbers.Length];
          string dojo = "dojo";
          for (int i=0; i< numbers.Length; i++)
          {
            if(numbers[i] < 0)
            {
              x[i] = dojo;
            }
            else
            {
              x[i]= numbers[i];
            }
          }
          return x;
        }


    }
}
