using Microsoft.VisualBasic;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = new int[] { 3, 5, 8, 2, 6, 4 };
            MovieTime(happiness);
            foreach (int i in happiness)
            {
                Console.WriteLine(i);
            }


            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
           
            double averageResult=GetAverage(studentsGrades);
            Console.WriteLine(studentsGrades);
            Console.WriteLine(averageResult);

            //string[][] jaggedArrayFriend = new string[3][]
            //{
            //    new string[] {"Jayden","LingYen","LingJin"},
            //    new string[] {"Jiayin", "Jayden","Sister"},
            //    new string[] {"Melvis", "Jayden","Bob"}
            //};
            //foreach (string[] listFriend in jaggedArrayFriend)
            //{
            //    foreach(string name in listFriend)
            //    {
            //        Console.Write(name+ " ");
            //    }
            //    Console.WriteLine();
            //}




            ////declare jagged Array
            //int[][] jaggedArray = new int[3][];
            ////jaggedArray[0] = new int[5];
            ////jaggedArray[1] = new int[3];
            ////jaggedArray[2] = new int[2];

            //jaggedArray[0]=new int[]{1,2,4,5,3};
            //jaggedArray[1] = new int[]{ 1, 2, 4,5,7,8,9};
            //jaggedArray[2] = new int[]{ 1, 2 };
            //Console.WriteLine(jaggedArray[1][6]);

            //Console.WriteLine(jaggedArray[1].Length);
            //int[][] jaggedArray2 = new int[][]
            //{
            //    new int[]{1,2,4,5,6,7},
            //    new int[]{1,2,4 }

            //};
            //Console.WriteLine("The Value in the middle of the first entry is {0}", jaggedArray2[0][2]);
            //for (int i = 0; i < jaggedArray2.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray2[i].Length; j++)
            //    {
            //        Console.WriteLine(jaggedArray2[i][j]);
            //    }
            //}
            //foreach(var intArr in jaggedArray2)
            //{
            //    foreach (var z in intArr)
            //    {
            //        Console.WriteLine(z);
            //    }
            //}
        }

        static void MovieTime(int[] happiness)
        {
            for (int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }
        static double GetAverage(int[] gradesArray)
        {
            int size=gradesArray.Length;
            double average;
            int sum = 0;
            foreach (var item in gradesArray)
            {
                sum += item;
            }
            average = (double)sum / size;
            return average;
        }   

    }
}