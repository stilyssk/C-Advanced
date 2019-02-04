
namespace DefiningClasses
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family families = new Family();
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                List<string> inputData = Console.ReadLine()
                    .Split(new[] {" " },StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string inputName = inputData[0];
                int inputAge = int.Parse(inputData[1]);
                Person newPerson = new Person()
                {
                    Name = inputName,
                    Age = inputAge
                };
                families.AddMember(newPerson);
            }

            Person resultPerson = new Person();
            Console.WriteLine(families.GetOldestMember());
        }
    }
}
