
using System;
namespace Count_Method_Strings
{
    class Box<T> where T : IComparable
    {
        private T storeData;
        public Box(T inputData)
        {
            storeData = inputData;
        }

        public override string ToString()
        {

            string result = $"{storeData.GetType()}: {storeData}";
            return result;
        }
        public bool Compare(T compareString) 
        {
            int test = storeData.CompareTo(compareString);
            if (test > 0)
            {
                return true;
            }


            //if (compareString.GetType() == typeof(string))
            //{

            //    string firstCompareString   = storeData.ToString();
            //    string secondCompareString = compareString.ToString();


            //    if (firstCompareString.Contains(secondCompareString))
            //    {
            //        return true;

            //    }
            //}
            //if (compareString.GetType() == typeof(double))
            //{
            //    return true;
            //}


            return false;

        }
    }
}
