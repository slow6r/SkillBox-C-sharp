class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Вывести данные на экран");
            Console.WriteLine("2 - Добавить нового сотрудника");

            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                ShowEmployees();
            }
            else if (choice == "2")
            {
                AddEmployee();
            }
            else
            {
                Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
            }
        }
    }

    // Метод для вывода всех записей из файла
    static void ShowEmployees()
    {
        string filePath = "employees.txt";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] employeeData = line.Split('#');
                Console.WriteLine($"ID: {employeeData[0]}, Дата добавления: {employeeData[1]}, ФИО: {employeeData[2]}, Возраст: {employeeData[3]}, Рост: {employeeData[4]}, Дата рождения: {employeeData[5]}, Место рождения: {employeeData[6]}");
            }
        }
        else
        {
            Console.WriteLine("Файл с сотрудниками не найден.");
        }
    }

    // Метод для добавления нового сотрудника
    static void AddEmployee()
    {
        string filePath = "employees.txt";
        int id = 1;

        // Определение ID для нового сотрудника
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];
                string[] lastEmployeeData = lastLine.Split('#');
                id = int.Parse(lastEmployeeData[0]) + 1;
            }
        }

        // Ввод данных сотрудника
        Console.WriteLine("Введите Ф.И.О.:");
        string? name = Console.ReadLine();
        name = string.IsNullOrEmpty(name) ? "Неизвестный" : name;

        Console.WriteLine("Введите возраст:");
        int age = GetValidIntInput();

        Console.WriteLine("Введите рост:");
        int height = GetValidIntInput();

        Console.WriteLine("Введите дату рождения (дд.мм.гггг):");
        string? birthDate = Console.ReadLine();
        birthDate = string.IsNullOrEmpty(birthDate) ? "01.01.1900" : birthDate;

        Console.WriteLine("Введите место рождения:");
        string? birthPlace = Console.ReadLine();
        birthPlace = string.IsNullOrEmpty(birthPlace) ? "Неизвестно" : birthPlace;

        // Запись данных в файл
        string newEmployee = $"{id}#{DateTime.Now}#{name}#{age}#{height}#{birthDate}#{birthPlace}";
        File.AppendAllText(filePath, newEmployee + Environment.NewLine);

        Console.WriteLine("Сотрудник успешно добавлен.");
    }

    // Метод для проверки корректности ввода числа
    static int GetValidIntInput()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            Console.WriteLine("Ошибка ввода. Введите корректное число.");
        }
    }
}
