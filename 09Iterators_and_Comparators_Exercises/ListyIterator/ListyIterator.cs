
namespace ListyIterator
{
    using System.Collections.Generic;

    public class ListyIterator<T>
    {
        private int index;
        private List<T> storeListOfData;
        public ListyIterator(params T[] inputListOfData)
        {
            this.index = 0;
            T[] test = inputListOfData;
            this.StoreListOfData = new List<T>(inputListOfData);
        }
        public ListyIterator()
        {
            this.index = 0;
            this.StoreListOfData = new List<T>();

        }
        public List<T> StoreListOfData
        {
            set
            {
                this.storeListOfData = value;
            }
        }

        public bool Move()
        {
            index++;
            if (this.storeListOfData.Count > this.index)
            {
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.storeListOfData.Count > this.index+1)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            int count = this.storeListOfData.Count;
            if (count != 0)
            {
                System.Console.WriteLine(this.storeListOfData[this.index]);
            }
            else
            {
                System.Console.WriteLine("Invalid Operation!");
            }
        }
    }
}
