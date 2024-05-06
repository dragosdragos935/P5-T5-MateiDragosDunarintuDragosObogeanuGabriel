namespace aplicatie.Models
{
    //cest model ar putea reprezenta un împrumut acordat de către bancă unui client. 
    public class Loan
    {
        public int LoanId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        // alte proprietăți...
    }
}
