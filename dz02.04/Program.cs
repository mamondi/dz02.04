using System;

namespace dz02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Це текст для перевірки, чи містить він задане слово.";
            string wordToCheck = "задане";

            Func<string, string, bool> containsWord = (inputText, word) =>
                inputText.ToLower().Contains(word.ToLower());

            Console.WriteLine($"Текст містить слово '{wordToCheck}': {containsWord(text, wordToCheck)}");
        }
    }
}
