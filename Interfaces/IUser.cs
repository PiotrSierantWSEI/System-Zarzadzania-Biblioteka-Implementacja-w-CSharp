namespace LibrarySystem.Interfaces
{
    public interface IUser
    {
        string Name { get; set; }
        int ID { get; set; }
        bool Verify();
        IAccount CheckAccount();
        List<IBook> GetBookInfo();
    }
}