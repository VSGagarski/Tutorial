namespace TutorialCSharp
{
    public class Car : Vehicle
    {
        public Car(string name, int maxSpeed, Engine engine)
        : base(name)
        {
            this.MaxSpeed = maxSpeed;

            EngineBase = engine;

        }

        public Engine EngineBase { get; set; }
        private int _maxSpeed;
        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value > 999)
                {
                    System.Console.WriteLine("MaxSpeed not valid!");
                    return;
                }
                _maxSpeed = value;
            }
        }
        public int Test { get; set; }

        internal void GetInfo()
        {
            System.Console.WriteLine(_name);
        }

        public override void StartEngine()
        {
            EngineBase.Start();
        }




    }
}
