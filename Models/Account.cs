using LibrarySystem.Interfaces;

namespace LibrarySystem.Models
{
    public class Account : IAccount
    {
        public int NoBorrowedBooks { get ; set ; }
        public int NoReservedBooks { get ; set ; }
        public int NoReturnedBooks { get ; set ; }
        public int NoLostBooks { get ; set ; }
        public decimal FineAmount { get ; set ; }

        public decimal CalculateFine()
        {
            throw new NotImplementedException();
        }
    }
}