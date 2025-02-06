using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Numerics;
using System;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace Assignment1_C_
{
    internal class Program
    {
        public static int TryToParse(string message)
        {
            int result;
            bool isParsed;
            do
            {
                Console.Write(message);
                isParsed = int.TryParse(Console.ReadLine(), out result);
                if (!isParsed)
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                }
            }
            while (!isParsed);
            return result;
        }

        public static void ReveseTheQueue(Queue<int> queue)
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

        static bool IsBalanced(string parentheses)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in parentheses)
            {
                if (c == '[' || c == '(' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ']' || c == ')' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((c == ']' && top != '[') || (c == ')' && top != '(') || (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        public static void RemoveOddNumbers(ArrayList list)
        {
            for (int i = 0; i < list.Count ; i++)
            {
                if ((int)list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
        }

        public static void PushInStack(Stack<int> stack , int numberOfItems)
        {
            for (int i = 0; i <= numberOfItems; i++)
            {
                stack.Push(TryToParse($"Please Enter Item {i + 1} :"));
            }
        }

        public static void SearchInStack(Stack<int> stack)
        {
            int target = TryToParse("Enter the target number:");

            int count = 0;
            bool found = false;

            foreach (int i in stack)
            {
                count++;
                if (i == target)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"Target was found successfully and the count = {count}");
            else
                Console.WriteLine("Target was not found");
        }

        public static List<int> FindIntersection(int[] arr1, int[] arr2)
        {
            var dict = new Dictionary<int, int>();
            var result = new List<int>();

            foreach (int num in arr1)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }

            foreach (int num in arr2)
            {
                if (dict.ContainsKey(num) && dict[num] > 0)
                {
                    result.Add(num);
                    dict[num]--;
                }
            }

            return result;
        }

        public static List<int> FindSublistWithSum(List<int> nums, int target)
        {
            int currentSum = 0;
            int start = 0;

            for (int end = 0; end < nums.Count; end++)
            {
                currentSum += nums[end];

                while (currentSum > target && start <= end)
                {
                    currentSum -= nums[start];
                    start++;
                }

                if (currentSum == target)
                    return nums.GetRange(start, end - start + 1);
            }

            return new List<int>(); 
        }

        static void Main(string[] args)
        {
            // - 1
            //Given an array consists of numbers with size N and number of
            //queries, in each query you will be given an integer X, and you should
            //print how many numbers in array that is greater than X.

            //int n = TryToParse("Please Enter Size of array :");
            //int q = TryToParse("Please Enter number of queries :");

            //Console.WriteLine("Please Enter The Array :");

            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = TryToParse($"Enter element {i + 1}: ");
            //}

            //for (int i = 0; i < q; i++)
            //{
            //    int x = TryToParse($"Please Enter Query{i + 1} : ");
            //    int count = arr.Count(num => num > x);
            //    Console.WriteLine(count);
            //}

            // - 2
            //Given a number N and an array of N numbers. Determine if it's
            //palindrome or not.

            //int arraySize = TryToParse("Please Enter Size of array :");

            //Console.WriteLine("Please Enter The Array :");

            //int[] arr = new int[arraySize];
            //for (int i = 0; i < arraySize; i++)
            //{
            //    arr[i] = TryToParse($"Enter element {i + 1}: ");
            //}

            //bool isPalindrome = true;

            //for (int i = 0; i < arraySize / 2; i++)
            //{
            //    if (arr[i] != arr[arraySize - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isPalindrome ? "YES" : "NO");

            // - 3
            //Given a Queue, implement a function to reverse the elements of a
            //queue using a stack.

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //foreach (int i in queue)
            //    Console.WriteLine(i);

            //ReveseTheQueue(queue);

            //Console.WriteLine("========== After Reverse ============");

            //foreach (int i in queue)
            //    Console.WriteLine(i);

            // - 4
            //Given a Stack, implement a function to check if a string of
            //parentheses is balanced using a stack.

            //string input = "[]";
            //Console.WriteLine(IsBalanced(input) ? "Balanced" : "Not Balanced");

            //string input2 = "[]]";
            //Console.WriteLine(IsBalanced(input2) ? "Balanced" : "Not Balanced");

            // - 5
            //Given an array, implement a function to remove duplicate elements
            //from an array

            //int[] numbers = { 1, 2, 3, 3, 3, 3, 4, 5, 6, 7 };

            //HashSet<int> set = new HashSet<int>(numbers);

            //foreach (int i in set)
            //    Console.WriteLine(i); 


            // - 6
            //Given an array list, implement a function to remove all odd numbers
            //from it.

            //ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //RemoveOddNumbers(numbers);

            //foreach (object i in numbers)
            //    Console.WriteLine(i);

            // - 7
            // Implement a queue that can hold different data types. 

            //Queue queue = new Queue();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (object i in queue)
            //    Console.WriteLine(i);

            // - 8
            //Create a function that pushes a series of integers onto a stack. Then,
            //search for a target integer in the stack.If the target is found, print a
            //message indicating that the target was found how many elements were
            //checked before finding the target(“Target was found successfully and
            //the count = 5”).If the target is not found, print a message indicating that
            //the target was not found(“Target was not found”).

            //Stack<int> numbers = new Stack<int>();

            //PushInStack(numbers, 5);

            //SearchInStack(numbers);

            // - 9
            //Given two arrays, find their intersection.Each element in the result
            //should appear as many times as it shows in both arrays

            //int[] arr1 = { 1, 2, 3, 4, 4 };
            //int[] arr2 = { 10, 4, 4 };

            //var intersection = FindIntersection(arr1, arr2);

            //Console.WriteLine(string.Join(",", intersection));

            // - 10
            //Given an ArrayList of integers and a target sum, find if there is a
            //contiguous sub list that sums up to the target.

            //List<int> nums = new List<int> { 1, 2, 3, 7, 5 };
            //int target = 12;

            //var result = FindSublistWithSum(nums, target);

            //if (result.Count > 0)
            //    Console.WriteLine(string.Join(", ", result));

            // - 11
            //Given a queue reverse first K elements of a queue, keeping the
            //remaining elements in the same order

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            int reversedNumber = TryToParse("Please enter the number of elements you want to reverse: ");

            List<int> reversedElements = new List<int>();

            for (int i = 0; i < reversedNumber; i++)
            {
                reversedElements.Add(queue.Dequeue());
            }

            reversedElements.Reverse();
            foreach (int element in reversedElements)
            {
                queue.Enqueue(element);
            }

            int remainingElements = queue.Count - reversedNumber;
            for (int i = 0; i < remainingElements; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            foreach (int i in queue)
                Console.WriteLine(i);

        }
    }
}
