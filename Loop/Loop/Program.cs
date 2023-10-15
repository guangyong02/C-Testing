namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value,counter=0,total=0;
            do
            {
                Console.WriteLine("Enter score of student");
                if (int.TryParse(Console.ReadLine(), out value) && value!=-1)
                {
                    total += value;
                    counter++;
                }
            } while (value!=-1);
            Console.WriteLine("Average Score is {0}",(double)total/ (double)counter);





            //for (int i = 0; i < 10; i++) 
            //{
            //    if (i %2== 0)
            //    {
            //        Console.WriteLine("Skip at even num");
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}













            //for (int i = -3;i<=3; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //!< not work in C#

            //int counter = 3;
            //while ( counter >=-3)
            //{
            //    Console.WriteLine(counter--);
            //}





            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine("Enter Students go on the bus:");
            //    int temp;
            //    int.TryParse(Console.ReadLine(),out temp);
            //    counter += temp;
            //    Console.WriteLine(counter);
            //}





            //int lengthOfText = 0;
            //string wholeText = "";
            //do
            //{
            //    Console.WriteLine("Please enter the name of a friend:");
            //    string nameofFriend = Console.ReadLine();
            //    int currentLenght = nameofFriend.Length;
            //    lengthOfText += currentLenght;
            //    wholeText += nameofFriend;

            //} while (lengthOfText <20);
            //Console.WriteLine(wholeText);




            //for (int i = 1; i <= 20; i+=2)
            //{
            //    Console.WriteLine(i);
            //}





            //int check;
            //do
            //{
            //    Console.WriteLine("Enter A Number");
            //} while (!int.TryParse(Console.ReadLine(), out check));
            //Console.WriteLine(check);
        }
    }
}