namespace Assignment1_C_.Point3D
{
    internal class Program
    {
        #region TryToParse
        public static int TryToParse(string point)
        {
            Console.Write(point);

            int result;
            bool isParsed;
            do
            {
                isParsed = int.TryParse(Console.ReadLine(), out result);
                if (!isParsed)
                {
                    Console.WriteLine("Invalid input, please enter a number");
                    Console.Write(point);
                }
            }
            while (!isParsed);

            return result;
        } 
        #endregion

        static void Main(string[] args)
        {
            #region First Project
            // 1,2
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());

            // 3
            //Console.WriteLine("Please Enter Coordinates for 2 points P1, P2 :");
            //int p1 = TryToParse("P1: ");
            //int p2 = TryToParse("P2: ");

            //Point3D P = new Point3D(p1, p2);

            // 4
            //if (p1 == p2)
            //    Console.WriteLine("P1 and P2 are the same point");
            //else
            //{
            //    Console.WriteLine("P1 and P2 are different points");
            //}

            // 5
            //Point3D[] points =
            //{
            //new Point3D(5, 2),
            //new Point3D(3, 3),
            //new Point3D(1, 4),
            //new Point3D(5, 1),
            //new Point3D(2, 2)
            //};

            //Console.WriteLine("Before Sorting");
            //foreach (Point3D point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //Console.WriteLine("=================================");

            //Array.Sort(points);

            //Console.WriteLine("After Sorting");
            //foreach (Point3D point in points)
            //{
            //    Console.WriteLine(point);
            //}

            // 6
            //Point3D p1 = new Point3D(1, 2);
            //Point3D p2 = new Point3D(10, 20);

            //Console.WriteLine("Before Copy");
            //Console.WriteLine(p2.GetHashCode());
            //Console.WriteLine(p2.X);

            //p2 = (Point3D)p1.Clone();

            //Console.WriteLine("=================================");
            //Console.WriteLine("After Copy");
            //Console.WriteLine(p2.GetHashCode());
            //Console.WriteLine(p2.X);
            #endregion

            #region Second Project
            //Console.WriteLine($"10+5 = {Maths.Add(10,5)}");
            //Console.WriteLine($"10-5 = {Maths.Subtract(10, 5)}");
            //Console.WriteLine($"10*5 = {Maths.Multiply(10, 5)}");
            //Console.WriteLine($"10/5 = {Maths.Divide(10, 5)}");
            #endregion

            #region Third Project
            //Duration d1 = new Duration(1, 10, 15);
            //Console.WriteLine(d1);

            //Duration d2 = new Duration(3600);
            //Console.WriteLine(d2);

            //Duration d3 = new Duration(7800);
            //Console.WriteLine(d3);

            //Duration d4 = new Duration(666);
            //Console.WriteLine(d4);
            #endregion
        }
    }
}
