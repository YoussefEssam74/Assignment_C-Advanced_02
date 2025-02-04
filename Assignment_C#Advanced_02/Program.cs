using System.Collections;

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
        //static void PrintQueue(Queue<int> queue)
        //{
        //    foreach (int item in queue)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}
        static bool IsMatchingPair(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }
        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if (!IsMatchingPair(top, ch))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
        static int[] RemoveDuplicates(int[] array)
        {
            HashSet<int> uniqueSet = new HashSet<int>();

            foreach (int item in array)
            {
                uniqueSet.Add(item);
            }
            return uniqueSet.ToArray();
        }
        static void PrintCollection<T>(IEnumerable<T> collection, string separator = " ")
        {
            foreach (T item in collection)
            {
                Console.Write(item + separator);
            }
            Console.WriteLine();
        }
        static void RemoveOddNumbers(List<int> numbers)
        {
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers.RemoveAt(i);
                }
            }
        }

        static void PrintQueue(Queue queue)
        {
            foreach (object item in queue)
            {
                Console.WriteLine(item + " Type: " + item.GetType());
            }
        }
        static void SearchTargetInStack(Stack<int> stack, int target)
        {
            int count = 0; 
            bool isFound = false; 
            while (stack.Count > 0)
            {
                int current = stack.Pop(); 
                count++;

                if (current == target)
                {
                    isFound = true;
                    break; 
                }
            }

            if (isFound)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
            }
            else
            {
                Console.WriteLine("Target was not found");
            }
        }
        static void PushSeriesOntoStack(Stack<int> stack, int[] numbers)
        {
            foreach (int number in numbers)
            {
                stack.Push(number);
            }
        }
        static List<int> FindIntersection(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            bool[] used = new bool[nums2.Length];
            foreach (int num in nums1)
            {
                for (int i = 0; i < nums2.Length; i++)
                {
                    if (nums2[i] == num && !used[i])
                    {
                        result.Add(num);
                        used[i] = true;
                        break;
                    }
                }
            }

            return result;
        }
        static ArrayList FindSubList(ArrayList arrList, int targetSum)
        {
            for (int start = 0; start < arrList.Count; start++)
            {
                int sum = 0;
                ArrayList subList = new ArrayList();

                for (int end = start; end < arrList.Count; end++)
                {
                    sum += (int)arrList[end];
                    subList.Add(arrList[end]);

                    if (sum == targetSum)
                    {
                        return subList; // Found the sublist
                    }
                    if (sum > targetSum)
                    {
                        break; // Stop if sum exceeds target
                    }
                }
            }
            return new ArrayList(); // Return empty list if no sublist found
        }
        static Queue<int> ReverseFirstKElements(Queue<int> queue, int k)
        {
            if (k <= 0 || k > queue.Count) return queue; // Edge case check

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            // Move remaining elements to the back 
            for (int i = 0; i < queue.Count - k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            return queue;
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
            // PrintCollection(queue);
            // ReverseQueue(queue);
            // Console.WriteLine("Reversed Queue");
            // PrintCollection(queue);
            #endregion
            #region Q4 parentheses is balanced ?
            // string input1 = "[()]{}";
            // string input2 = "[(])";
            // string input3 = "({[]})";
            //
            // Console.WriteLine($"Is {input1} balanced? {IsBalanced(input1)}");
            // Console.WriteLine($"Is {input2} balanced? {IsBalanced(input2)}");
            // Console.WriteLine($"Is {input3} balanced? {IsBalanced(input3)}");
            #endregion
            #region Q5  Removing Duplicates
            // int[] array = { 1, 2, 3, 4, 2, 3, 5, 1, 3 };
            // 
            //   Console.WriteLine("Original Array ");
            //   PrintCollection(array);
            // 
            //   int[] uniqueArray = RemoveDuplicates(array);
            // 
            //   Console.WriteLine("Array after removing duplicates ");
            //   PrintCollection(uniqueArray);
            #endregion
            #region Q6 Remove Odd Numbers
            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //
            // Console.WriteLine("Original List");
            // PrintCollection(numbers);
            // RemoveOddNumbers(numbers);
            // Console.WriteLine("List after removing odd numbers");
            // PrintCollection(numbers);
            #endregion
            #region Q7 Mixed Queue
            //Queue mixedQueue = new Queue();
            //mixedQueue.Enqueue(1);         
            //mixedQueue.Enqueue("Apple");   
            //mixedQueue.Enqueue(5.28);      
            //Console.WriteLine("Mixed Queue Contents:");
            //PrintQueue(mixedQueue);
            #endregion
            #region Q8 SearchTargetInStack
            //Stack<int> stack = new Stack<int>();
            //PushSeriesOntoStack(stack, new int[] { 10, 20, 30, 40, 50, 60, 70 });
            //Console.Write("Enter the target integer to search for: ");
            //int target = int.Parse(Console.ReadLine());
            //SearchTargetInStack(stack, target);

            #endregion
            #region Q9 Intersection
            // int[] nums1 = { 1, 2, 3, 4, 4 };
            // int[] nums2 = { 10, 4, 4 };
            // List<int> intersection = FindIntersection(nums1, nums2);
            // Console.WriteLine("Intersection: [" + string.Join(", ", intersection) + "]");
            #endregion
            #region Q10 FindSubList
            // ArrayList arrList = new ArrayList { 1, 2, 3, 7, 5 };
            // int targetSum = 12;
            //
            // ArrayList subList = FindSubList(arrList, targetSum);
            //
            // Console.WriteLine(subList.Count > 0 ? $"[{string.Join(", ", subList.ToArray())}]" : "No sublist found");


            #endregion
            #region Q11 ReverseFirstKElements
           //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
           //int k = 3;
           //
           //Queue<int> result = ReverseFirstKElements(queue, k);
           //
           //Console.WriteLine($"[{string.Join(", ", result)}]");
            #endregion

        }
    }
}





