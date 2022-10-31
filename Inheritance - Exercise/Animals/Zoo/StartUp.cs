using System;
using System.Collections.Generic;

namespace Zoo
{
    public class StartUp
    {
        public static void Main()
        {
            Action<List<Animal>> print = animals => Console.WriteLine(string.Join(Environment.NewLine, animals)); 
            List<Animal> animals = new List<Animal>();
            Animal animal = new Animal("animal");
            animals.Add(animal);
            Mammal mammal = new Mammal("Mammal");
            animals.Add((Animal)mammal);
            Reptile reptile = new Reptile("Reptile");
            animals.Add((Animal)reptile);
            Lizard lizard = new Lizard("Lizard");
            animals.Add((Animal)lizard);
            Snake snake = new Snake("Snake");
            animals.Add((Animal)snake);
            Gorilla gorilla = new Gorilla("Gorilla");
            animals.Add((Animal)gorilla);
            Bear bear = new Bear("Bear");
            animals.Add((Animal)bear);
            print(animals);
        }
    }
}