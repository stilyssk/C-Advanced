using System.Collections.Generic;

namespace StrategyPattern
{
    public class ComparePersonUp : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            Person firstPerson = x;
            Person secondPerson = y;
            int firstPersonNameLenght = firstPerson.Name.Length;
            int secondPersonNameLenght = secondPerson.Name.Length;
            int result;
            result = firstPersonNameLenght.CompareTo(secondPersonNameLenght);
            if (result == 0)
            {
                result = firstPerson.Name.ToLower()[0].CompareTo(secondPerson.Name.ToLower()[0]);
         
            }
            return result;
        }
    }
}
