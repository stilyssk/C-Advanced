
namespace Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private List<int> stones;
        private bool flagForword;
        public Lake(params int[] inputData)
        {
            this.flagForword = true;
            this.stones = new List<int>();
            foreach (var inputElement in inputData)
            {
                this.Stones = inputElement;
            }
        }

        public int Stones
        {
            set
            {
                stones.Add(value);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {

            for (int i = 0; i < stones.Count; i ++)
            {
                if (i%2==0)
                {
                    yield return stones[i];
                }

            }

            for (int i = stones.Count - 1; i > 0; i --)
            {
                if (i%2!=0)
                {
                    yield return stones[i];
                }

            }


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
