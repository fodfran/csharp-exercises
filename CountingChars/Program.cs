using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountingChars
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string text = "Lorem ipsum dolor sit amet, consectetur adipiscing " +
                "elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. " +
                "Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam " +
                "erat volutpat. Donec sit amet suscipit metus, non lobortis " +
                "massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat " +
                "eget massa. Donec nec velit non ligula efficitur luctus.";
            */

            //Console.WriteLine("Enter some text: ");
            //string text = Console.ReadLine();

            string text = System.IO.File.ReadAllText(@"/Users/Francesca/lc101/csharp-exercises/CountingChars/Text.txt");

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            text = text.ToLower();

            Dictionary<string, int> letterDict = new Dictionary<string, int>();
            StringBuilder letterDictOut = new StringBuilder("", 100);

            foreach (char letter in text)
            {
                if (alphabet.Contains(letter.ToString()))
                {
                    if (letterDict.ContainsKey(letter.ToString()))
                    {
                        letterDict[letter.ToString()] += 1;
                    }
                    else
                    {
                        letterDict[letter.ToString()] = 1;
                    }
                }
               
            }

            foreach (KeyValuePair<string, int> letter in letterDict)
            {
                letterDictOut.Append(letter.Key + ": " + letter.Value + "\n");
            }

            Console.WriteLine(letterDictOut);
            Console.ReadLine();

        }
    }
}
