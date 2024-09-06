class Program
{
    static void Main()
    {
        
        Console.WriteLine("Добро пожаловать в игру '21'!");

        
        Console.WriteLine("Сколько у вас на руках карт?");
        string? input = Console.ReadLine();

        
        if (int.TryParse(input, out int cardCount) && cardCount > 0)
        {
            int sum = 0;

            
            for (int i = 1; i <= cardCount; i++)
            {
                Console.WriteLine($"Введите номинал карты {i}:");
                string? cardInput = Console.ReadLine();

                if (cardInput != null)
                {
                    switch (cardInput.ToUpper())
                    {
                        case "J":
                        case "Q":
                        case "K":
                        case "T":
                            sum += 10;
                            break;
                        default:
                            if (int.TryParse(cardInput, out int cardValue) && cardValue >= 2 && cardValue <= 10)
                            {
                                sum += cardValue;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: введите корректный номинал карты.");
                                i--; 
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректный номинал карты.");
                    i--; 
                }
            }

            Console.WriteLine($"Сумма ваших карт: {sum}");
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное количество карт.");
        }
    }
}
