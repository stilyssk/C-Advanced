using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            var hosplital = new Dictionary<string, rooms>() { };
            
            while (true)
            {
                var inputData = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (inputData[0]== "Output")
                {
                    break;
                }
                else
                {
                    string depatment = inputData[0];
                    string doctor = inputData[1] + " " + inputData[2];
                    string patient = inputData[3];
                    if (doctors.ContainsKey(doctor))
                    {
                        doctors[doctor].Add(patient);
                    }
                    else
                    {
                        doctors.Add(doctor, new List<string> { patient });
                    }


                    if (hosplital.ContainsKey(depatment))
                    {
                        hosplital[depatment].AddPatient(patient);
                    }
                    else
                    {
                        hosplital.Add(depatment, new rooms(patient));
                    }

                }
            }
            while (true)
            {
                var outputCommand = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (outputCommand[0]=="End")
                {
                    break;
                }
                if (outputCommand.Count == 1)
                {
                    string command = outputCommand[0];

                    if (hosplital.ContainsKey(command))
                    {
                        var resultList = hosplital[command].PrintAll();
                        foreach (var item in resultList)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                else if (outputCommand.Count == 2)
                {
                    string command = outputCommand[0] + " " + outputCommand[1];

                    if (doctors.ContainsKey(command))
                    {
                        var result = doctors[command];
                        result = result.OrderBy(x => x).ToList();
                        foreach (var item in result)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        command = outputCommand[0];

                        int printRoom = int.Parse(outputCommand[1]);
                        var printResult = hosplital[command].PrintRoom(printRoom);
                        printResult = printResult.OrderBy(x => x).ToList();
                        foreach (var item in printResult)
                        {
                            Console.WriteLine(item);
                        }
                    }


                }
            }
        }

    }

    public class rooms
    {
        private string[,] depRooms;

        public rooms(string patient)
        {
            this.depRooms = new string[20,3];
            this.AddPatient(patient);
        }

        public bool AddPatient(string patient)
        {
            bool ocupate = true;
            bool added = false;
            for (int i = 0; i < depRooms.GetLength(0)&&ocupate; i++)
            {
                for (int j = 0; j < depRooms.GetLength(1) && ocupate; j++)
                {
                    if (depRooms[i, j] == null)
                    {
                        depRooms[i, j] = patient;
                        ocupate = false;
                        added = true;
                    }
 
                }
            }
            return added;
        }

        public List<string> PrintAll()
        {
            List<string> result = new List<string>();
            foreach (var item in depRooms)
            {
                if (item !=null)
                {
                    result.Add(item);

                }
            }
            return result;
        }

        public List<string> PrintRoom(int room)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                result.Add(depRooms[room - 1, i]);
            }
            return result;
        }
    }
}
