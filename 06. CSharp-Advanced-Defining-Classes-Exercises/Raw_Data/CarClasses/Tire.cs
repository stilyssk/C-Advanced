
public class Tire
{
    private double pressure;
    private int age;
    public Tire(double pressure, int age)
    {

        this.Pressure = pressure;
        this.Age = age;
    }

    public Tire()
    {
        
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public double Pressure
    {
        get { return this.pressure; }
        set { this.pressure = value; }
    }

}
