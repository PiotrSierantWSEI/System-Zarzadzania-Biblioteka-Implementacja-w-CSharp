using LibrarySystem.Interfaces;

namespace LibrarySystem.Models
{
    public class LibraryDatabase : ILibraryDatabase
    {
        // - ListOfBooks: List<Book>
        private List<IBook> ListOfBooks { get; set; } = [];
        public void Add(IBook book)
        {
            throw new NotImplementedException();
        }

        public void Delete(IBook book)
        {
            throw new NotImplementedException();
        }

        public List<IBook> Display()
        {
            throw new NotImplementedException();
        }

        public List<IBook> Search(string query)
        {
            throw new NotImplementedException();
        }

        public List<IBook> Update(IBook book)
        {
            throw new NotImplementedException();
        }
    }
}