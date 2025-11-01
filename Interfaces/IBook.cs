namespace LibrarySystem.Interfaces
{
    public interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        string ISBN { get; set; }
        DateTime Publication { get; set; }
        DateTime ShowDueDate();
        bool ReservationStatus();
        void Feedback();
        bool BookRequest();
        bool RenewInfo();
    }
}