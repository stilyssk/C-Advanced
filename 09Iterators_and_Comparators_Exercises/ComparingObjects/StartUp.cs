
namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var listOfPerson = new List<Person>();
            while (true)
            {
                var inputCommand = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (inputCommand[0]== "END")
                {
                    break;
                }
                else
                {
                    string name = inputCommand[0];
                    int age = int.Parse(inputCommand[1]);
                    string town = inputCommand[2];
                    listOfPerson.Add(new Person(name, age, town));
                }
            }
            foreach (var item in listOfPerson)
            {
            }
            int compareIndex = int.Parse(Console.ReadLine())-1;

            var comparePerson = listOfPerson[compareIndex];
            var repeatPerson = listOfPerson.Where(x => x.Name == "Gogo").ToList();
            int countRepeatPerson = repeatPerson.Count();
            int allCountPerson = listOfPerson.Count();
            if (countRepeatPerson==1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countRepeatPerson} {allCountPerson- countRepeatPerson} {allCountPerson}");
            }

            listOfPerson = listOfPerson.OrderBy(x => x.Name).ToList();

        }
    }
}
