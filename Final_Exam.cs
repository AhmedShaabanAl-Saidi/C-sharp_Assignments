using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class Final_Exam : Exam
    {
        public Final_Exam(TimeSpan examTime, int numberOfQuestions, List<Question> questions) : base(examTime, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            int userAnswer;
            double totalMark = 0;

            foreach (var question in Questions)
            {
                Console.WriteLine(question);

                foreach (var answer in question.Answers)
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                

                do
                {
                    Console.WriteLine("Your Answer: ");
                }
                while (!int.TryParse(Console.ReadLine(), out userAnswer) || userAnswer < 1 || userAnswer > 3);

                if (userAnswer == question.CorrectAnswer.AnswerId)
                    totalMark += question.Mark;
            }

            Console.WriteLine($"\nYour Grade Is: {totalMark}");
        }
    }
}
