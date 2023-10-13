namespace Contition
{
    internal class Program
    {
        static int highScore=0;
        static string highScorePlayer;
        static void Main(string[] args)
        {

            checkHighScore();
            Console.WriteLine(highScore);
            Console.WriteLine(highScorePlayer);

            //int age; 
            //int.TryParse(Console.ReadLine(),out age);
            //switch (age)
            //{
            //    case <18:
            //        Console.WriteLine("Too young to party in the club");
            //        break;
            //    case >60:
            //        Console.WriteLine("Too Old to Fight!");
            //        break;
            //    default: Console.WriteLine("Just Party");
            //        break;
            //}




















            //Console.WriteLine("Register");
            //Console.WriteLine("Please enter your username:");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Please enter your Password:");
            //string userpassowrd = Console.ReadLine();
            //Console.WriteLine("Login");

            //Console.WriteLine("Please enter your username:");
            //string loginName = Console.ReadLine();
            //Console.WriteLine("Please enter your username:");
            //string loginpassowrd = Console.ReadLine();
            //if (userName.Equals(loginName)&&userpassowrd.Equals(loginpassowrd))
            //{
            //    Console.WriteLine("You are logged in");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong password or username!");
            //}










            //bool isAdmin = false, isRegistered = true;
            //Console.WriteLine("Please enter your username");
            //string userName = Console.ReadLine();

            //if (isRegistered && userName != "" && userName == "admin")
            //{
            //    Console.WriteLine("Hi there, registered user");

            //    Console.WriteLine("Hi there," +  userName);

            //    Console.WriteLine("Hi there, Admin");

            //}
            //if(isRegistered||isAdmin)
            //{
            //    Console.WriteLine("You are Log In");
            //}













            //int temperature;
            //string input = Console.ReadLine();
            //if(!int.TryParse(input, out temperature))
            //{
            //    Console.WriteLine("Please Enter correct Number");
            //}

            ////try
            ////{
            ////    temperature = int.Parse(input);
            ////}
            ////catch (Exception)
            ////{

            ////    Console.WriteLine("Opps pls enter the right number");
            ////}
            //if (temperature<25)
            //{
            //    Console.WriteLine("Take the coat");
            //}
            //else if (temperature > 35)
            //{
            //    Console.WriteLine("Stay at home");
            //}
            //else
            //{
            //    Console.WriteLine("Lets go!");
            //}
        }

        public static void checkHighScore()
        {
            int score;
            Console.WriteLine("Please enter your score:");
            string input = Console.ReadLine();
            int.TryParse(input,out score);
            if (score > highScore)
            {
                highScore = score;
                Console.WriteLine("Please enter your Name:");
                highScorePlayer = Console.ReadLine();
            }
            
        }
    }
}