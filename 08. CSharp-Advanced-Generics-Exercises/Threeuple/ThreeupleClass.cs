using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    class ThreeupleClass<T,K,Z>
    {
        private T item1;
        private K item2;
        private Z item3;

        public ThreeupleClass(T item1, K item2,Z item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public Z Item3
        {
            get { return this.item3; }
            set { this.item3 = value; }
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
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
