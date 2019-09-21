using System;

namespace AliceInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of " +
                "sitting by her sister on the bank, and of having nothing " +
                "to do: once or twice she had peeped into the book her " +
                "sister was reading, but it had no pictures or conversations " +
                "in it, 'and what is the use of a book,' thought Alice " +
                "'without pictures or conversation?'";
            Console.WriteLine("Search for: ");
            string word = Console.ReadLine();
            int wordLength = word.Length;
            string uppercaseWord;
            string lowercaseWord;
            if (wordLength > 1)
            {
                uppercaseWord = char.ToUpper(word[0]) + word.Substring(1);
                lowercaseWord = char.ToLower(word[0]) + word.Substring(1);
            }
            else
            {
                uppercaseWord = word.ToUpper();
                lowercaseWord = word.ToLower();
            }
            bool containsWord = sentence.Contains(word);
            bool containsUpperWord = sentence.Contains(uppercaseWord);
            bool containsLowerWord = sentence.Contains(lowercaseWord);
            
            Console.WriteLine(containsWord || containsUpperWord || containsLowerWord);
            Console.ReadLine();


        }
    }
}
