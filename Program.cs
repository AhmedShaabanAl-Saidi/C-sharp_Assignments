using System.Buffers.Text;

namespace Assignment1_C_
{
    internal class Program
    {
        // 1
        // Value Types - Passing by Value
        //public static void printNumber(int x)
        //{
        //    x = 20;
        //    Console.WriteLine("Inside the method: " + x);
        //}

        // Value Types - Passing by reference
        //public static void printNumber(ref int x)
        //{
        //    x = 20;
        //    Console.WriteLine("Inside the method: " + x);
        //}

        ///////////////////////////////////////////////////////////
        // 2
        // Reference Types - Passing by Value
        //public static void printArray(int[] arr)
        //{
        //    arr[0] = 10;
        //    Console.WriteLine("Inside the method: " + arr[0]);
        //}

        // Reference Types - Passing by reference
        //public static void printArray(ref int[] arr)
        //{

        //    arr = new int[] { 10, 20, 30, 40, 50 };
        //    arr[0] = 10;
        //    Console.WriteLine("Inside the method: " + arr[0]);
        //    Console.WriteLine(arr.GetHashCode());
        //}

        ///////////////////////////////////////////////////////
        // 3
        //public static void SumAndSub(int x, int y, out int sum, out int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //}

        ///////////////////////////////////////////////////////
        // 4
        //public static int Sum(int num)
        //{
        //    string numToString = num.ToString();
        //    int sum = int.Parse(numToString[0].ToString()) + int.Parse(numToString[1].ToString());
        //    return sum;
        //}
        ///////////////////////////////////////////////////////
        // 5
        //public static bool isPrime(int num)
        //{
        //    if (num == 1 || num == 0)
        //    {
        //        return false;
        //    }
        //    for (int i = 2; i <= num / 2; i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        ///////////////////////////////////////////////////////
        // 6
        //public static void MinMaxArray(int[] NumberArr , out int min , out int max)
        //{
        //    min = NumberArr.Min();
        //    max = NumberArr.Max();
        //}

        ///////////////////////////////////////////////////////
        // 7
        //public static long Factorial(int num)
        //{
        //    long factorial = 1;

        //    for (int i = 1; i <= num; i++)
        //    {
        //        factorial *= i;
        //    }

        //    return factorial;
        //}

        ///////////////////////////////////////////////////////
        // 8
        //public static void ChangeChar(ref string str, int index, char newChar)
        //{
        //    char[] arr = str.ToCharArray();
        //    arr[index] = newChar;
        //    str = new string(arr);
        //}


        static void Main(string[] args)
        {
            // 1
            // Value Types - Passing by Value
            // Value types are stored in the stack.
            // Any changes made to the parameter within the method do not affect the original variable outside the method.
            // Value types are int, float, double, decimal, char, bool, byte, and struct.

            // Example
            //int x = 10;
            //Console.WriteLine("Before calling the method: " + x);
            //printNumber(x);
            //Console.WriteLine("After calling the method: " + x);

            // Value Types - Passing by reference
            // Value types can be passed by reference using the ref keyword.
            // Any changes made to the parameter within the method affect the original variable outside the method.

            // Example
            //int y = 10;
            //Console.WriteLine("Before calling the method: " + y);
            //printNumber(ref y);
            //Console.WriteLine("After calling the method: " + y);

            //////////////////////////////////////////////////////////////

            // 2
            // Reference Types - Passing by Value
            // Reference types are stored in the heap.
            // Any changes made to the parameter within the method affect the original variable outside the method.
            // Reference types are string, array, class, and interface.

            // Example
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Before calling the method: " + arr[0]);
            //printArray(arr);
            //Console.WriteLine("After calling the method: " + arr[0]);


            // Reference Types - Passing by reference
            // Reference types can be passed by reference using the ref keyword.
            // Any changes made to the parameter within the method affect the original variable outside the method.

            // Example
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Before calling the method: " + arr[0]);
            //Console.WriteLine(arr.GetHashCode());
            //printArray(ref arr);
            //Console.WriteLine("After calling the method: " + arr[0]);
            //Console.WriteLine(arr.GetHashCode());

            ////////////////////////////////////////////////////////////////////
            // 3
            //Console.WriteLine("Please Enter Number 1: ");
            //bool Flag = int.TryParse(Console.ReadLine() , out int num1);
            //if (!Flag)
            //{
            //    Console.WriteLine("Invalid Number");
            //    return;
            //}
            //Console.WriteLine("Please Enter Number 2: ");
            //bool Flag2 = int.TryParse(Console.ReadLine(), out int num2);
            //if (!Flag2)
            //{
            //    Console.WriteLine("Invalid Number");
            //    return;
            //}


            //int sum, sub;
            //SumAndSub(num1, num2, out sum, out sub);
            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Sub: " + sub);

            ////////////////////////////////////////////////////////////////////
            // 4
            //Console.WriteLine("Please Enter Just Two digits To Sum them :");
            //bool Flag = int.TryParse(Console.ReadLine(), out int num);
            //if (!Flag || num.ToString().Length > 2 )
            //{
            //    Console.WriteLine("Invalid Number or Number is More than Two digits");
            //    return;
            //}

            //Console.WriteLine(Sum(num));

            ////////////////////////////////////////////////////////////////////
            // 5
            //Console.WriteLine("Please Enter Number To Check it is Prime or Not :");
            //bool Flag = int.TryParse(Console.ReadLine(), out int num);
            //if (!Flag || num.ToString().Length > 2)
            //{
            //    Console.WriteLine("Invalid Number or Number is More than Two digits");
            //    return;
            //}

            //Console.WriteLine(isPrime(num) ? "Prime" : "Not Prime");

            ////////////////////////////////////////////////////////////////////
            // 6
            //int[] arr = { 1, 2, 3, 4, 5 };

            //int min, max;

            //MinMaxArray(arr, out min, out max);
            //Console.WriteLine("Min: " + min);
            //Console.WriteLine("Max: " + max);

            ////////////////////////////////////////////////////////////////////
            // 7
            //Console.WriteLine("Please Enter Number To Get Factorial :");
            //bool Flag = int.TryParse(Console.ReadLine(), out int num);
            //if (!Flag)
            //{
            //    Console.WriteLine("Invalid Number");
            //    return;
            //}

            //Console.WriteLine(Factorial(num));

            ////////////////////////////////////////////////////////////////////
            // 8
            //Console.WriteLine("Please Enter String :");
            //string str = Console.ReadLine();

            //Console.WriteLine("Please Enter Index :");
            //bool Flag = int.TryParse(Console.ReadLine(), out int index);
            //if (!Flag || index < 0 || index >= str.Length)
            //{
            //    Console.WriteLine("Invalid Index");
            //    return;
            //}

            //Console.WriteLine("Please Enter New Char :");
            //char newChar = Console.ReadLine()[0];

            //ChangeChar(ref str, index, newChar);

            //Console.WriteLine(str);

        }
    }
}
