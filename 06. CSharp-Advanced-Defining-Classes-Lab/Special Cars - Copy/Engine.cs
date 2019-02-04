namespace Engine
{
    public class Engine
    {
        private int horsePower;

        private double cubicCapacity;


        public Engine(int horsePower,double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public double CubicCapacity
        {
            get { return this.cubicCapacity; }
            set { this.cubicCapacity = value; }
        }

        public int HorsePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }

    }
}
