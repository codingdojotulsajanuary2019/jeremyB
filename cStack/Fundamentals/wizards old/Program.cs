using System;

namespace wizards
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard bob = new Wizard("Bob");
            Ninja bill = new Ninja("Bill");
            Samurai joe = new Samurai("joe");
            joe.Attack(bob);
            bill.Attack(joe);
            bob.Attack(bill);
            Console.WriteLine(joe.health);
            joe.Attack(bob);
            bob.Heal(bill);
            joe.Attack(bill);
            Console.WriteLine(joe.health);
            joe.Meditate();
            Console.WriteLine(joe.health);
            bill.Steal(bob);
        }
    }
}
