namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Name = "MyAudiA3";
            myCar.MaxSpeed = 150;
            //Console.WriteLine("Max speed is {0}",myCar.MaxSpeed);
            Console.WriteLine(myCar.Name);
            Console.WriteLine(myCar.toString());



        }
    }
}