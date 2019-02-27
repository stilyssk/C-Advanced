namespace PetClinics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            List<Pet> listOfPets = new List<Pet>();
            List<Clinic> listOfClinic = new List<Clinic>();
            while (true)
            {
                string[] inputCommand = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = inputCommand[0];
                
                switch (command)
                {
                    case "Create":
                        string petClinic = inputCommand[1];
                        if (petClinic== "Pet")
                        {
                            string name = inputCommand[2];
                            int age = int.Parse(inputCommand[3]);
                            string kind = inputCommand[4];
                            var newPets = new Pet(name,age,kind);
                            listOfPets.Add(newPets);
                        }
                        else if (petClinic == "Clinic")
                        {
                            string name = inputCommand[2];
                            int rooms = int.Parse(inputCommand[3]);
                            var newClinic = new Clinic();
                            newClinic.Create(name, rooms);
                        }
                        break;
                    case "Add":
                        var newPets = listOfPets[0];
                        listOfClinic[0].Add(newPets);
                        break;
                    case "Release":
                        break;
                    case "HasEmptyRooms":
                        break;
                    case "Print":
                        if (inputCommand.Length==2)
                        {

                        }
                        else if (inputCommand.Length==3)
                        {

                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
