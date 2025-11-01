using LibrarySystem.Interfaces;

namespace LibrarySystem.Models
{
    public class Librarian : ILibrarian
    {
        public string Name { get; set; } = string.Empty;
        public int ID { get; set; }
        // - Password: string
        private string Password { get; set; } = string.Empty;

        public List<IBook> Search()
        {
            throw new NotImplementedException();
        }

        public bool VerifyLibrarian()
        {
            throw new NotImplementedException();
        }
    }
}