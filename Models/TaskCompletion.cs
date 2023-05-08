using System.ComponentModel.DataAnnotations;

namespace CleanCompanion.Models
{
    public class TaskCompletion
    {
        [Required]
        public string taskCompletionId { get; set; }

        public string dateCompleted { get; set; }
        [Required]
        public User userId { get; set; }
        [Required]
        public Task taskId { get; set; }




    }
}
