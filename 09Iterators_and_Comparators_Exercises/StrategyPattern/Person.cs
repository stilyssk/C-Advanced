﻿using System;

namespace StrategyPattern
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

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
            return this.Age.CompareTo(other.Age);
        }
    }
}
