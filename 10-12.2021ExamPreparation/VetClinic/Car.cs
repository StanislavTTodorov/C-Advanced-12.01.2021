namespace VetClinic
{
    public class Car
    {
        private string name;
        private int speed;

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
            Name = name;
            Speed = speed;                                     
        }
        public int Speed { get; set; }

        public string Name { get; set; }
    }
}