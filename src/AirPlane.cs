namespace TutorialCSharp
{
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
