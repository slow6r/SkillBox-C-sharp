using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine() ?? string.Empty; 
        string[] words = SplitText(input);
        PrintWords(words);
    }

    static string[] SplitText(string text)
    {
        return text.Split(' ');
    }

    static void PrintWords(string[] words)
    {
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
