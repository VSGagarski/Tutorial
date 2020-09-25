namespace TutorialCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Man();


            var bmw1 = new Car("Bmw", 120, new Engine());
            var bmw2 = new Car("Bmw2", 120, new Engine());
            var horse = new Horse() {Name = "Horse"};
            var su31 = new AirPlane();


            player.MoveFromAtoB(bmw1);

            player.MoveFromAtoB(bmw2);

            player.MoveFromAtoB(horse);

            player.MoveFromAtoB(su31);


        }
    }

}
