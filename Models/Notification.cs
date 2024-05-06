namespace aplicatie.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public DateTime SentDate { get; set; }
        // alte proprietăți...
    }
}
