using LibrarySystem.Interfaces;

namespace LibrarySystem.Models
{
    public class Book : IBook
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public DateTime Publication { get; set; } = DateTime.Now;

        public bool BookRequest()
        {
            throw new NotImplementedException();
        }

        public void Feedback()
        {
            throw new NotImplementedException();
        }

        public bool RenewInfo()
        {
            throw new NotImplementedException();
        }

        public bool ReservationStatus()
        {
            throw new NotImplementedException();
        }

        public DateTime ShowDueDate()
        {
            throw new NotImplementedException();
        }
    }
}