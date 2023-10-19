namespace Structs
{
    internal class Program
    {

        //can implement interface but not classes
        struct Game
        {
            public string name, developer, releaseDate;
            public double rating;

            public Game(String name, string developer, double rating, string releaseDate)
            {
                this.name = name;
                this.developer = developer;
                this.rating = rating;
                this.releaseDate = releaseDate;
            }

            public void Display()
            {
                Console.WriteLine($"Game 1 is {name} and it is developed" +
               $" at {releaseDate} by {developer} with {rating} rating");
            }
        }
        static void Main(string[] args)
        {
            Game game1= new Game("League of Legend", "Riot", 91, "01.07.2000");

            //game1.name = "League of Legend";
            //game1.developer = "Riot";
            //game1.rating = 91;
            //game1.releaseDate = "01.07.2000";
            game1.Display();
        }
    }
}