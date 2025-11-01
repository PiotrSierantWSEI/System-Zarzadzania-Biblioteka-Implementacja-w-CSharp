using LibrarySystem.Interfaces;

namespace LibrarySystem.Models
{
    public class Staff : User, IStaff
    {
        public string Dept { get; set; } = string.Empty;
    }
}