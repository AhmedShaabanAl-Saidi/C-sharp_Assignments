using System.Diagnostics;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            subject.CreateExam();

            Console.Clear();

            bool validInput = false;

            do
            {
                Console.Write("Do You Want To Start An Exam (Y || N)? ");
                string? input = Console.ReadLine()?.ToLower();

                if (input == "y" || input == "n")
                {
                    if (input == "y")
                    {
                        StartExam(subject);
                    }
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input Please Enter 'Y' or 'N'");
                }

            } while (!validInput);
        }

        private static void StartExam(Subject subject)
        {
            Stopwatch examTimer = new Stopwatch();

            examTimer.Start();

            subject.ExamOfSubject.ShowExam();

            examTimer.Stop();

            Console.WriteLine($"Time taken: {examTimer.Elapsed}");
        }
    }
}
