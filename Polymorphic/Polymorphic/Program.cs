namespace Polymorphic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            M3 myM3 = new M3(300, "Sliver", "M3 Supper");
            myM3.Repair();

            myM3.SetCarIDInfo(22, "Jayden");
            myM3.GetCarIDInfo();






            //List<Car> cars = new List<Car>
            //{
            //    new BMW(250, "black", "M5"),
            //    new Audi(300, "Blue")
            //};

            //foreach (Car car in cars)
            //{
            //    car.Repair();
            //}

            //BMW mytesting1 = new BMW(330, "white", "W3");
            //Car mytestingCar = new BMW(330, "white", "W3");

            //mytesting1.ShowDetails();
            //mytesting1.Repair(); //override will only take the child method

            //Console.WriteLine("++++++++++++++++++");
            //((BMW)(mytestingCar)).ShowDetails(); //new will take the current state method
            //mytestingCar.Repair();


            //=======================================================

            //BMW myBmw = new BMW(250, "black", "M5");
            //Audi myAudi = new Audi(300, "Blue");
            //myBmw.ShowDetails();

            //myBmw.Repair();
            //myAudi.Repair();

            //myAudi.ShowDetails();
        }
    }
}