namespace Oldstyle
{//Class name Like ClientAcitivity
    internal class Program
        //use nouns/noun phase for name of classes
    {
        //Method name like CalculateValue
        //Method arguments like firstNumber
        static void Main(string[] args)
        {
            //local variables like itemCount
            //use userControls intesad of usrCtr
            //dount use numbers at the start of variables names
            // try to avoid using _
            // unless _loginDate
            // try to avoid String/ Int32/Boolean 
            // use string/int/bool instead 

            Console.Write("Enter any string and press enter : ");
            string? name = Console.ReadLine();
            Console.WriteLine("You have entered "+name);
            Console.Write("Enter any key and press enter : ");
            int charASCIIV=Console.Read();
            Console.WriteLine("ASCII value of the entered values is " + charASCIIV);

            //Console.Write("helo");
            //Console.WriteLine("helow sd");
            //Console.WriteLine("heloSdw");
            //Console.Write("Name: ssdadw");
            //string checkreadLine =Console.ReadLine();
            //Console.Write("Name: {0}",checkreadLine);
            ////Read() will return int instead of char in C#
            ////Console.WriteLine()
            ////Console.ReadLine()
            //Console.ReadKey();

            //char checkread = (char)Console.Read();
            //Console.WriteLine(checkread);
            //int? helo=8;
            //Console.WriteLine(helo);
            //string testing1 = "hehe";
            //string testing2 = testing1;
            //testing1 = "hehe233";
            //Console.WriteLine(testing1);
            //Console.WriteLine(testing2);
            //testingString(testing1);
            //Console.WriteLine(testing1);




            //int num3, num4, num5;
            //int num1;
            //num1 = 13;
            //Console.WriteLine(num1);

            //int num2 = 14;
            //num2 = 100;
            //int sum = num1 + num2;
            //Console.WriteLine("num2 " + num2 + "+ num1 " + num1 + " = " + sum);

            ////wrong Console.WriteLine("num2 %d",num2 );
            //double d1 = 3.1415, d2 = 5.1;
            //double dDvi = d1 / d2;
            //Console.WriteLine("d1/d2 " + dDvi);
            //float f1 = 3.1415f, f2 = 5.1f;
            //float fDvi = f1 / f2;
            //Console.WriteLine("f1/f2 " + fDvi);
            ////Console.Read();
            //d1 = 3233.1415;
            //double dIDiv = d1 / num1;
            //Console.WriteLine(dIDiv);
            //int dIDivInt = (int)(d1 / num1);
            //Console.WriteLine(dIDivInt);
            //dIDivInt = (int)(d1) / num1;
            //Console.WriteLine(dIDivInt);
            //Console.ReadKey();
            //Console.Beep();
            //Console.WriteLine("Do You hear that ?!");
            //Console.Beep();
            //sbyte=-128 to 128
            //short =-32k to 32k
            // int = -2.1B to 2.1 B
            //long very big 
            /*float x = 99.99f;
            double y = 1.52312;
            decimal z = 1;*/
            //sbyte check = 0;
            //bool
            //char
            //string

            //Console.WriteLine(check + 5);
            //testingfunction(check);
        }

        ///<summary>
        ///Is this tewrue?
        ///</summary>
        static void testingfunction(sbyte num)
        {
            Console.WriteLine(num + 20);
        }

        ///<summary>
        ///Is this true?
        ///</summary>
        static void testingString(string testString)
        {
            Console.WriteLine(testString);
            testString = "omg";
            Console.WriteLine(testString);
            
        }

    }
}