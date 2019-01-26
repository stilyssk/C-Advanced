using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> allInformatin = new Dictionary<string, Dictionary<string, List<string>>>();
            
            int countOfInputData = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfInputData; i++)
            {
                string[] inputData = Console.ReadLine()
                    .Split(new string[] { }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contintentName = inputData[0];
                string countryName = inputData[1];
                string cityName = inputData[2];
                if (!allInformatin.ContainsKey(contintentName))
                {
                    Dictionary<string, List<string>> tempCountryInformation = new Dictionary<string, List<string>>();
                    List<string> cityNames = new List<string>();
                    cityNames.Add(cityName);
                    tempCountryInformation.Add(countryName, cityNames);
                    allInformatin.Add(contintentName, tempCountryInformation);
                }
                else
                {
                    
                    Dictionary<string, List<string>> tempCountryInformation = new Dictionary<string, List<string>>();
                    tempCountryInformation = allInformatin[contintentName];

                    if (!tempCountryInformation.ContainsKey(countryName))                    
                    {
                        List<string> cityNames = new List<string>();
                        cityNames.Add(cityName);
                        tempCountryInformation.Add(countryName, cityNames);

                    }
                    else
                    {
                        List<string> cityNames = new List<string>();
                        cityNames = tempCountryInformation[countryName];
                        if (!cityNames.Contains(cityName))
                        {
                            cityNames.Add(cityName);
                            tempCountryInformation[countryName] = cityNames;
                        }

                    }

                    allInformatin[contintentName] = tempCountryInformation;
                }
            }

            foreach (var contintentInformation in allInformatin)
            {
                Console.WriteLine($"{contintentInformation.Key}:");
                foreach (var countryInformation in contintentInformation.Value)
                {

                    Console.WriteLine($"  {countryInformation.Key} -> {string.Join(", ",countryInformation.Value)}");
 
                }
            }
        }
    }
}
