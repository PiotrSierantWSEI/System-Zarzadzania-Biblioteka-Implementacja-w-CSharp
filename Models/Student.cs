using LibrarySystem.Interfaces;

namespace LibrarySystem.Models
{
    public class Student : User, IStudent
    {
        public string Class { get; set; } = string.Empty;
    }
}