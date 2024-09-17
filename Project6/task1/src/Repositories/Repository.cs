using MyProject.Models;

namespace MyProject.Repositories
{
    public class Repository
    {
        private readonly string _fileName = "workers.txt";

        public Worker[] GetAllWorkers()
        {
            if (!File.Exists(_fileName))
                return new Worker[0];

            return File.ReadAllLines(_fileName)
                       .Select(line => ParseWorker(line))
                       .ToArray();
        }

        public void AddWorker(Worker worker)
        {
            var workers = GetAllWorkers();
            worker.Id = workers.Length == 0 ? 1 : workers.Max(w => w.Id) + 1;
            worker.DateAdded = DateTime.Now;

            var line = WorkerToString(worker);
            File.AppendAllText(_fileName, line + Environment.NewLine);
        }

        private static Worker ParseWorker(string line)
        {
            var parts = line.Split('#');
            return new Worker
            {
                Id = int.Parse(parts[0]),
                DateAdded = DateTime.Parse(parts[1]),
                FIO = parts[2],
                Age = int.Parse(parts[3]),
                Height = int.Parse(parts[4]),
                BirthDate = DateTime.Parse(parts[5]),
                BirthPlace = parts[6]
            };
        }

        private static string WorkerToString(Worker worker)
        {
            return $"{worker.Id}#{worker.DateAdded}#{worker.FIO}#{worker.Age}#{worker.Height}#{worker.BirthDate}#{worker.BirthPlace}";
        }
    }
}
