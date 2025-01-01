namespace Assignment1_C_
{
    internal class Program
    {
        public static double TryToParse(string point)
        {
            double result;
            bool isParsed;
            do
            {
                isParsed = double.TryParse(Console.ReadLine(), out result);
                if (!isParsed)
                {
                    Console.WriteLine("Invalid input, please enter a number");
                    Console.Write(point);
                }
            }
            while (!isParsed);

            return result;
        }

        static void Main(string[] args)
        {
            // 1 - struct "Person" 
            //Person[] Persons = new Person[3];

            //Persons[0] = new Person("Ahmed",25);
            //Persons[1] = new Person("Mohmed",30);
            //Persons[2] = new Person("Ali", 35);

            //Console.WriteLine("Persons:");
            //foreach(Person p in Persons)
            //{
            //    Console.WriteLine($"Name: {p.Name} >>> Age: {p.Age}");
            //}

            // 2 - Point
            //Console.WriteLine("Enter the coordinates of the first point (X1, Y1):");
            //Console.Write("X1: ");
            //double x1 = TryToParse("X1: ");
            //Console.Write("Y1: ");
            //double y1 = TryToParse("Y1: ");

            //Console.WriteLine("Enter the coordinates of the second point (X2, Y2):");
            //Console.Write("X2: ");
            //double x2 = TryToParse("X2: ");
            //Console.Write("Y2: ");
            //double y2 = TryToParse("Y2: ");

            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);

            //Console.WriteLine($"Distance between p1 and p2: {p1.Distance(p2)}");

            // 3 - 
        }
    }
}
