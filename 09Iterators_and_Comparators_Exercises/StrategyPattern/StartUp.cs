using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var listOfPerson = new List<Person>();
            var sortedSetPerson = new SortedSet<Person>();
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                var inputCommand = Console.ReadLine()
                    .Split()
                    .ToList();
                string name = inputCommand[0];
                int age = int.Parse(inputCommand[1]);
                Person newPerson = new Person(name, age);

                listOfPerson.Add(newPerson);
                sortedSetPerson.Add(newPerson);
            }

            ComparePersonUp comparePersonUp = new ComparePersonUp();
            listOfPerson.Sort(comparePersonUp);
            foreach (var person in listOfPerson)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
            //ComparePersonDown comparePersonDown = new ComparePersonDown();
            //listOfPerson.Sort(comparePersonDown);
            //foreach (var person in listOfPerson)
            //{
            //    Console.WriteLine($"{person.Name} {person.Age}");
            //}
            //Console.WriteLine();
            foreach (var person in sortedSetPerson)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

        }
    }
}
