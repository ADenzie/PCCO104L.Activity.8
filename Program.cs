namespace PCCO104L.Encapsulation.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetroRailway MRT = new MetroRailway(60.00, "MRT", 1000, 20.00, "15 mins");
            MRT.SetLocation("North Avenue");
            MRT.SetOperator("Allen");
            MRT.Speed();

            LightRailway LRT = new LightRailway(50.00, "LRT", 800, 15.00, "10 mins");
            LRT.SetLocation("Baclaran");
            LRT.SetOperator("Daniel");
            LRT.Speed();

            ProvincialRailway PNR = new ProvincialRailway(40.00, "PNR", 600, 10.00, "20 mins");
            PNR.SetLocation("Binan");
            PNR.SetOperator("Denzie");
            PNR.Speed();
        }
    }

    public interface IRailway
    {
        void Speed();
        void SetLocation(string location);
        string GetLocation();
        void SetOperator(string operatorName);
        string GetOperator();
    }

    public abstract class Railway : IRailway
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        protected double Fare { get; set; }
        protected string ETA { get; set; }

        private double _Speed { get; set; }
        private string _Location { get; set; }
        private string _Operator { get; set; }

        public Railway()
        {
            _Location = "Unknown";
            _Operator = "Unknown";
        }

        public Railway(double speed, string name, double fare, string eta) : this()
        {
            _Speed = speed;
            Name = name;
            Fare = fare;
            ETA = eta;
        }

        public Railway(double speed, string name, int capacity, double fare, string eta) : this(speed, name, fare, eta)
        {
            Capacity = capacity;
        }

        public void Speed()
        {
            Console.WriteLine($"{Name} - {_Speed} km/h, Capacity: {Capacity}, Location: {_Location}, Operator: {_Operator}, Fare: {Fare}, ETA: {ETA}");
        }

        public void SetLocation(string location)
        {
            _Location = location;
        }

        public string GetLocation()
        {
            return _Location;
        }

        public void SetOperator(string operatorName)
        {
            _Operator = operatorName;
        }

        public string GetOperator()
        {
            return _Operator;
        }
    }

    public class MetroRailway : Railway
    {
        public MetroRailway(double speed, string name, int capacity, double fare, string eta) : base(speed, name, capacity, fare, eta)
        {
        }
    }

    public class LightRailway : Railway
    {
        public LightRailway(double speed, string name, int capacity, double fare, string eta) : base(speed, name, capacity, fare, eta)
        {
        }
    }

    public class ProvincialRailway : Railway
    {
        public ProvincialRailway(double speed, string name, int capacity, double fare, string eta) : base(speed, name, capacity, fare, eta)
        {
        }
    }
}
