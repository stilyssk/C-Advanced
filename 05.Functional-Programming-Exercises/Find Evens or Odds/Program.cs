using System;
using System.Collections.Generic;

namespace Find_Evens_or_Odds
{
    class Program
    {
        struct TempData
        {
            public string pyrvi { get; set; }
        }
        static void Main(string[] args)
        {
            List<string> testList = new List<string>() { "dfadfa"};

            TempData test = new TempData();
            test.pyrvi = "proba";
            Predicate<List<string>> predicate = PredTest;
        }
        static bool PredTest(List<string> tempObg)
        {
            return true;
        }
    }
}
