using System;

namespace wizards{
    
    class Ninja : Human
    {
        public Ninja(string name): base(name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 15;
            health = 175;  
        } 

        public override int Attack(Human target)
        {
            Random rand = new Random();
            int crit = rand.Next(6);
            int dmg = Dexterity * 5;
            if (crit == 1 )
            {
                dmg += 10;
            }
            target.health -= dmg;
            Console.WriteLine($"{Name} judo chopped {target.Name} for {dmg} damage!");
            return target.health;
        }
        public int Steal(Human target)
        {
            target.health -= 5;
            this.health += 5;
            Console.WriteLine($"{Name} stole 5 health from {target.Name}!");
            return this.health;
        }
    }
}