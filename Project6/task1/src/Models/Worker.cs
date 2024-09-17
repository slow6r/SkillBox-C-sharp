namespace MyProject.Models
{
    public struct Worker
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
    }
}
