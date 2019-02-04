
namespace DefiningClasses
{
    using Person;

    public class StartUp
    {
        static void Main(string[] args)
        {
            Person inlinePerson = new Person("Pesho", 20);
            Person defaultConstructorPerson = new Person()
            {
                Name = "Gosho",
                Age = 18
            };
            Person defaultConstructorSecondVariant = new Person();
            defaultConstructorSecondVariant.Name = "Stamat";
            defaultConstructorSecondVariant.Age = 43;
            Person devaultConsructorWithIntInput = new Person(20);
        }
    }
}
