using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace PersonsInfo
{
    public class StartUp
    {
       public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(tokens.First(), tokens.Skip(1).First(), int.Parse(tokens.Last()));
                persons.Add(person);
            }
            persons.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
