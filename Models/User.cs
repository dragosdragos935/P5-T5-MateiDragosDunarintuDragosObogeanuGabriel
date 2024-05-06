namespace aplicatie.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }   

        public string Phone { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public string EmailAddress { get; set; }

        public string EmailSubject { get; set; }

        public string EmailBody { get; set; } = string.Empty;

        public string PhoneNumberBody { get; set; } = string.Empty;
        // alte proprietăți...
    }
}
