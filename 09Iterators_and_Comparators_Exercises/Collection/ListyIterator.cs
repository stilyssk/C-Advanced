
namespace ListyIterator
{
    using System.Collections;
    using System.Collections.Generic;
    using System;
    public class ListyIterator<T> : IEnumerable<T>
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
                Console.WriteLine(this.storeListOfData[this.index]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
        public void PrintAll()
        {
            string printString = "";
            foreach (var item in storeListOfData)
            {
                printString = printString+ item + ' ';
            }
            Console.WriteLine(printString);
        }
        public IEnumerator<T> GetEnumerator()
        {
            yield return storeListOfData[index];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
