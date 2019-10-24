using System;
using System.Collections.Generic;

namespace AnimalClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>
            {
                new Animal("Whiskers","cat", "meow", true),
                new Animal("Scorsesi", "dog", "woof", true),
                new Animal("William Snakepeare", "snake", "Ssssss", false),
                new Animal("Nemo", "fish", "Dad?", false),
                new Animal("Ron", "rhino", "Bellow", false),
                new Animal("Fluffy", "bear", "rawr", true),
                new Animal("Nermal", "cat", "meow", true),
                new Animal("Fido", "dog", "woof", true)
            };

            Console.WriteLine("What kind of animal would you like to see?");
            Animal.PrintAnimalTypes(animalList);

            string selection = Console.ReadLine();

            for (int i = 0; i<animalList.Count; i++)
            {
                if (selection == animalList[i].Type)
                {
                    if(animalList[i].Fur == true)
                    Console.WriteLine($"{animalList[i].Name} is a {animalList[i].Type} that has fur and says {animalList[i].Sound} ");
                }
                else
                {
                    if (animalList[i].Fur == true)
                        Console.WriteLine($"{animalList[i].Name} is a {animalList[i].Type} that doesn't fur and says {animalList[i].Sound} ");
                }
            }
        }
    }
}
