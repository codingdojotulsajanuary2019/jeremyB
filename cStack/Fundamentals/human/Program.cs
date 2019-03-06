using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kunle like(s) McDonald's");
            Human bill = new Human("Bill", 5, 5, 5, 150);
            Human joe = new Human("Joe");
            Console.WriteLine(joe.Attack(bill));
        }
    }
}
// AHHHHHHHHHHHHHHH!!!!!!!!!!!!!!!!!!!!!!!!!! //