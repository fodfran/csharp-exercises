using System;
namespace QuizTime
{
    public class Question : AbstractEntity
    {
        public string Ques { get; set; }
        //public string Answer { get; set; }
        public string Type { get; set; }

        public Question(string ques, string type)
        {
            Ques = ques;
            //Answer = answer;
            Type = type;
        }

        public string GetQuestion()
        {
            return "\n" + Ques;
        }

        public string GetQType()
        {
            return Type;
        }

        
    }
}
