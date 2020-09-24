using System;

namespace TutorialCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var bmw = new Car("Bmw", 250);

            

            bmw.GetInfo();

            System.Console.WriteLine(bmw.MaxSpeed);

            bmw.MaxSpeed = 1000;

            System.Console.WriteLine(bmw.MaxSpeed);
            // System.Console.WriteLine(bmw.GetMaxSpeed());

            // bmw.SetMaxSpeed(300);

            // System.Console.WriteLine(bmw.GetMaxSpeed());
            bmw.Move();
            var su31 = new AirPlane("Su31");

            su31.Move();


        }
    }

    public class Vehicle
    {
        public Vehicle(string name)
        {
            this._name=name;
        }
        internal readonly string _name;
        public virtual void Move()
        {
            System.Console.WriteLine($"Транспорт {_name} движется!");
        }
    }

    public class Car : Vehicle
    {
        public Car(string name, int maxSpeed)
        : base(name)
        {
            this.MaxSpeed = maxSpeed;
           
        }
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
     
    }

    class AirPlane : Vehicle
    {
        public AirPlane(string name) : base(name)
        {

        }

        public override void Move()
        {
            System.Console.WriteLine($"Airplane {_name} fly!");
        }
    }
}
