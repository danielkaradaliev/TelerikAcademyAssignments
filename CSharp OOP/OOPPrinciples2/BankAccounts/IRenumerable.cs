namespace BankAccounts
{
    public interface IRenumerable
    {
        decimal InterestRate { get; set; }
        decimal CalculateInterestAmount();
    }
}
