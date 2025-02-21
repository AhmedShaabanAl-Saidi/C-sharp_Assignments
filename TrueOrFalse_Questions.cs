using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class TrueOrFalse_Questions : Question
    {
        public TrueOrFalse_Questions(string body, double mark, Answer correctAnswer)
            : base("True or False Question", body, mark, new List<Answer> { new Answer(1, "True"), new Answer(2, "False") }, correctAnswer)
        {
        }

        public override string ToString()
        {
            return $"True or False Question: {Body}                    Mark: {Mark}";
        }
    }
}
