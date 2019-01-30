using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
    class userNameAndInt
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static userNameAndInt splitInputStringToUserIfo(string inputString)
        {
            userNameAndInt tempData = new userNameAndInt();
            //char[] name = new char[inputString.Length];
            string name = "";
            string age = "";
            bool flagName = true;
            bool flagAge = false;
            int indexAge = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if(inputString[i] == ',')
                {
                    flagName = false;
                    flagAge = true;
                    i++;
                }
                else if (flagName)
                {
                    name += inputString[i];

                }

                if (flagAge)
                {
                    age += inputString[i];
                    indexAge++;

                }
            }
            //tempData.Name = name.ToString();
            tempData.Name = name;
            tempData.Age = int.Parse(age);
            return tempData;
        }

        static userNameAndInt[] SortFunc(userNameAndInt[] userArrayDataTemp,string sortCommand, int limitAge)
        {

            if (sortCommand== "older")
            {
                List<userNameAndInt> tempListUserData = new List<userNameAndInt>();
                foreach (var userData in userArrayDataTemp)
                {
                    if (userData.Age>=limitAge)
                    {
                        tempListUserData.Add(userData);
                    }
                }
                userArrayDataTemp = tempListUserData.ToArray();
            }
            else if (sortCommand== "younger")
            {
                List<userNameAndInt> tempListUserData = new List<userNameAndInt>();
                foreach (var userData in userArrayDataTemp)
                {
                    if (userData.Age <= limitAge)
                    {
                        tempListUserData.Add(userData);
                    }
                }
                userArrayDataTemp = tempListUserData.ToArray();

            }

            return userArrayDataTemp;
        }

        static void NameAge(userNameAndInt[] userDataTemp, string commandFirst, string commandSecond)
        {
            if (commandFirst=="name")
            {
                foreach (var nameAge in userDataTemp)
                {
                    Console.WriteLine($"{nameAge.Name} - {nameAge.Age}");
                }
            }
            else if(commandFirst=="age")
            {
                foreach (var ageName in userDataTemp)
                {
                    Console.WriteLine($"{ageName.Age} - {ageName.Name}");
                }
            }
        }

        static void NameAge(userNameAndInt[] userDataTemp, string commandFirst)
        {
            if (commandFirst == "name")
            {
                foreach (var nameAge in userDataTemp)
                {
                    Console.WriteLine($"{nameAge.Name}");
                }
            }
            else if (commandFirst == "age")
            {
                foreach (var ageName in userDataTemp)
                {
                    Console.WriteLine($"{ageName.Age}");
                }
            }
        }




        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            userNameAndInt[] userdata = new userNameAndInt[repeat];
            for (int i = 0; i < repeat; i++)
            {
                string inputString = Console.ReadLine();
                userdata[i] = splitInputStringToUserIfo(inputString);


            }
            string sortCommand = Console.ReadLine();
            int limitAge =int.Parse(Console.ReadLine());
            string[] printCommand = Console.ReadLine()
                .Split(new string[] {" " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            userdata = SortFunc(userdata, sortCommand, limitAge);
            if (printCommand.Length==1)
            {
                NameAge(userdata, printCommand[0]);
            }
            else if (printCommand.Length==2)
            {
                NameAge(userdata, printCommand[0], printCommand[1]);
            }



        }
    }
}
