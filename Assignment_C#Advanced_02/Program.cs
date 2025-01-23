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
        }
    }
}










