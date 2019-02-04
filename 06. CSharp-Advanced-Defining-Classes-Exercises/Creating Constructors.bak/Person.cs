
namespace Person
{
    public class Person
    {
        private string name;
        private int age;
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int inputAge)
        {
            this.Age = inputAge;
            this.Name = "No name";
        }
        public Person(string inputName,int inputAge)
        {
            this.Name = inputName;
            this.Age = inputAge;
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

    }
}
