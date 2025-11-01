namespace LibrarySystem.Interfaces
{
    public interface ILibraryDatabase
    {
        void Add(IBook book);
        void Delete(IBook book);
        List<IBook> Update(IBook book);
        List<IBook> Display();
        List<IBook> Search(string query);
    }
}