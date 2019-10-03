using System;
using System.Collections.Generic;

namespace QuizTime
{
    public class MultipleChoice : Question
    {
        public string Answer { get; set; }
        public List<string> Options { get; set; }
        

        public MultipleChoice(string ques, string answer, List<string> options,
            string type = "Multiple Choice (Choose 1):") : base(ques, type)
        {
            Answer = answer;
            Options = options;
        }

        public string GetOptions()
        {
            string allOptions = "";
            foreach (string opt in Options)
            {
                allOptions += opt + "\n";
            }
            return allOptions;
        }

        public string GetAnswer()
        {
            return Answer;
        }
    }
}
