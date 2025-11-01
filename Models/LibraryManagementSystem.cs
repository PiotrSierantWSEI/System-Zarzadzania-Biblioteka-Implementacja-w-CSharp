using LibrarySystem.Interfaces;

namespace LibrarySystem.Models
{
    public class LibraryManagementSystem: ILibraryManagementSystem
    {
        // Public properties
        public string UserType { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;

        // Private property
        private string Password { get; set; } = string.Empty;

        // Methods
        public bool Register()
        {
            throw new NotImplementedException();
        }
        public bool Login()
        {
            throw new NotImplementedException();
        }
        public bool Logout()
        {
            throw new NotImplementedException();
        }
    }
}