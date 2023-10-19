namespace IEnumerable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            CollectionSum(list);
            int[] intArray = { 4, 5, 6 };
            CollectionSum(intArray);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            CollectionSum(queue);
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);
            CollectionSum(stack);








            //IEnumerable<int> unknownCollection = GetCollection(1);
            //foreach (int i in unknownCollection)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("===================================");

            //unknownCollection = GetCollection(2);
            //foreach (int i in unknownCollection)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("===================================");
            //unknownCollection = GetCollection(3);
            //foreach (int i in unknownCollection)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("===================================");
            //unknownCollection = GetCollection(4);
            //foreach (int i in unknownCollection)
            //{
            //    Console.WriteLine(i);
            //}
        }

        static void CollectionSum(IEnumerable<int> anyCollection) {
            int sum = 0;
            foreach (int i in anyCollection)
            {
                sum += i;
            }
            Console.WriteLine("Sum is {0}", sum);

        }














        static IEnumerable<int> GetCollection(int count)
        {           
            switch (count)
            {
                case 1://List
                    List<int> list = new List<int>() { 1, 3, 4, 5, 6, 7, 8 }; 
                    return list;
                    break;
                case 2:
                    //Queue
                    Queue<int> q = new Queue<int>();

                    q.Enqueue(11);
                    q.Enqueue(12);
                    q.Enqueue(13);
                    q.Enqueue(14);
                    q.Enqueue(15);
                    q.Enqueue(16); 
                    return q;break;
                case 3://Stack
                    Stack<int> stack = new Stack<int>();
                    stack.Push(33);
                    stack.Push(34);
                    stack.Push(35);
                    stack.Push(36);
                    stack.Push(37);
                    stack.Push(38);
                    return stack; break;
                //Array
                default: return new int[] { 22, 23, 24, 25, 26 };break;
            }            
        }
    }
}