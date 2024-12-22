using System;
using System.Globalization;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            //Console.WriteLine("Please Enter Your Number Can be divided by 3 and 4 :");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            // if (!flag)
            // {
            //     Console.WriteLine("Please Enter a valid number");
            //     return;
            // }
            //if (number % 3 == 0 && number % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            // 2
            //Console.WriteLine("Please Enter Your Number :");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}
            //if (number < 0)
            //    Console.WriteLine("Negative Number");
            //else if (number > 0 )
            //    Console.WriteLine("Positive Number");
            //else
            //    Console.WriteLine("Zero");

            // 3
            //int[] numbers = new int[3];

            //for (int i = 0; i < 3;)
            //{
            //    Console.WriteLine($"Please Enter Your Number {i + 1} :");
            //    bool flag = int.TryParse(Console.ReadLine(), out int number);
            //    if (flag)
            //    {
            //        numbers[i] = number;
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please Enter a valid number ");
            //    }
            //}

            //Console.WriteLine($"Max Number is => {numbers.Max()}");
            //Console.WriteLine($"Min Number is => {numbers.Min()}");

            // 4
            //Console.WriteLine("Please Enter Your Number :");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}
            //// check if the number is even or odd
            //if (number % 2 == 0)
            //    Console.WriteLine("Even Number");
            //else
            //    Console.WriteLine("Odd Number");

            // 5
            //Console.WriteLine("Please Enter Your Character :");
            //bool flag =char.TryParse(Console.ReadLine() , out char character);
            //if (!flag)
            //{
            //    Console.WriteLine("Please Enter a valid character");
            //    return;
            //}

            //character = char.ToLower(character);

            //if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            //    Console.WriteLine("Vowel");
            //else
            //    Console.WriteLine("Consonant");

            // 6
            //Console.WriteLine("Please Enter Your Number :");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}
            //// print all numbers from 1 to the number
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 7
            //Console.WriteLine("Please Enter Your Number :");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}
            //// print the multiplication table of the number
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{number} * {i} = {number * i}");
            //}

            // 8
            //Console.WriteLine("Please Enter Your Number :");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}
            //// print all even numbers from 1 to the number
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            // 9
            //int[] numbers = new int[2];

            //for (int i = 0; i < 2;)
            //{
            //    Console.WriteLine($"Please Enter Number {i + 1}");
            //    bool flag = int.TryParse(Console.ReadLine(), out int number);

            //    if (flag)
            //    {
            //        numbers[i] = number;
            //        ++i;
            //    }
            //}

            //// prints the power of the first number to the second number
            //Console.WriteLine(Math.Pow(numbers[0], numbers[1]));

            // 10
            //double[] numbers = new double[5];

            //for (int i = 0; i < numbers.Length;)
            //{
            //    Console.WriteLine($"Please Enter Mark of subject {i + 1} :");
            //    bool flag = double.TryParse(Console.ReadLine(), out double number);
            //    if (!flag || number > 100)
            //    {
            //        Console.WriteLine("Please Enter a valid Mark ");
            //    }
            //    else
            //    {
            //        numbers[i] = number;
            //        i++;
            //    }
            //}

            //double total = numbers.Sum();
            //double average = (double)numbers.Average();
            //double percentage = (total / 500) * 100;

            //Console.WriteLine($"Total Marks : {total}");
            //Console.WriteLine($"Average Marks : {average}");
            //Console.WriteLine($"Percentage : {percentage}%");

            // 11
            //Console.WriteLine("Please Enter Month Number :");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag || number > 12)
            //{
            //    Console.WriteLine("Please Enter a valid Month Number");
            //    return;
            //}
            //// Print number of day in the week
            //if(number == 2)
            //    Console.WriteLine("28 or 29 days");
            //else if (number == 4 || number == 6 || number == 9 || number == 11)
            //    Console.WriteLine("30 days");
            //else
            //    Console.WriteLine("31 days");

            // 12
            //int[] numbers = new int[5];

            //for (int i = 0; i < 2;)
            //{
            //    Console.WriteLine($"Please Enter Number {i + 1}");
            //    bool flag = int.TryParse(Console.ReadLine(), out int number);

            //    if (flag)
            //    {
            //        numbers[i] = number;
            //        ++i;
            //    }
            //}

            //// prints the sum of the numbers
            //Console.WriteLine($"{numbers[0]} + {numbers[1]} => {numbers[0] + numbers[1]}");
            //Console.WriteLine($"{numbers[0]} - {numbers[1]} => {numbers[0] - numbers[1]}");
            //Console.WriteLine($"{numbers[0]} * {numbers[1]} => {numbers[0] * numbers[1]}");
            //Console.WriteLine($"{numbers[0]} / {numbers[1]} => {numbers[0] / numbers[1]}");
            //Console.WriteLine($"{numbers[0]} % {numbers[1]} => {numbers[0] % numbers[1]}");

            // 13
            //Console.WriteLine("Please Enter Your String :");
            //string str = Console.ReadLine();

            //char[] charArray = str.ToCharArray(); 
            //Array.Reverse(charArray);             
            //Console.WriteLine(new string(charArray));

            // 14
            //Console.WriteLine("Please Enter Your Number To Reverse It :");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}

            //// Reverse the number
            //int reversed = 0;
            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reversed = reversed * 10 + digit;
            //    number /= 10;
            //}

            //Console.WriteLine("Reversed Number => " + reversed);

            // 15
            //Console.WriteLine("Input starting number of range :");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int start);
            //if (!flag1)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}

            //Console.WriteLine("Input ending number of range :");
            //bool flag2 = int.TryParse(Console.ReadLine(), out int end);
            //if (!flag2)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}

            //Console.WriteLine($"The prime numbers between {start} and {end} are :");

            //for (int i = start; i <= end; i++)
            //{
            //    if (i <= 1)
            //        continue; 

            //    bool isPrime = true;

            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false; 
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //        Console.Write(i + " ");
            //}

            // 16
            //Console.WriteLine("Enter a number to convert :");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}

            //// Convert the number to binary
            //string binary = Convert.ToString(number, 2);
            //Console.WriteLine($"The Binary of {number} is => {binary}");

            // 17
            //Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int x1);
            //bool flag2 = int.TryParse(Console.ReadLine(), out int y1);

            //if (!flag1 || !flag2)
            //{
            //    Console.WriteLine("Please enter valid numbers.");
            //    return;
            //}

            //Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            //bool flag3 = int.TryParse(Console.ReadLine(), out int x2);
            //bool flag4 = int.TryParse(Console.ReadLine(), out int y2);

            //if (!flag3 || !flag4)
            //{
            //    Console.WriteLine("Please enter valid numbers.");
            //    return;
            //}

            //Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            //bool flag5 = int.TryParse(Console.ReadLine(), out int x3);
            //bool flag6 = int.TryParse(Console.ReadLine(), out int y3);

            //if (!flag5 || !flag6)
            //{
            //    Console.WriteLine("Please enter valid numbers.");
            //    return;
            //}

            //// Check if the points are collinear
            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}

            // 18
            //Console.WriteLine("Please Enter The (Time in hours) the job completed in :");
            //bool flag = float.TryParse(Console.ReadLine(), out float timeTaken);
            //if (!flag || timeTaken <= 0)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}

            //if (timeTaken >= 2 && timeTaken <= 3)
            //    Console.WriteLine("The worker is highly efficient.");
            //else if (timeTaken > 3 && timeTaken <= 4)
            //    Console.WriteLine("The worker is instructed to increase their speed.");
            //else if (timeTaken > 4 && timeTaken <= 5)
            //    Console.WriteLine("The worker is provided with training to enhance their speed.");
            //else if (timeTaken > 5)
            //    Console.WriteLine("The worker is required to leave the company.");

            // 19
            //Console.WriteLine("Please Enter the size of the identity matrix :");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag || number <= 0)
            //{
            //    Console.WriteLine("Please Enter a valid number");
            //    return;
            //}

            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j < number; j++)
            //    {
            //         Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            // 20
            //int[] numbers = new int[5] { 10,10,10,10,10 };
            //Console.WriteLine(numbers.Sum());

            // 21

        }
    }
}
