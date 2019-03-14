using System;

namespace ironNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet Lunch = new Buffet();
            SweetTooth Jeremy = new SweetTooth();
            SpiceHound Abbey = new SpiceHound();
            while(Jeremy.IsFull != true)
            {
                IConsumable snack = Lunch.Serve();
                Jeremy.Consume(snack);
            }
            while(Abbey.IsFull != true)
            {
                IConsumable snack = Lunch.Serve();
                Abbey.Consume(snack);
            }
            if(Abbey.ConsumptionHistory.Count > Jeremy.ConsumptionHistory.Count)
            {
                Console.WriteLine("Abbey ate more");
            }
            if(Abbey.ConsumptionHistory.Count < Jeremy.ConsumptionHistory.Count)
            {
                Console.WriteLine("Jeremy ate more");
            }
        }
    }
}
