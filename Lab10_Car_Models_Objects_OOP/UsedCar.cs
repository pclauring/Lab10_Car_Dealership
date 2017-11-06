namespace Lab10_Car_Models_Objects_OOP
{
    class UsedCar : Car
    {
        private double mileage;

        public double Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        public UsedCar() : base()
        {
            this.mileage = 0;
        }

        public UsedCar(string make, string model, int year, double price, double mileage)
        : base(make, model, year, price)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $" {mileage} Miles";
        }
    }
}
