using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_C_.Questions;

namespace Assignment1_C_.Exams
{
    public class Prectical_Exam : Exam
    {
        public Prectical_Exam(TimeSpan examTime, int numberOfQuestions, List<Question> questions) 
            : base(examTime, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            int userAnswer;

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

                Console.WriteLine($"Correct Answer Was: {question.CorrectAnswer.AnswerText}\n");
            }
        }
    }
}
