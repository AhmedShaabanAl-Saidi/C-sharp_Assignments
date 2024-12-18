namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - 1
            //Console.WriteLine("Please Enter Your Number :");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number);

            // - 2
            //Console.WriteLine("Please Enter Your String To Convert It to Number :");
            //string str = Console.ReadLine();

            //bool flag = int.TryParse(str, out int number);

            //if (flag) 
            //    Console.WriteLine("Parsing Succeeded => " + number);
            //else
            //    Console.WriteLine("Parsing Failed => " + number);
            /*
             * What will happen when the user input non-numeric characters
             * The Program will Fire "Parsing Failed => 0"
            */

            // - 3
            //float number1 = 25.5f;
            //float number2 = 12.5f;

            //Console.WriteLine($"Add = {number1} + {number2} = {number1 + number2}");
            //Console.WriteLine($"Subtraction = {number1} - {number2} = {number1 - number2}");
            //Console.WriteLine($"Multiplication = {number1} * {number2} = {number1 * number2}");
            //Console.WriteLine($"Division = {number1} / {number2} = {number1 / number2}");

            // - 4
            //Console.WriteLine("Please Enter Your String To Extract a substring from It :");
            //string str = Console.ReadLine();

            //Console.WriteLine("Please Enter the length of the substring You Want :");
            //int substringLenght = Convert.ToInt32(Console.ReadLine());

            //if (substringLenght <= 0 || substringLenght > str.Length)
            //    Console.WriteLine("Please Enter a Valid substring Number.");
            //else
            //    Console.WriteLine(str.Substring(0,substringLenght));

            // - 5
            //int number1 = 5;
            //int number2 = 10;

            //number2 = number1; // Will happen copy by value
            //Console.WriteLine(number2);

            //number1 = 20;
            //Console.WriteLine(number2);

            // - 6
            //int[] arr1 = {10,20,30};
            //int[] arr2 = arr1; // Will happen copy by reference

            //Console.WriteLine(arr2[0]);
            //arr1[0] = 50;
            //Console.WriteLine(arr2[0]);

            // - 7
            //Console.WriteLine("Please Enter Your First String :");
            //string str1 = Console.ReadLine();

            //Console.WriteLine("Please Enter Your Second String :");
            //string str2 = Console.ReadLine();

            //Console.WriteLine($"Your Full String is => {str1} {str2}");

            // - 8
            //Console.WriteLine("Enter the Principal Amount:");
            //double principal = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the Rate of interest (in %) :");
            //double rate = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the Time (in years) :");
            //double time = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Interest = " + (principal * rate * time) / 100);

            // - 9
            //Console.WriteLine("Enter Your Weight in kilograms :");
            //float weight = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Your Height in meters :");
            //float height = float.Parse(Console.ReadLine());

            //float bmi = weight / (height * height);

            //Console.WriteLine("Your Body Mass Index (BMI) is: {0:F2}", bmi);

            // - 10
            //Console.WriteLine("Enter The Temperature degrees :");
            //int temperature = int.Parse(Console.ReadLine());

            //string result = (temperature < 10) ? "Cold" : (temperature > 30) ? "Hot" : "Good";

            //Console.WriteLine("The temperature is: " + result);

            // - 11
            //Console.WriteLine("Enter the day (e.g., 20): ");
            //int day = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the month (e.g., 12): ");
            //int month = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the year (e.g., 1999): ");
            //int year = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Date: {day},{month},{year}");
            //Console.WriteLine($"Date: {day}/{month}/{year}");
            //Console.WriteLine($"Date: {day}–{month}–{year}");

            // - 12
            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}"); // The event is on 06/14/2024

            // - 13
            //int d;
            //d = Convert.ToInt32(!(30 < 20)); // A value 1 will be assigned to d.
            //Console.WriteLine(d);

            // - 14
            //Console.WriteLine(13 / 2 + " " + 13 % 2); // 6 1

            // - 15
            int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z); // 7 7
            else
                Console.WriteLine(--num + z-- + " " + --z);
        }
    }
}
