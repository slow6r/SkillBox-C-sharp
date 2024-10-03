class Program
{
    static void Main()
    {
        List<int> numbers = GenerateRandomNumbers(100, 0, 100);
        Console.WriteLine("Original List:");
        PrintList(numbers);

        numbers = RemoveNumbersInRange(numbers, 25, 50);
        Console.WriteLine("Modified List:");
        PrintList(numbers);
    }

    static List<int> GenerateRandomNumbers(int count, int min, int max)
    {
        Random rand = new Random();
        List<int> list = new List<int>();
        for (int i = 0; i < count; i++)
        {
            list.Add(rand.Next(min, max));
        }
        return list;
    }

    static List<int> RemoveNumbersInRange(List<int> list, int min, int max)
    {
        list.RemoveAll(num => num > min && num < max);
        return list;
    }

    static void PrintList(List<int> list)
    {
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
