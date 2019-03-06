using System;
using System.Collections.Generic;

namespace puzzles
{
  class Puzzle
  {
    public static int[] rand()
    {
      int[] newArr = new int[10];
      Random rand = new Random();
      int max = newArr[0];
      int min = newArr[0];
      int sum = 0;
      for(int i = 0; i < newArr.Length; i++)
      {
        newArr[i] = rand.Next(5,26);
        sum += newArr[i];
        if(newArr[i] > max)
        {
          max = newArr[i];
        }
        if(newArr[i] < min)
        {
          min = newArr[i];
        }
      }
      Console.WriteLine($"Max: {max}");
      Console.WriteLine($"Min: {min}");
      Console.WriteLine($"Sum: {sum}");
      return newArr;
    }

    public static string flip()
    {
      Console.WriteLine("Tossing:");
      Random rand = new Random();
      int result = rand.Next(2);
      if (result == 0)
      {
        Console.WriteLine("Heads!");
        return ("Heads");
      }
      else
      {
        Console.WriteLine("Tails!");
        return ("Tails");
      }
    }

    public static double multiFlip(int num)
    {
      int heads_count = 0;
      string result;
      double answer;
      for(int i=0; i <=num; i++)
      {
          result = flip();
          if(result =="Heads")
          {
            heads_count ++;
          }
      }
      answer = (double)heads_count/num;
      Console.WriteLine(answer);
      Console.WriteLine("Result (ratio): "+ answer);
      return(answer);

    }
    public static List<string> names()
    {
      List<string> peeps = new List<string>();
      peeps.Add("Todd");
      peeps.Add("Tiffany");
      peeps.Add("Charlie");
      peeps.Add("Geneva");
      peeps.Add("Sydney");

      Random rand = new Random();
      for(int i = peeps.Count-1;i>0;i--)
      {
        int j = rand.Next(i+1);
        string temp = peeps[i];
        peeps[i] = peeps[j];
        peeps[j] = temp;
      }
      foreach(string peep in peeps)
      {
        Console.WriteLine(peep);
      }
      List<string> result = new List<string>();
      foreach(string person in peeps)
      {
        if(person.Length > 5)
        {
          result.Add(person);
        }
      }
    Console.WriteLine(result.Count);
    return result;      
    }
  }

}
