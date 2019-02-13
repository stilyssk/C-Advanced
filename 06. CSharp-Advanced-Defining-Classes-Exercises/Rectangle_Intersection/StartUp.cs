using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle_Intersection
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> inputRectangleCoordinate = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Dictionary<string, Rectangle> dictRectangle = new Dictionary<string, Rectangle>();
            int numberRectangle = inputRectangleCoordinate[0];

            for (int i = 0; i < numberRectangle; i++)
            {
                List<string> inputRectangleData = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string id = inputRectangleData[0];
                int width = int.Parse(inputRectangleData[1]);
                int height = int.Parse(inputRectangleData[1]);
                int xCoordinate = int.Parse(inputRectangleData[1]);
                int yCoordinate = int.Parse(inputRectangleData[1]);
                Rectangle newRectangleData = new Rectangle(id, width, height, xCoordinate, yCoordinate);
                dictRectangle.Add(id, newRectangleData);
            }
            int insertionCheckCount = inputRectangleCoordinate[1];
            for (int i = 0; i < insertionCheckCount; i++)
            {
                List<string> inputRectangleData = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string idFirstRectangle = inputRectangleData[0];
                string idSecondRectangle = inputRectangleData[1];
                if (dictRectangle[idFirstRectangle].CheckIntersect(dictRectangle[idSecondRectangle]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
