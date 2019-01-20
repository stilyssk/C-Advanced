using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCountOfPetrolStation = int.Parse(Console.ReadLine());
            Queue<int[]> storePumpStationInforamtion = new Queue<int[]>();

            for (int i = 0; i < inputCountOfPetrolStation; i++)
            {
                int[] pumpStationData = Console.ReadLine()
                    .Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries )
                    .Select(int.Parse)
                    .ToArray();
                storePumpStationInforamtion.Enqueue(pumpStationData);

            }
            int result;
            for (result = 0; result < inputCountOfPetrolStation; result++)
            {
                int fuel = 0;
                bool flagComlete = true;
                for (int k=0; k<storePumpStationInforamtion.Count;k++)
                {
                    int[] tempPumpData = storePumpStationInforamtion.Dequeue();
                    storePumpStationInforamtion.Enqueue(tempPumpData);
                    fuel += tempPumpData[0];
                    if (fuel<tempPumpData[1])
                    {
                        flagComlete = false;
                    }
                    else
                    {

                        fuel -= tempPumpData[1];
                    }
                }
                if (flagComlete)
                {
                    break;
                }
                else
                {
                    storePumpStationInforamtion.Enqueue(storePumpStationInforamtion.Dequeue());
                }
            }
            Console.WriteLine(result);
        }
    }
}
