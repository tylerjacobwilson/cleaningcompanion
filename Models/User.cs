namespace CleanCompanion.Models
{
    public class User
    {
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public string password { get; set; }

        public ICollection<Space> spaces { get; set; }
    }
}
