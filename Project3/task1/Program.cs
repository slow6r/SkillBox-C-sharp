using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        string? inputRows = Console.ReadLine();

        Console.Write("Введите количество столбцов: ");
        string? inputColumns = Console.ReadLine();

        if (int.TryParse(inputRows, out int rows) && int.TryParse(inputColumns, out int columns))
        {

            int[,] matrix = new int[rows, columns];


            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(1, 101); 
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма всех элементов матрицы: " + sum);
        }
        else
        {
            Console.WriteLine("Введены некорректные данные.");
        }
    }
}
