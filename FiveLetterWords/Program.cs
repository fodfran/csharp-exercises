using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveLetterWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string newWord;

            Console.WriteLine("Enter a word (or ENTER to finish):");
            do
            {
                newWord = Console.ReadLine();
                if (newWord != "")
                {
                    words.Add(newWord);
                }
            }
            while (newWord != "");
            Words.getFiveLetterWords(words);
            Console.ReadLine();
        }
    }
}
