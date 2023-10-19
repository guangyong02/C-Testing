namespace InheritanceChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Trainees myTrainees = new Trainees("Jack","Teh",3200,5,7);
            Console.WriteLine(myTrainees.ToString());
            myTrainees.Work();
            myTrainees.Work();
            Console.ReadKey();
            myTrainees.Pause();
            Console.ReadKey();
            myTrainees.Work();
            Console.ReadKey();
            myTrainees.Learn();
            Boss myboss = new Boss("Jayden", "Teh", 5000, "Myvi");
            myboss.Lead();
            Console.WriteLine();
        }
    }
}