using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_C_.Answers;

namespace Assignment1_C_.Questions
{
    public class MCQ_Questions : Question
    {
        public MCQ_Questions(string body, double mark, List<Answer> answers, Answer correctAnswer)
            : base("MCQ Question", body, mark, answers, correctAnswer)
        {
        }

        public override string ToString()
        {
            return $"MCQ Question: {Body}                    Mark: {Mark}";
        }
    }
}
