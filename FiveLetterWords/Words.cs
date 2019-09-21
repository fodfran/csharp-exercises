using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveLetterWords
{
    public class Words
    {
        public static void getFiveLetterWords(List<string> words)
        {
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
