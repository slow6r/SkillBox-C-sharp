
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число для проверки на простоту:");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number > 1)
        {
            bool isNotPrime = false;
            int divisor = 2;

            while (divisor <= Math.Sqrt(number)) 
            {
                if (number % divisor == 0)
                {
                    isNotPrime = true;
                    break;
                }
                divisor++;
            }

            if (isNotPrime)
            {
                Console.WriteLine($"Число {number} не является простым.");
            }
            else
            {
                Console.WriteLine($"Число {number} является простым.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное целое число больше 1.");
        }
    }
}
