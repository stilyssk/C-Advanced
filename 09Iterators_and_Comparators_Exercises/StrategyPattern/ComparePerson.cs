using System.Collections.Generic;

namespace StrategyPattern
{
    public class ComparePerson : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int firstPersonNameLenght = x.Name.Length;
            int secondPersonNameLenght = y.Name.Length;
            int result;
            if (firstPersonNameLenght>secondPersonNameLenght)
            {
                result = +1;
            }
            else if (firstPersonNameLenght < secondPersonNameLenght)
            {
                result = -1;
            }
            else
            {
                result = 0;
            }

            return result;
        }
    }
}
