
using System.Collections.Generic;

namespace Count_Method_Doubles
{
    class Box<T>
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
            if (compareString.GetType() == typeof(string))
            {
                string firstCompareString = storeData.ToString();
                string secondCompareString = compareString.ToString();
                if (firstCompareString.Contains(secondCompareString))
                {
                    return true;

                }
            }
            if (compareString.GetType() == typeof(double))
            {
                double firstElement = double.Parse(storeData.ToString());
                double secondElement = double.Parse(compareString.ToString());

                if (firstElement>secondElement)
                {
                    return true;
                }
            }


            return false;
        }
    }
}
