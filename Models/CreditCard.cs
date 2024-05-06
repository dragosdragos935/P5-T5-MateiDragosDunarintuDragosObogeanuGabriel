namespace aplicatie.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }
        public int UserId { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal CurrentBalance { get; set; }
        // alte proprietăți...
    }
}
