namespace Turkiz.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public bool UserType { get; set; } // 0 = client 1 = admin
        
        
    }
}