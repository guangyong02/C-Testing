namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            //method from parent 
            myRadio.SwtichOn();
            //method from child
            myRadio.ListenRadio();
            TV myTv = new TV(true, "Samsung");
            myTv.WatchingTV();
            Console.WriteLine(myTv.ToString());
        }
    }
}