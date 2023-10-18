using System.Collections.Generic;
using System.Xml.Serialization;

namespace ListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<> number = new List<int> { 1, 2, 3, 4, 5, 6 };
            var solutionEven = new List<int>();
            // TODO: write your solution here
            for (int x = 100; x <= 170; x += 2)
            {
                solutionEven.Add(x);
            }
            foreach (int y in solutionEven)
            {
                Console.WriteLine(y);
            }
        }
    }
}