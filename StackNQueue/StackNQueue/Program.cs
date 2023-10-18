namespace StackNQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }
            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                Order o = ordersQueue.Dequeue();
                Console.WriteLine(o.OrderId+" Has Been Process");
            }



            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine( queue.Peek());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}




            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //Console.WriteLine(stack.Peek());
            //stack.Push(2);
            //Console.WriteLine(stack.Peek());
            //stack.Push(3);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            //int[] numbers=new int[] {8,2,3,4,7,6,2,1};
            //Console.WriteLine("The numbers in the array are:");

            //foreach (int i in numbers)
            //{
            //    Console.Write(i+" ");
            //    stack.Push(i);
            //}
            //Console.WriteLine();
            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop()+" ");
            //}
        }

        static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }
        static Order[] ReceiveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }
    }
}