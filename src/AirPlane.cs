namespace TutorialCSharp
{
    class AirPlane : IMoveable
    {
        public string NameVehicle => "Su31";

        public void Move()
        {
            System.Console.WriteLine($"Fly on {NameVehicle}");
        }
    }
}
