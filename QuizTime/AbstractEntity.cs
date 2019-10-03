using System;
namespace QuizTime
{
    public class AbstractEntity
    {
        private static int nextQuizId = 1;
        public int QuizId { get; set; }

        public AbstractEntity()
        {
            QuizId = nextQuizId++;
        }

        public int GetQuizId()
        {
            return QuizId;
        }
    }
}
