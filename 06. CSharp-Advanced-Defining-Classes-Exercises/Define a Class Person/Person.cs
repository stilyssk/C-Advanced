
namespace PersonNamespace
{
    public class Person
    {
        private string name;
        private int age;
        public Person()
        {

        }
        public Person(string inputName,int inputAge)
        {
            this.Name = inputName;
            this.Age = inputAge;
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
