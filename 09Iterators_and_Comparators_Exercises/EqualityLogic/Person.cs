
namespace EqualityLogic
{
    using System;
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private int result;
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int CompareTo(Person other)
        {
            
            if (Name.CompareTo(other.Name)==0)
            {
                if (Age.CompareTo(other.Age)==0)
                {
                    result = 0;
                }
                else
                {
                    result = Age.CompareTo(other.Age);
                }
            }
            else
            {
                result = Name.CompareTo(other.Name);
            }
            return result;
        }
        public override bool Equals(Object obj)
        {
            Person secondElement = (Person)obj;
            if (Name.CompareTo(secondElement.Name) == 0)
            {
                if (Age.CompareTo(secondElement.Age) == 0)
                {
                    result = 0;
                }
                else
                {
                    result = Age.CompareTo(secondElement.Age);
                }
            }
            else
            {
                result = Name.CompareTo(secondElement.Name);
            }
            return result==0;
        }
        public override int GetHashCode()
        {
            return result;
        }
    }
}
