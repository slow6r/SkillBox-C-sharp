using MyProject.Repositories;
using MyProject.Models;

class Program
{
    static void Main()
    {
        Repository repo = new();

        // Пример использования репозитория
        repo.AddWorker(new Worker { FIO = "Роберт Павлов Ибрагимович", Age = 100, Height = 210, BirthDate = new DateTime(1992, 5, 5), BirthPlace = "Махачкала" });
        
        var workers = repo.GetAllWorkers();
        foreach (var worker in workers)
        {
            Console.WriteLine($"{worker.Id}: {worker.FIO}");
        }
    }
}
