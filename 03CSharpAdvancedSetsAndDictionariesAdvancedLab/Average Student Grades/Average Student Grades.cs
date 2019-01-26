using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<float>> studentGrade = new Dictionary<string, List<float>>();
            int countOfStudent = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfStudent; i++)
            {
                string[] inputData = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string nameStudent = inputData[0];
                float score = float.Parse(inputData[1]);
                if (studentGrade.ContainsKey(nameStudent))
                {
                    studentGrade[nameStudent].Add(score);
                }
                else
                {
                    List<float> tempScoreData = new List<float>();
                    tempScoreData.Add(score);
                    studentGrade.Add(nameStudent, tempScoreData);
                }
            }
            foreach (var keyValuePair in studentGrade)
            {
                string scoreFormated = "";
                foreach (var scoreValue in keyValuePair.Value)
                {
                    scoreFormated += $"{scoreValue:f2} ";
                }
                Console.WriteLine($"{keyValuePair.Key} -> {scoreFormated}(avg: {keyValuePair.Value.Average():f2})");
            }
        }
    }
}
