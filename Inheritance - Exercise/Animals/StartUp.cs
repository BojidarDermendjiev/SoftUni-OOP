using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            string input;
            StringBuilder sb = new StringBuilder();
            while ((input = Console.ReadLine()) != "Beast!")
            {
                string type = input;
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string gender = string.Empty;
                if (tokens.Length > 2)
                {
                    gender = tokens[2];
                }
                switch (type)
                {
                    case "Dog": Dog dog = new Dog(name, age, gender);sb.AppendLine(dog.ToString()); break;
                    case "Cat": Cat cat = new Cat(name, age, gender); sb.AppendLine(cat.ToString()); break;
                    case "Frog": Frog frog = new Frog(name, age, gender); sb.AppendLine(frog.ToString()); break;
                    case "Kitten": Kitten kitten = new Kitten(name, age); sb.AppendLine(kitten.ToString()); break;
                    case "Tomcat": Tomcat tomcat = new Tomcat(name, age); sb.AppendLine(tomcat.ToString()); break;
                    default: throw new ArgumentException("Invalid Input!");
                }
     
            }
            Console.WriteLine(sb.ToString());            
        }
    }
}