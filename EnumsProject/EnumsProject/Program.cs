using System.ComponentModel.Design;

namespace EnumsProject
{

    enum Day { Monday, Tuesday,Wednesday,Thursday,Friday,Saturday, Sunday};
    enum Month { January=1,Febuary=10, March, April, May, June, July,August, September,
    October, November, December}

    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice=new Random();
            int numEyes;
            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1,7);
                Console.WriteLine(numEyes);
            }

            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 4);
                switch (numEyes)
                {
                    case 1: Console.WriteLine("Yes");break;
                    case 2: Console.WriteLine("Maybe");break;
                    default: Console.WriteLine("No"); break;
                }
            }








            //Console.WriteLine("Enter a number");

            //if (int.TryParse(Console.ReadLine(),out int test))
            //{
            //    Console.WriteLine(test);
            //}
            //else
            //{
            //    Console.WriteLine("Check the input!");
            //}
            //Console.WriteLine("Testing {0}", Math.Cos(Math.PI/180*50));
            //Math.Tan(50);



            //Console.WriteLine("Celling :"+Math.Ceiling(14.3));
            //Console.WriteLine("Floor : "+Math.Floor(13.3));

            //int num1 = 13;
            //int num2 = 9;
            //Console.WriteLine("The lower number is {0} between {1},{2}",Math.Min(num1,num2),num1,num2);
            //Console.WriteLine("The higer number is {0} between {1},{2}", Math.Max(num1, num2), num1, num2);
            //Console.WriteLine("3 power of 5 is {0}",Math.Pow(3,5));
            //Console.WriteLine("PI is {0}",Math.PI);

            //Console.WriteLine("Square root of 25 is {0}", Math.Sqrt(25));
            //Console.WriteLine("Always positive is {0}", Math.Abs(-23));
            //Console.WriteLine("Cos 0 is {0}", Math.Cos(50));

            //Day fr = Day.Friday;
            //Day sun = Day.Sunday;
            //Day a = Day.Friday;

            //Console.WriteLine(fr);
            //Console.WriteLine((int)Day.Monday);

            //Console.WriteLine((int)Month.January);
            //Console.WriteLine((int)Month.Febuary);
            //Console.WriteLine((int)Month.July);
        }
    }
}