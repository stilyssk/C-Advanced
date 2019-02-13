using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    class TripleClass <T,K>
    {
        private T item1;
        private K item2;

        public TripleClass(T item1,K item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }
        public K Item2
        {
            get { return this.item2; }
            set { this.item2 = value; }
        }

        public T Item1
        {
            get { return this.item1; }
            set { this.item1 = value; }
        }
        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
        public string Print()
        {

            return $"{Item1} -> {Item2}";
        }
    }
}
