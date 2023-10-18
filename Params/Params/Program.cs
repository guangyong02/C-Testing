namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math.Min(1,3);

            Console.WriteLine(MinimumV2(14, 23, 4, 5, -22, 4, 1, 3));
            //14, 23, 4, 5, 2, 4, 1, 3 vs new int[] { 14, 23, 4, 5, 2, 4, 1, 3 }
            Console.WriteLine(MinimumV22(new int[] { 14, 23, 4, 5, -22, 4, 1, 3 }));

            //int price = 50;
            //float pi = 3.14f;
            //char at = '@';
            //string book = "The King";
            //string[] testing = { "1230", "helo", "oops" };
            //ParamsMethod("1230", "helo", "oops");
            //OwnParamsMethod(new string[]{ "1230", "helo", "oops" ,"Walaos"});
            //ParamsMethod2(price, pi, at,book);

            //int sum1=Sum(1,3,2,4,5);
            //Console.WriteLine(sum1);
            //Console.WriteLine(Average(1, 3, 2, 4, 5));
















        }
        public static int MinimumV2(params int[] nums)
        {
            int min = int.MaxValue;
            foreach(int i in nums)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        public static int MinimumV22(int[] nums)
        {
            int min = int.MaxValue;
            foreach (int i in nums)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        public static double Average(params int[] nums)
        {
            int total = 0,count=0;
            foreach (int i in nums)
            {
                total += i;
                count++;
            }
            return total/count;
        }


        public static int Sum(params int[] nums)
        {
            int total=0;
            foreach (int i in nums)
            {
                total += i;
            }
            return total;
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object o in stuff)
            {
                Console.Write(o +" ");
            }
        }



        public static void OwnParamsMethod(string[] sentences)
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                Console.WriteLine(sentences[i]);
            }
        }
        public static void ParamsMethod(params string[] sentences)
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                Console.WriteLine(sentences[i]);
            }
        }
    }
}