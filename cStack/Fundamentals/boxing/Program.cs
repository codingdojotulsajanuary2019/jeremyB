using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> BoxedData = new List<object>();
            int sum = 0;
            BoxedData.Add(7);
            BoxedData.Add(28);
            BoxedData.Add(-1);
            BoxedData.Add(true);
            BoxedData.Add("Chair");
            foreach(var thing in BoxedData)
            {
              Console.WriteLine(thing);
              if(thing is int)
              {
                sum += thing;
              }
            }
            Console.WriteLine(sum);

        }
    }
}
