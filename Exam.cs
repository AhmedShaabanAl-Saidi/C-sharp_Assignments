using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
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
