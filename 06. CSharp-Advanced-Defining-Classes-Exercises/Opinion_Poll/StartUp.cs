

namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                List<string> inputData = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string inputName = inputData[0];
                int inputAge = int.Parse(inputData[1]);
                Person newPerson = new Person(inputName, inputAge);
                listOfPersons.Add(newPerson);
            }
            listOfPersons = listOfPersons.Where(x => x.Age > 30).OrderBy(x=>x.Name).ToList();
            foreach (var currentPerson in listOfPersons)
            {
                Console.WriteLine(currentPerson.PrintData());
            }
        }
    }
}
