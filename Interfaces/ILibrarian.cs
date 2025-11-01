namespace LibrarySystem.Interfaces
{
    public interface ILibrarian
    {
        string Name { get; set; }
        int ID { get; set; }
        bool VerifyLibrarian();
        List<IBook> Search();
    }
}