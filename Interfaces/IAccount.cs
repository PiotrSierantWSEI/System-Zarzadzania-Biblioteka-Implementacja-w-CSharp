namespace LibrarySystem.Interfaces
{
    public interface IAccount
    {
        int NoBorrowedBooks { get; set; }
        int NoReservedBooks { get; set; }
        int NoReturnedBooks { get; set; }
        int NoLostBooks { get; set; }
        decimal FineAmount { get; set; }
        decimal CalculateFine();
    }
}