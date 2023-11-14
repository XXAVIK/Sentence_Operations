namespace Sentence_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentenceInput = Console.ReadLine();

            string[] words = SplitSentence(sentenceInput);

            PrintWords(words);
        }
        static string[] SplitSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            return words;
        }

        static void PrintWords(string[] words)
        {
            Console.WriteLine("Слова в предложении:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

    }
}