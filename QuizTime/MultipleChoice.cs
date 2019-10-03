using System;
using System.Collections.Generic;

namespace QuizTime
{
    public class MultipleChoice : Question
    {
        private static string type = "Multiple Choice (Choose 1):";

        public string Answer { get; set; }
        

        public MultipleChoice(string ques, string answer, List<string> options)
            : base(ques, options, type)
        {
            Answer = answer;
        }


        public string GetAnswer()
        {
            return Answer;
        }
    }
}
