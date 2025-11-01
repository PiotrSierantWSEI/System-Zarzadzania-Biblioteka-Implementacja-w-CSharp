using LibrarySystem.Interfaces;

namespace LibrarySystem.Models
{
    public class User : IUser
    {
        public string Name { get; set; } = string.Empty;
        public int ID { get; set; }

        public IAccount CheckAccount()
        {
            throw new NotImplementedException();
        }

        public List<IBook> GetBookInfo()
        {
            throw new NotImplementedException();
        }

        public bool Verify()
        {
            throw new NotImplementedException();
        }
    }
}