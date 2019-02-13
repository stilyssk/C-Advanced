public class Car
{
    private Tire[] tires ;
    private Cargo cargo;
    private Engine engine;
    private string model;
    public Car(Tire[] tires, Cargo cargo, Engine engine, string model)
    {
//        this.Tires = new Tire[4];
        this.Tires = tires;
        this.Cargo = cargo;
        this.Engine = engine;
        this.Model = model;

    }


    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public Engine Engine
    {
        get { return this.engine; }
        set { this.engine = value; }
    }

    public Cargo Cargo
    {
        get { return this.cargo; }
        set { this.cargo = value; }
    }

    public Tire[] Tires
    {
        get { return this.tires; }
        set { this.tires = value; }
    }

}

