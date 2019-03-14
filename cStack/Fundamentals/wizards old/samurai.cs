using System;

namespace wizards{
    
    class Samurai : Human
    {
        public Samurai(string name): base(name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 200;  
        }

        public override int Attack(Human target)
        {
            if (target.health < 51)
            {
                target.health =0;
                Console.WriteLine($"{Name} brutally and unnecessarily killed {target.Name}!");
            }
            else
            {
                Console.WriteLine($"{Name} tried to attack {target.Name}, but since they weren't almost dead it doesn't matter because this assignment has stupid logic!");
            }
            return target.health;
        }
        public int Meditate()
        {
            int heal = 200-this.health;
            Console.WriteLine($"{Name} meditated to regain {heal} health!");
            this.health += heal;
            return this.health;
        }
    }
}