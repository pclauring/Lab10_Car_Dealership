namespace Lab10_Car_Models_Objects_OOP
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;

        public Car()
        {
            this.make = "";
            this.model = "";
            this.year = 0;
            this.price = 0;
        }

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public override string ToString()
        {
            return $"{make,-12}{model,-10}{year,6} {price,9:C}";
        }
    }
}
