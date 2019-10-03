using System;
using System.Collections.Generic;

namespace QuizTime
{
    public class Question : AbstractEntity
    {
        public string Ques { get; set; }
        public List<string> Options { get; set; }
        public string Type { get; set; }

        public Question(string ques, List<string> options, string type)
        {
            Ques = ques;
            Options = options;
            Type = type;
        }

        public string GetQuestion()
        {
            return Ques;
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

        public string GetQType()
        {
            return Type;
        }

        
    }
}
