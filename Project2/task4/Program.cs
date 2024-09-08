class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длину последовательности:");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int sequenceLength) && sequenceLength > 0)
        {
            int minElement = int.MaxValue;

            for (int i = 1; i <= sequenceLength; i++)
            {
                Console.WriteLine($"Введите {i}-е число:");
                string? numberInput = Console.ReadLine();

                if (int.TryParse(numberInput, out int currentNumber))
                {
                    if (currentNumber < minElement)
                    {
                        minElement = currentNumber;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное целое число.");
                    i--;
                }
            }

            Console.WriteLine($"Наименьшее число в последовательности: {minElement}");
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное положительное число для длины последовательности.");
        }
    }
}
