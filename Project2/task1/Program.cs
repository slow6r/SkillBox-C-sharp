
class Program
{
    static void Main()
    {

        Console.WriteLine("Введите целое число:");

        string? input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int number))
        {
    
            if (number % 2 == 0)
            {
                Console.WriteLine("Число является чётным.");
            }
            else
            {
                Console.WriteLine("Число является нечётным.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное целое число.");
        }
    }
}
