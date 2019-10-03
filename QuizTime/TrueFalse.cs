using System;
namespace QuizTime
{
    public class TrueFalse : Question
    {
        public string Answer { get; set; }
        public string Option1 { get; set; } = "true";
        public string Option2 { get; set; } = "false";

        public TrueFalse(string ques, string answer, string type = "True or False?")
            : base(ques, type)
        {
            Answer = answer;
        }

        public string GetOptions()
        {
            return "\n" + Option1 + "\n" + Option2 + "\n";
        }

        public string GetAnswer()
        {
            return Answer;
        }
    }
}
