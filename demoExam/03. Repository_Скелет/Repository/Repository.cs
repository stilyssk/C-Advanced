

using System.Collections.Generic;
namespace RepositoryNamespace
{
    public class Repository
    {
        private Dictionary<int, Person> person;
        private int nextID;
        public Repository()
        {
            this.nextID = 0;
            this.person = new Dictionary<int, Person>();
        }
        public void Add(Person person)
        {
            this.Persons = person;
        }

        public Person Persons
        {
            //get { return this.person; }

            set
            {
                this.person.Add(nextID++, value);
            }
        }

        public Person Get(int id)
        {

            return this.person[id];
        }

        public bool Update(int id, Person newPerson)
        {
            if (person.ContainsKey(id))
            {
                person[id] = newPerson;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            if (person.ContainsKey(id))
            {
                person.Remove(id);
                return true;
            }
            return false;
        }

        public int Count()
        {

            return person.Count;
        }
    }
}
