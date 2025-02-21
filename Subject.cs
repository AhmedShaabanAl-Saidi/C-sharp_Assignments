using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam? ExamOfSubject { get; set; }

        public void CreateExam()
        {
            int examType = GetValidInput("Enter Exam Type (1 for Final, 2 for Practical): ", 1, 2);
            int numQuestions = GetValidInput("Enter Number Of Questions: ", 1, int.MaxValue);
            int duration = GetValidInput("Enter Exam Duration (Minutes): ", 1, int.MaxValue);

            TimeSpan timeSpan = TimeSpan.FromMinutes(duration);
            List<Question> questions = new List<Question>();

            if (examType == 1)
            {
                CreateFinalExam(numQuestions, questions);
                ExamOfSubject = new Final_Exam(timeSpan, numQuestions, questions);
            }
            else
            {
                CreatePracticalExam(numQuestions, questions);
                ExamOfSubject = new Prectical_Exam(timeSpan, numQuestions, questions);
            }
        }

        private void CreateFinalExam(int numQuestions, List<Question> questions)
        {
            for (int i = 0; i < numQuestions; i++)
            {
                Console.Clear();
                int questionType = GetValidInput("Choose Type (1 for True/False, 2 for MCQ): ", 1, 2);
                string body = GetNonEmptyString("Enter Question Body: ");
                double mark = GetValidDouble("Enter Question Mark: ", 0.1);

                if (questionType == 1)
                {
                    questions.Add(CreateTrueFalseQuestion(body, mark));
                }
                else
                {
                    questions.Add(CreateMCQQuestion(body, mark));
                }
            }
        }

        private void CreatePracticalExam(int numQuestions, List<Question> questions)
        {
            for (int i = 0; i < numQuestions; i++)
            {
                Console.Clear();
                string body = GetNonEmptyString($"Enter question {i + 1} body: ");
                double mark = GetValidDouble("Enter question mark: ", 0.1);
                questions.Add(CreateMCQQuestion(body, mark));
            }
        }

        private TrueOrFalse_Questions CreateTrueFalseQuestion(string body, double mark)
        {
            int correctAnswer = GetValidInput("Enter Correct Answer (1 for True, 2 for False): ", 1, 2);
            string correctAnswerTxt = correctAnswer == 1 ? "True" : "False";
            Answer rightAnswer = new Answer(correctAnswer, correctAnswerTxt);
            return new TrueOrFalse_Questions(body, mark, rightAnswer);
        }

        private MCQ_Questions CreateMCQQuestion(string body, double mark)
        {
            List<Answer> answerList = new List<Answer>();

            for (int i = 0; i < 3; i++)
            {
                string answerText = GetNonEmptyString($"Enter choices {i + 1}: ");
                Answer choicesID = new Answer(i + 1, answerText);
                answerList.Add(choicesID);
            }

            int correctAnswer = GetValidInput("Enter correct answer number (1, 2, or 3): ", 1, 3);
            string rightAnswerTxt = answerList[correctAnswer - 1].AnswerText;
            Answer answer = new Answer(correctAnswer, rightAnswerTxt);
            return new MCQ_Questions(body, mark, answerList, answer);
        }

        private int GetValidInput(string prompt, int minValue, int maxValue)
        {
            int value;
            do
            {
                Console.Write(prompt);
            } while (!int.TryParse(Console.ReadLine(), out value) || value < minValue || value > maxValue);
            return value;
        }

        private double GetValidDouble(string prompt, double minValue)
        {
            double value;
            do
            {
                Console.Write(prompt);
            } while (!double.TryParse(Console.ReadLine(), out value) || value < minValue);
            return value;
        }

        private string GetNonEmptyString(string prompt)
        {
            string? input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }
    }
}
