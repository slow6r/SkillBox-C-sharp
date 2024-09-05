namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1: Создание переменных и вывод
            
            string fullName = "Ivan Ivanov";
            int age = 20;
            string email = "ivan.ivanov@example.com";
            double programmingScore = 85.5;
            double mathScore = 92.3;
            double physicsScore = 78.4;

            Console.WriteLine("Student Information:");
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine("Scores:");
            Console.WriteLine($"Programming: {programmingScore}");
            Console.WriteLine($"Math: {mathScore}");
            Console.WriteLine($"Physics: {physicsScore}");

            Console.WriteLine("\nPress any key to calculate the total and average scores...");
            Console.ReadKey();

            // Задание 2: Подсчёт баллов и расчёт среднего балла
            
            double totalScore = programmingScore + mathScore + physicsScore;
            
            double averageScore = totalScore / 3;

            Console.WriteLine("\nTotal Score: " + totalScore);
            Console.WriteLine("Average Score: " + Math.Round(averageScore, 2));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
