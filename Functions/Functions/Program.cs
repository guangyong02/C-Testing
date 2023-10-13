using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = -5, num2 = 3, num3;
            //unary operators
            num3 = -num1;
            Console.WriteLine(num3);
            bool isSunny = true;
            Console.WriteLine(!isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine(num);
            //post increment
            Console.WriteLine(num++);
            //pre increment
            Console.WriteLine(++num);
            //post decrement 
            Console.WriteLine(num--);
            //pre decrement
            Console.WriteLine(--num);
            int result = num1 + num2;
            Console.WriteLine("result of num1 +num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            //relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Result of num1 < num2 is {0}", isLower);

            //equality operator
            bool isEqual = num1 == num2;
            Console.WriteLine("Result of num1 ==num2 ={0}", isEqual);

            //Conditional operator 
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Result of isLower && isSunny is {0}", isLowerAndSunny);

            isLowerAndSunny = false || false;
            Console.WriteLine("Result of isLower && isSunny is {0}", isLowerAndSunny);


            //int num1 = 5, num2 = 0;
            //try
            //{
            //    Console.WriteLine(num1/num2);
            //}
            //catch (DivideByZeroException)
            //{

            //    Console.WriteLine("cannot divide by zero");
            //}









            //string name1 = "jiayin";
            //string name2 = "melvis";
            //string name3 = "myself";
            //Console.WriteLine( name1.Length);
            //Greeting(name1);
            //Console.WriteLine(Mal(2, 5));
            //Console.WriteLine(Devide(2, 5));
            //WriteSomethings();
            //WriteSomethingSpecific("I Like C#");
        }
        //access modified (static) return type method name (para1,para2)

        //public static void Greeting(string name)
        //{
        //    Console.WriteLine("Hi my friend : {0}", name);
        //}


        //public static int Add(int num1,int num2)
        //{
        //    return num1 + num2;
        //}
        //public static int Mal(int num1,int num2)
        //{
        //    return num1 * num2;
        //}

        public static double Devide(double num1, double num2) {
            return num1 / num2;
        }


















        static void WriteSomethings()
        {
            Console.WriteLine("I am called from a method");
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}