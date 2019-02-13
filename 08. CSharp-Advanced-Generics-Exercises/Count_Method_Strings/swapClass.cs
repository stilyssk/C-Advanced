
using System.Collections.Generic;
using System;
namespace Count_Method_Strings
{
    class swapClass<T> where T : IComparable
    {
        private List<Box<T>> boxes;
        public Box<T> Boxes
        {
            set
            {
                this.boxes.Add(value);
            }
        }
        public List<Box<T>> BoxesList
        {
            get
            {
                return boxes;
            }
            set
            {
                this.boxes = value;
            }
        }
        public  void Add(Box<T> addBoxItem)
        {
            Boxes = addBoxItem;   
        }
        public void Swap( int firstIndex, int secondIndex)
        {
            Box<T> tempElement = this.BoxesList[firstIndex];
            this.BoxesList[firstIndex] = this.BoxesList[secondIndex];
            this.BoxesList[secondIndex] = tempElement;

        }

        public void Print()
        {
            foreach (var item in boxes)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
        public swapClass()
        {
            this.boxes = new List<Box<T>>();
        }


        public int Compare(T compareElement)
        {
            if (compareElement.GetType()==typeof(string))
            {
                int count = 0;
                for (int i = 0; i < boxes.Count; i++)
                {
                    if (boxes[i].Compare(compareElement))
                    {
                        count++;
                    };

                }
                return count;
            }
            return 0;
        }
    }
}
