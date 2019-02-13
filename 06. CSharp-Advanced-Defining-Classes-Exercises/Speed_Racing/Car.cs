public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionFor1Kilometer ;
    private int distance;

    public string PrintCarData()
    {
        return $"{MyModel} {MyFuelAmount:F2} {MyDistance}";
    }

    public string Drive(string model, int distance)
    {
        double needFuel = distance * MyFuelConsumptionFor1Kilometer;
        if ((MyFuelAmount-needFuel)>=0)
        {
            this.MyFuelAmount -= needFuel;
            this.MyDistance += distance;
            return null;
        }
        return $"Insufficient fuel for the drive";
    }

    public Car(string model, int fuelAmount, double fuelConsumptionFor1Kilometer)
    {
        this.MyModel = model;
        this.MyFuelAmount = fuelAmount;
        this.MyFuelConsumptionFor1Kilometer = fuelConsumptionFor1Kilometer;
        this.distance = 0;
    }

    public Car()
    {

    }

    public int MyDistance
    {
        get { return distance; }
        set { distance = value; }
    }

    public double MyFuelConsumptionFor1Kilometer
    {
        get { return fuelConsumptionFor1Kilometer ; }
        set { fuelConsumptionFor1Kilometer  = value; }
    }

    public double MyFuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }


    public string MyModel
    {
        get { return model; }
        set { model = value; }
    }

}
