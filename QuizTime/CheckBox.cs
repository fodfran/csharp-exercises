using System;
using System.Collections.Generic;

namespace QuizTime
{
    public class CheckBox : Question
    {
        private static string type = "Check Box (Choose 1 or more)";

        public List<string> Answers { get; set; }

        public CheckBox(string ques, List<string> answers, List<string> options)
            : base(ques, options, type)

        {
            Answers = answers;
        }

        public List<string> GetAnswers()
        {          
            return Answers;
        }
    }
}
