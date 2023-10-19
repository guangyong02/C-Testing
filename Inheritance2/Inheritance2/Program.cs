namespace Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Dog myDog = new Dog("Loke", 5,"Female");
            Console.WriteLine(myDog.Name +" " + myDog.Age+ " " + myDog.Gender);
            myDog.Eat();
            myDog.Play();
            myDog.MakeSound();
        }
    }
}