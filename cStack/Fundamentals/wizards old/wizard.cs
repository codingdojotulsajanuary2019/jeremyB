using System;

namespace wizards{

    class Wizard : Human
    {

        public Wizard(string name): base(name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 10;
            Dexterity = 3;
            health = 50;  
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            int heal = dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage and healed themselves for {heal}!");
            this.health += heal;
            return target.health;
        }

        public int Heal(Human target)
        {
            int heal = Intelligence * 10;
            Console.WriteLine($"{Name} healed {target.Name} for {heal}!");
            target.health += heal;
            return target.health;
        }
    }
}