namespace aplicatie.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int SourceAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        // alte proprietăți...
    }
}
