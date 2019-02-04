
using System.Collections.Generic;

public class Family
{
    private List<Person> personMember  = new List<Person>();

    public Person PersonMember
    {
        set { this.personMember.Add(value); }
    }

    public void AddMember(Person newPerson)
    {
 
        this.PersonMember = newPerson;
    }
    public string GetOldestMember()
    {
        Person oldestPerson = new Person();
        oldestPerson = personMember[0];
        foreach (var tempPreson in personMember)
        {
            if (tempPreson.Age>oldestPerson.Age)
            {
                oldestPerson = tempPreson;
            }
        }
        return $"{oldestPerson.Name} {oldestPerson.Age}";
    }
    public Family()
    {
//        List<Person> personMember = new List<Person>();
    }
}

