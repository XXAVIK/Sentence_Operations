namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string phraseInput = Console.ReadLine();

            string reversedPhrase = ReversWords(phraseInput);

            Console.WriteLine("Инвертированное предложение:");
            Console.WriteLine(reversedPhrase);
        }
        static string[] SplitWords(string phrase)
        {
            string[] words = phrase.Split(' ');
            return words;
        }

        static string ReversWords(string inputPhrase)
        {
            string[] words = SplitWords(inputPhrase);
            Array.Reverse(words);
            string reversedPhrase = string.Join(" ", words);

            return reversedPhrase;
        }
    }
}