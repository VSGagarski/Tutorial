namespace TutorialCSharp
{
    public abstract class Vehicle : IMoveable
    {

        public Vehicle(string name)
        {
            this._name = name;
            // EngineBase = new Engine();
        }


        internal readonly string _name;

        public string NameVehicle => _name;

        public void Init()
        {
            OpenLock();
            StartEngine();
            Move();
            Stop();
            StopEngine();
            CloseLock();
        }

        private void CloseLock()
        {
            System.Console.WriteLine("Lock closed!");
        }

        private void StopEngine()
        {

            System.Console.WriteLine("Engine Stop!");
        }

        private void Stop()
        {
            System.Console.WriteLine("Vehicle stop!");
        }

        public virtual void StartEngine()
        {

        }

        private void OpenLock()
        {
            System.Console.WriteLine("Lock opened!");
        }

        public virtual void Move()
        {
            System.Console.WriteLine($"Транспорт {_name} движется!");
        }
    }
}
