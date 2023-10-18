using System.Collections;
using System.Transactions;

namespace ArrayListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring an arraylist with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            //declaring an arraylist with undefined amount of object
            ArrayList myArrayList2 = new ArrayList();
            
            myArrayList2.Add(4);
            myArrayList2.Add(4.42);
            myArrayList2.Add("helo");
            myArrayList2.Add(5);
            Console.WriteLine(myArrayList2.Count);
            foreach (var x in myArrayList2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Break");






            myArrayList.Add(1);
            myArrayList.Add(4.42);
            myArrayList.Add("helo");
            myArrayList.Add(5);
            myArrayList.Add(12.42);
            // remove the element with value
            myArrayList.Remove(12.42);
            // delete elememt at specific position
            myArrayList.RemoveAt(0);
            Console.WriteLine(myArrayList.Count);
            double sum = 0;
            foreach(var i in myArrayList)
            {
                if(i is int)
                {
                    sum += Convert.ToDouble(i);
                }else if (i is double)
                {
                    sum += (double)i;
                }
                else if(i is string)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(sum);
            sum = 0;
            foreach (object i in myArrayList)
            {
                if (i is int||i is double )
                {
                    sum += Convert.ToDouble(i);
                }
                else if (i is string)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(sum);
            var a = 5;
            Console.WriteLine((double)a);
        }
    }
}