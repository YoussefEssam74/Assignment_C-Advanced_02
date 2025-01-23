using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_C_Advanced_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Arraylist
        // Console.WriteLine("--- ArrayList ---");
        // ArrayList arrayList = new ArrayList();
        // arrayList.Add(10); // Add elements
        // arrayList.Add("Hello");
        // arrayList.Add(3.14);
        // Console.WriteLine("ArrayList Elements:");
        // foreach (var item in arrayList)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine("Contains 'Hello': " + arrayList.Contains("Hello"));
        // arrayList.Remove(10); // Remove an element
        // Console.WriteLine("After removing 10:");
        // foreach (var item in arrayList)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine();
        //Methods:
        //   Add(object): Adds an element to the ArrayList.
        //
        //   Remove(object): Removes the first occurrence of an element.
        //
        //    Contains(object): Checks if an element exists in the ArrayList.
        #endregion
        #region List
        // Console.WriteLine("--- List<T> ---");
        // List<int> list = new List<int> { 1, 2, 3, 4, 5 }; // Initialize with elements
        // list.Add(6); // Add an element
        // list.Remove(3); // Remove an element
        // Console.WriteLine("List Elements:");
        // foreach (int item in list)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine("Index of 4: " + list.IndexOf(4)); // Find the index of an element
        // Console.WriteLine();

        // Methods:

        // Add(T): Adds an element to the list.
        //
        //Remove(T): Removes the first occurrence of an element.
        //
        // IndexOf(T): Returns the index of an element.
        #endregion
        #region LinkedList
        // Console.WriteLine("--- LinkedList<T> Demo ---");
        // LinkedList<string> linkedList = new LinkedList<string>();
        // linkedList.AddLast("Essam"); // Add elements to the end
        // linkedList.AddLast("Youssef");
        // linkedList.AddFirst("Cherry"); // Add elements to the beginning
        // Console.WriteLine("LinkedList Elements:");
        // foreach (string item in linkedList)
        // {
        //     Console.WriteLine(item);
        // }
        // linkedList.Remove("Youssef"); // Remove an element
        // Console.WriteLine("After removing 'Youssef':");
        // foreach (string item in linkedList)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine();
        //Methods:
        //
        //    AddLast(T): Adds an element to the end of the list.
        //
        //    AddFirst(T): Adds an element to the beginning of the list.
        //
        //    Remove(T): Removes the first occurrence of an element.
        #endregion
        #region Stack
        //  Console.WriteLine("--- Stack<T> Demo ---");
        //  Stack<int> stack = new Stack<int>();
        //  stack.Push(10); // Push elements
        //  stack.Push(20);
        //  stack.Push(30);
        //  Console.WriteLine("Stack Elements:");
        //  foreach (int item in stack)
        //  {
        //      Console.WriteLine(item);
        //  }
        //  Console.WriteLine("Popped Element: " + stack.Pop()); // Pop an element
        //  Console.WriteLine("Peeked Element: " + stack.Peek()); // Peek at the top element
        //  Console.WriteLine();
       //Methods:
       //
       //    Push(T): Adds an element to the top of the stack.
       //
       //    Pop(): Removes and returns the top element.
       //
       //    Peek(): Returns the top element without removing it.
            #endregion



        }
    }
}
