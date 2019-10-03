using System;
using System.Collections.Generic;

namespace QuizTime
{
    public class Quiz
    {
        private int score = 0;

        public List<MultipleChoice> MCQ { get; set; }
        public List<TrueFalse> TFQ { get; set; }
        public List<CheckBox> CBQ { get; set; }
        public int TotalQuestions { get; set; }

        public Quiz()
        {
            MCQ = new List<MultipleChoice>();
            TFQ = new List<TrueFalse>();
            CBQ = new List<CheckBox>();
            TotalQuestions = 0;
        }

        public void AddMCQ(MultipleChoice mcq)
        {
            MCQ.Add(mcq);
            TotalQuestions++;
        }

        public void AddTFQ(TrueFalse tfq)
        {
            TFQ.Add(tfq);
            TotalQuestions++;
        }

        public void AddCBQ(CheckBox cbq)
        {
            CBQ.Add(cbq);
            TotalQuestions++;
        }

        private void AskQuestion(Question q)
        {
            Console.WriteLine("\n" + q.GetQuizId().ToString() +
                        ". " + q.GetQuestion() + "\n");
            Console.WriteLine(q.GetOptions());
            Console.WriteLine("Your Response: ");
        }

        public void StartQuiz()
        {
            if (MCQ.Count != 0)
            {
                Console.WriteLine("\n*****************************\n");
                Console.WriteLine(MCQ[0].GetQType());
                foreach (MultipleChoice q in MCQ)
                {
                    AskQuestion(q);

                    string response = Console.ReadLine();
                    if (response == q.GetAnswer())
                        score++;
                }
            }

            if (TFQ.Count != 0)
            {
                Console.WriteLine("\n*****************************\n");
                Console.WriteLine(TFQ[0].GetQType());
                foreach (TrueFalse q in TFQ)
                {
                    AskQuestion(q);

                    string response = Console.ReadLine();
                    if (response == q.GetAnswer())
                        score++;
                }
            }

            if (CBQ.Count != 0)
            {
                Console.WriteLine("\n*****************************\n");
                Console.WriteLine(CBQ[0].GetQType());
                foreach (CheckBox q in CBQ)
                {
                    int check = 0;
                    AskQuestion(q);

                    List<string> responses = new List<string>();
                    string response = "";
                    do
                    {
                        response = Console.ReadLine();
                        if (q.GetAnswers().Contains(response) && !responses.Contains(response))
                        {
                            check++;
                            responses.Add(response);
                        }
                    } while (response != "");
                    if (check == q.GetAnswers().Count)
                        score++;
                }
            }
            Console.WriteLine(GradeQuiz());
            
        }

        public string GradeQuiz()
        {
            return "Your total score is: " + score.ToString() + "/" +
                TotalQuestions.ToString();
        }
        
    }
}
