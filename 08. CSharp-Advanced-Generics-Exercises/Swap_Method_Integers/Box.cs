
using System.Collections.Generic;

namespace Swap_Method_Integers
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
