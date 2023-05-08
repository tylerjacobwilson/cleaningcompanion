namespace CleanCompanion.Models
{
    public class Space
    {
        public string spaceId { get; set; }

        public string spaceName { get; set; }

        public string description { get; set; }

        public string image { get; set; }

        public User userId { get; set; }

        public ICollection<Task> Tasks {get; set; }
    }
}
