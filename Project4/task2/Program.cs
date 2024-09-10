using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine() ?? string.Empty; 

        string reversedPhrase = ReverseWords(input);
        Console.WriteLine("Предложение с перевёрнутыми словами:");
        Console.WriteLine(reversedPhrase);
    }

    static string[] SplitText(string text)
    {
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries); 
    }

    static string ReverseWords(string inputPhrase)
    {
        string[] words = SplitText(inputPhrase);
        Array.Reverse(words); 

        return string.Join(' ', words); 
    }
}
