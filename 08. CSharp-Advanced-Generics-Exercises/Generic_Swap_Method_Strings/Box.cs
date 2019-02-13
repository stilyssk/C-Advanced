
using System.Collections.Generic;

namespace Generic_Swap_Method_Strings
{
    class Box<T>
    {
        private  T storeData; 
        public Box(T inputData)
        {
            storeData = inputData;
        }

        public override string  ToString()
        {

            string result = $"{storeData.GetType()}: {storeData}";
            return result;
        }

    }
}
