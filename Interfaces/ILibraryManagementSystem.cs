namespace LibrarySystem.Interfaces
{
    public interface ILibraryManagementSystem
    {
        // Public properties
        string UserType { get; set; }
        string Username { get; set; }

        // Methods
        bool Register();
        bool Login();
        bool Logout();
    }
}