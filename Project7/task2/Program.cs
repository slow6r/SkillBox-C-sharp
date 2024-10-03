class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        CollectPhoneBookData(phoneBook);
        
        Console.WriteLine("Enter phone number to search:");
        string? phoneNumber = Console.ReadLine(); // Using nullable string (string?)
        
        if (phoneNumber != null && phoneBook.TryGetValue(phoneNumber, out string? owner))
        {
            Console.WriteLine($"Owner: {owner}");
        }
        else
        {
            Console.WriteLine("No owner found for this number.");
        }
    }

    static void CollectPhoneBookData(Dictionary<string, string> phoneBook)
    {
        while (true)
        {
            Console.WriteLine("Enter phone number (or press Enter to finish):");
            string? phone = Console.ReadLine(); // Using nullable string (string?)
            if (string.IsNullOrWhiteSpace(phone)) break;

            Console.WriteLine("Enter owner's name:");
            string? name = Console.ReadLine(); // Using nullable string (string?)
            if (name != null && phone != null)
            {
                phoneBook[phone] = name;
            }
        }
    }
}
