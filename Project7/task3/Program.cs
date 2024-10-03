using System.Xml.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите данные контакта:");

        Console.WriteLine("ФИО:");
        string? name = Console.ReadLine(); // Используем nullable string

        Console.WriteLine("Улица:");
        string? street = Console.ReadLine();

        Console.WriteLine("Номер дома:");
        string? houseNumber = Console.ReadLine();

        Console.WriteLine("Номер квартиры:");
        string? flatNumber = Console.ReadLine();

        Console.WriteLine("Мобильный телефон:");
        string? mobilePhone = Console.ReadLine();

        Console.WriteLine("Домашний телефон:");
        string? flatPhone = Console.ReadLine();

        // Проверяем, что данные не null
        if (name == null || street == null || houseNumber == null || flatNumber == null || mobilePhone == null || flatPhone == null)
        {
            Console.WriteLine("Ошибка: Ввод не может быть пустым.");
            return;
        }

        XElement contact = new XElement("Person", new XAttribute("name", name),
            new XElement("Address",
                new XElement("Street", street),
                new XElement("HouseNumber", houseNumber),
                new XElement("FlatNumber", flatNumber)
            ),
            new XElement("Phones",
                new XElement("MobilePhone", mobilePhone),
                new XElement("FlatPhone", flatPhone)
            )
        );

        contact.Save("Contact.xml");
        Console.WriteLine("XML файл 'Contact.xml' успешно создан.");
    }
}
