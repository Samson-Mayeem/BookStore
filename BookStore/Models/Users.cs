namespace BookStore.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public string? Email { get; set; }
        public int ?Password { get; set; }
    }
}