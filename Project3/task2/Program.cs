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
        
            int[,] matrixA = new int[rows, columns];
            int[,] matrixB = new int[rows, columns];

            Random random = new Random();

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixA[i, j] = random.Next(1, 101);
                    matrixB[i, j] = random.Next(1, 101); 
                }
            }

            Console.WriteLine("Матрица A:");
            PrintMatrix(matrixA);

            Console.WriteLine("Матрица B:");
            PrintMatrix(matrixB);

            int[,] matrixC = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            Console.WriteLine("Сумма матриц A и B:");
            PrintMatrix(matrixC);
        }
        else
        {
            Console.WriteLine("Введены некорректные данные.");
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
