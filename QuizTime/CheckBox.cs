using System;
using System.Collections.Generic;

namespace QuizTime
{
    public class CheckBox : Question
    {
        public List<string> Answers { get; set; }
        public List<string> Options { get; set; }

        public CheckBox(string ques, List<string> answers, List<string> options,
            string type = "Check Box (Choose 1 or more)") : base(ques, type)
        {
            Answers = answers;
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

        public List<string> GetAnswers()
        {          
            return Answers;
        }
    }
}
