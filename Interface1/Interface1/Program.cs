namespace Interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            Console.WriteLine(t1.DurationInHours);
            Console.WriteLine(t2.DurationInHours);
            Console.WriteLine(t1.Equals(t2));
        }
    }
}