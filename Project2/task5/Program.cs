using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите максимальное целое число диапазона:");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int maxRange) && maxRange > 0)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, maxRange + 1);

            Console.WriteLine($"Я загадал число от 0 до {maxRange}. Попробуйте угадать!");

            while (true)
            {
                Console.WriteLine("Введите ваше предположение или оставьте строку пустой для выхода:");
                string? guess = Console.ReadLine();

                if (string.IsNullOrEmpty(guess))
                {
                    Console.WriteLine($"Вы вышли из игры. Загаданное число было: {randomNumber}");
                    break;
                }

                if (int.TryParse(guess, out int guessedNumber))
                {
                    if (guessedNumber < randomNumber)
                    {
                        Console.WriteLine("Загаданное число больше.");
                    }
                    else if (guessedNumber > randomNumber)
                    {
                        Console.WriteLine("Загаданное число меньше.");
                    }
                    else
                    {
                        Console.WriteLine("Поздравляем! Вы угадали число.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное целое число.");
                }
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное положительное число для диапазона.");
        }
    }
}
