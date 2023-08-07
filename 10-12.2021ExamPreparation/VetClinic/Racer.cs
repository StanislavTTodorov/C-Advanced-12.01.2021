namespace VetClinic
{
    public class Racer
    {
        private string name;

        private int age;

        private string country;

        private Car car;

        public Racer(string v1, int v2, string v3, Car car)
        {
            this.name = v1;
            this.age = v2;
            this.country = v3;
            this.car = car;

            Name = this.name;
            Age = this.age;
            Country = this.country;
            MyCar = this.car;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public Car MyCar { get; set; }

        public override string ToString()
        {
            return $"Racer: {Name}, {Age} ({Country})";
        }

    }
}