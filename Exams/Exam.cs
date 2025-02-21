using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Assignment1_C_.Questions;

namespace Assignment1_C_.Exams
{
    public abstract class Exam
    {
        public TimeSpan ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(TimeSpan examTime, int numberOfQuestions, List<Question> questions)
        {
            ExamTime = examTime;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }

        public abstract void ShowExam();
    }
}
