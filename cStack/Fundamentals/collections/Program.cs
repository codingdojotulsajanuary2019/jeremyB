using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
        // Three Basic Arrays
        // Create an array to hold integer values 0 through 9
        int[] IntArr = new int[10];
        for(int i = 0; i < IntArr.Length; i++){
          IntArr[i] = i;
        }
        Console.WriteLine(IntArr);

        // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
        string[] Names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
        Console.WriteLine(Names);

        // Create an array of length 10 that alternates between true and false values, starting with true
        bool[] Truther = new bool[10];
        for(int i = 0; i < Truther.Length; i+=2){
          Truther[i] = true;
          Truther[i+1] = false;
        }
        Console.WriteLine(Truther);

        // List of Flavors
        // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
        List<string> Flavors = new List<string>();
        Flavors.Add("Vanilla");
        Flavors.Add("Chocolate");
        Flavors.Add("Lemon");
        Flavors.Add("Cookie Dough");
        Flavors.Add("Rocky Road");

        // Output the length of this list after building it
        Console.WriteLine(Flavors.Count);

        // Output the third flavor in the list, then remove this value
        Console.WriteLine(Flavors[2]);
        Flavors.RemoveAt(2);

        // Output the new length of the list (It should just be one fewer!)
        Console.WriteLine(Flavors.Count);

        // User Info Dictionary
        // Create a dictionary that will store both string keys as well as string values
        Dictionary<string, string> Users = new Dictionary<string, string>();

        // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
        foreach(string name in Names){
          Users.Add(name, null);
        }

        // For each name key, select a random flavor from the flavor list above and store it as the value

        Random Rand = new Random();

        foreach(string name in Names){
          Users[name] = Flavors[Rand.Next(Flavors.Count)];
        }


        // Loop through the dictionary and print out each user's name and their associated ice cream flavor
        foreach(var result in Users){
          Console.WriteLine($"{result.Key} likes {result.Value}");
        }

        }
    }
}
