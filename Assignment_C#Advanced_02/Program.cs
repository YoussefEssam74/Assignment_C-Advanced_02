namespace Assignment_C_Advanced_02
{
    internal class Program
    {
        static bool IsPalindrome(int[] array)
        {
            int N = array.Length;
            for (int i = 0; i < N / 2; i++)
            {
                if (array[i] != array[N - 1 - i])
                {
                    return false;
                }
            }
            return true; 
        }
        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        static void PrintQueue(Queue<int> queue)
        {
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Q1 How many numbers in array that is greater than  X ?
            //int N = int.Parse(Console.ReadLine());
            //
            //int Q = int.Parse(Console.ReadLine());
            //
            //
            //int[] array = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //
            //for (int i = 0; i < Q; i++)
            //{
            //    int X = int.Parse(Console.ReadLine());
            //
            //    int count = 0;
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (array[j] > X)
            //        {
            //            count++;
            //        }
            //    }
            //
            //    Console.WriteLine(count);
            //} 
            #endregion
            #region Q2 Is a Plaindrome ?
            //int N = int.Parse(Console.ReadLine());
            //int[] array = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //if (IsPalindrome(array))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion
            #region Q3 Reversed Queue
           // Queue<int> queue = new Queue<int>();
           // queue.Enqueue(1);
           // queue.Enqueue(2);
           // queue.Enqueue(3);
           // queue.Enqueue(4);
           // queue.Enqueue(5);
           // Console.WriteLine("Original Queue");
           // PrintQueue(queue);
           // ReverseQueue(queue);
           // Console.WriteLine("Reversed Queue");
           // PrintQueue(queue);
            #endregion
        }
    }
}










  






