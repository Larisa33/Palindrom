namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu cuvantul: ");
            string word = Console.ReadLine();

            Console.WriteLine(IsPalindrom(word));

        }

        static string IsPalindrom(string word)
        {

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return "Cuvantul introdus NU este un palindrom";
                }
            }

            return "Cuvantul introdus este un palindrom";
        
        }
    }
}