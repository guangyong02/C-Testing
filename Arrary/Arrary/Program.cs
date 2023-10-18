using Microsoft.VisualBasic;
using System;
using System.Net.NetworkInformation;

namespace Arrary
{
    internal class Program
    {
        static string[,] matrix =
        {
            {"1","5","0" },
            {"O","X","X"}, 
            {"X","O","O"}
        };
        static void Main(string[] args)
        {
            Console.WriteLine(checkWin(matrix));

















            //for (int i = 0,j= 0; i < matrix.GetLength(0); i++,j++)
            //{
            //    matrix[i,j] = 1;
            //}
            //for (int i = 0, j = matrix.GetLength(0) - 1; i < matrix.GetLength(0); i++, j--)
            //{
            //    Console.WriteLine(matrix[i, j]);
            //}
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    Console.WriteLine(matrix[i, matrix.GetLength(0) - 1 - i]);
            //}
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    //second dimension
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {

            //        Console.Write(matrix[i, j]+ " ");
            //    }
            //    Console.WriteLine();
            //}
            //foreach (int item in matrix)
            //{

            //    Console.WriteLine(item);
            //    //foreach(int value in item)
            //    //{
            //    //    Console.WriteLine(value);
            //    //}
            //}
            ////first dimension
            //Console.WriteLine(matrix.GetLength(0));
            ////Second dimension
            //Console.WriteLine(matrix.GetLength(1));
            //for (int i=0; i < matrix.GetLength(0); i++)
            //{
            //    //second dimension
            //    for (int j=0 ; j < matrix.GetLength(1); j++)
            //    {

            //        Console.Write(i==j? matrix[i, j]:"");
            //    }
            //    Console.WriteLine();
            //}



            //string[,] matrix;

            ////3D array
            //int[,,] threeD;

            ////two dimentional array 2D

            //int[,] array2D = new int[,]
            //{
            //    {1,2,3 },
            //    {4,5,6},
            //    {7,8,9}
            //};
            //Console.WriteLine(array2D[2, 0]);

            //string[,,] array3D = new string[,,]
            //{
            //    {
            //        {"000", "001"},
            //        { "010", "011"},
            //        {"Hi There" ,"What Up"}
            //    },
            //    {
            //        { "100", "001"},
            //        { "110","111"},
            //        {"Hi There2" ,"What Up2"}
            //    }
            //};

            //string[,] array2DString = new string[3, 2]
            //{
            //    {"one", "two"},
            //    { "three", "four"},
            //    {"five" ,"six"}
            //};
            //Console.WriteLine(array2DString[1,1]);
            //array2DString[1, 1] = "chicken";
            //Console.WriteLine(array2DString[1, 1]);

            ////rank return the dimensions
            //Console.WriteLine(array2DString.Rank);
            //Console.WriteLine(array3D[1,2,1]);

            //int[,] helo =new int[2,2];
            //helo[0,0]=1;
            //helo[0, 1] = 2;
            //helo[1, 0] = 3;
            //helo[1, 1] = 4;
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < numbers.Length; i+=2)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string? input;
            //do {  
            //    input = Console.ReadLine(); 
            //} while (!int.TryParse(input, out _));




            //int.TryParse("2",out int helo);



            //int[] nums=new int[10];
            //for(int i = 0; i < 10; i++)
            //{
            //    nums[i] = i+10; 
            //}
            //for (int j = 0; j < nums.Length; j++)
            //{
            //    Console.WriteLine(nums[j]);
            //}

            //foreach (int z in nums)
            //{
            //    Console.WriteLine(z);
            //}

            //string[] friends = { "Jayden", "Melvis", "Jiayin", "Jeff", "Kaiyu" };

            //foreach (string z in friends)
            //{
            //    Console.WriteLine("Helo, how are u {0}",z);
            //}







            //int[]  grades = new int[5];
            //grades[0] = 20;
            //grades[1] = 15;
            //grades[2] = 10;
            //grades[3] = 5;
            //grades[4] = 8;


            //int.TryParse(Console.ReadLine(),out grades[0]);

            //Console.WriteLine("Grades at index 0 :{0}", grades[0]);
            //int[] gradesOfMath = { 20, 12, 13, 8, 9 };

            //int[] gradesOfMath2 = new int[5] {1,2,3, 4, 5};

            //Console.WriteLine(gradesOfMath.Length) ;
        }

        static bool checkWin(string[,] matrix)
        {
            string temp = "", temp2 = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                temp += matrix[i, i];
            }
            Console.WriteLine(temp);
            Console.WriteLine(checkLine(temp));
            if (!(temp.Contains("X") && temp.Contains("O")))
                return true;
            temp = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                temp += matrix[i, matrix.GetLength(0) - 1 - i];
            }
            Console.WriteLine(temp);
            Console.WriteLine(checkLine(temp));
            if (!(temp.Contains("X") && temp.Contains("O")))
                return true;
            temp = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    temp += matrix[i, j];
                    temp2 += matrix[j, i];
                }
                Console.WriteLine(temp);
                Console.WriteLine(checkLine(temp));
                if (!(temp.Contains("X") && temp.Contains("O")))
                    return true;
                Console.WriteLine(temp2);
                Console.WriteLine(checkLine(temp2));
                if (!(temp2.Contains("X") && temp2.Contains("O")))
                    return true;
                temp = "";
                temp2 = "";
            }
            return false;
        }
        static bool checkLine(string line)
        {
            
            //return !(line.Contains("X")&&line.Contains("O")) && (line.Contains("X")|| line.Contains("O"));
            return line[0] == line[1]&& line[1] == line[2];
        }

    }
}