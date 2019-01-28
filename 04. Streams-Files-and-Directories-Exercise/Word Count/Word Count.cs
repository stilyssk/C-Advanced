using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stringAndCount = new Dictionary<string, int>();
            using (StreamReader readerWordsTXT = new StreamReader(@"../../../../words.txt"))
            {

                while (!readerWordsTXT.EndOfStream)
                {
                    string[] wordsTXTArrayOfWords = readerWordsTXT.ReadLine()
                        .Split(new string[] { " ", "-", "?", "!", ",", "." }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.ToLower())
                        .ToArray();
                    using (StreamReader readerTextTXT = new StreamReader(@"../../../../text.txt"))
                    {
                        while (!readerTextTXT.EndOfStream)
                        {
                            string[] textTXTArrayOfWords = readerTextTXT.ReadLine()
                                    .Split(new string[] { " ", "-", "?", "!", ",", "." }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x => x.ToLower())
                                    .ToArray();
                            foreach (var wordFromWordTxt in wordsTXTArrayOfWords)
                            {
                                foreach (var wordFromTextTxt in textTXTArrayOfWords)
                                {
                                    if (wordFromTextTxt == wordFromWordTxt)
                                    {
                                        if (stringAndCount.ContainsKey(wordFromWordTxt))
                                        {
                                            stringAndCount[wordFromWordTxt]++;
                                        }
                                        else
                                        {
                                            stringAndCount.Add(wordFromWordTxt, 1);
                                        }
                                    }
                                }
                            }
                        }

                    }


                }
            }
            using (StreamWriter fileActualResultTxt = new StreamWriter("./actualResult.txt"))
            {
                foreach (var wordInformation in stringAndCount)
                {
                    fileActualResultTxt.WriteLine($"{wordInformation.Key} - {wordInformation.Value}");
                }
            }
            stringAndCount = stringAndCount.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            using (StreamWriter fileExpectedResultTxt = new StreamWriter("./expectedResult.txt"))
            {
                foreach (var wordInformation in stringAndCount)
                {
                    fileExpectedResultTxt.WriteLine($"{wordInformation.Key} - {wordInformation.Value}");
                }
            }

            foreach (var wordInformation in stringAndCount)
            {
                Console.WriteLine($"{wordInformation.Key} - {wordInformation.Value}");
            }
        }
    }
}
