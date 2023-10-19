namespace Interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair1 = new Chair("Books", "Woods");
            Chair officeChair2 = new Chair("Formal", "Plastic");

            Car dmgCar = new Car(120, "Sliver");

            dmgCar.DestroyablesNearby.Add(officeChair1);
            dmgCar.DestroyablesNearby.Add(officeChair2);

            dmgCar.Destroy();
        }
    }
}