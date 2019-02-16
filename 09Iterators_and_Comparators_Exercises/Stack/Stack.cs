
namespace Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable
    {
        private List<T> stackData;
        private int index;
        public T StackData
        {
            set
            {
                stackData.Add(value);
            }
        }
        public Stack()
        {
            index = 0;
            stackData = new List<T>();
        }


        public void Push(params T[] pushDataInStack)
        {
            foreach (var pushElement in pushDataInStack)
            {
                this.StackData = pushElement;
            }
        }

        public T Pop()
        {

            int count = stackData.Count - 1;
            if (count<0)
            {
                Console.WriteLine("No elements");
                

            }
            else
            {
                T removedElement = stackData[count];
                stackData.RemoveAt(count);
                return removedElement;
            }
            
            return default(T);

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stackData.Count-1; i >= 0; i--)
            {
                yield return this.stackData[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
