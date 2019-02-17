using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<Person> hsPerson = new HashSet<Person>();
            SortedSet<Person> ssPerson = new SortedSet<Person>();
            //var listOfPerson = new List<Person>();
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                var inputCommand = Console.ReadLine()
                    .Split()
                    .ToList();
                string name = inputCommand[0];
                int age = int.Parse(inputCommand[1]);
                Person newPerson = new Person(name, age);
                hsPerson.Add(newPerson);

                ssPerson.Add(newPerson);

            }
            //Console.WriteLine();
            //foreach (var item in hsPerson)
            //{
            //    Console.WriteLine($"HS {item.Name} {item.Age}");
            //}

            //Console.WriteLine();
            //foreach (var item in ssPerson)
            //{
            //    Console.WriteLine($"SS {item.Name} {item.Age}");
            //}
            Console.WriteLine(hsPerson.Count);
            Console.WriteLine(ssPerson.Count);
        }
    }
}
