using System;
using System.Collections.Generic;

namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleChoice MCQ1 = new MultipleChoice("What is SHINee's color?",
                "pearl aqua", new List<string>() { "red", "blue", "pearl aqua" });
            MultipleChoice MCQ2 = new MultipleChoice("What is SHINee debut date?",
                "May 25", new List<string>() { "July 18", "May 25", "September 23", "December 14" });

            TrueFalse TFQ1 = new TrueFalse("Onew is the leader of SHINee.", "true");

            CheckBox CB1 = new CheckBox("Which of the following are SHINee members?",
                new List<string>() { "Taemin", "Onew" }, new List<string>() { "Kai",
                "Onew", "Leeteuk", "Taemin", "Taeyong"});

            Quiz SHINee = new Quiz();
            SHINee.AddMCQ(MCQ1);
            SHINee.AddMCQ(MCQ2);
            SHINee.AddTFQ(TFQ1);
            SHINee.AddCBQ(CB1);

            SHINee.StartQuiz();


        }
    }
}
