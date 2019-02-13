
using System.Collections.Generic;

namespace Generic_Swap_Method_Strings
{
    class swapClass<T>
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
    }
}
