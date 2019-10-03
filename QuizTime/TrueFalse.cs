using System;
using System.Collections.Generic;

namespace QuizTime
{
    public class TrueFalse : Question
    {
        private static List<string> option = new List<string>() { "true", "false" };
        private static string type = "True or False?";

        public string Answer { get; set; }

        public TrueFalse(string ques, string answer) : base(ques, option, type)
        {
            Answer = answer;
        }

        public string GetAnswer()
        {
            return Answer;
        }
    }
}
