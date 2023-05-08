namespace CleanCompanion.Models
{
    public class Task
    {
        public int taskId { get; set; }
        public string description { get; set; }

        public string owner { get; set; }

        public Space spaceId { get; set; }

        public ICollection<TaskCompletion> TaskCompletions {get; set; }
    }
}