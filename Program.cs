using LibrarySystem.Interfaces;
using LibrarySystem.Models;

Console.WriteLine("=== Library Management System Demo ===\n");

ILibraryManagementSystem librarySystem = new LibraryManagementSystem
{
    UserType = "Student",
    Username = "jan.kowalski"
};

Console.WriteLine($"User: {librarySystem.Username}, Type: {librarySystem.UserType}");

IUser student = new Student
{
    Name = "Jan Kowalski",
    ID = 1001,
    Class = "3A"
};

IUser staff = new Staff
{
    Name = "Anna Nowak",
    ID = 2001,
    Dept = "IT Department"
};

Console.WriteLine($"\nStudent: {student.Name}, ID: {student.ID}");
Console.WriteLine($"Staff: {staff.Name}, ID: {staff.ID}, Dept: {((Staff)staff).Dept}");

IAccount account = new Account
{
    NoBorrowedBooks = 3,
    NoReservedBooks = 1,
    NoReturnedBooks = 10,
    NoLostBooks = 0,
    FineAmount = 15.50m
};

Console.WriteLine($"\nAccount Info:");
Console.WriteLine($"  Borrowed: {account.NoBorrowedBooks}");
Console.WriteLine($"  Reserved: {account.NoReservedBooks}");
Console.WriteLine($"  Returned: {account.NoReturnedBooks}");
Console.WriteLine($"  Lost: {account.NoLostBooks}");
Console.WriteLine($"  Fine: {account.FineAmount:C}");

IBook book1 = new Book
{
    Title = "Clean Code",
    Author = "Robert C. Martin",
    ISBN = "978-0132350884",
    Publication = new DateTime(2008, 8, 1)
};

IBook book2 = new Book
{
    Title = "Design Patterns",
    Author = "Gang of Four",
    ISBN = "978-0201633610",
    Publication = new DateTime(1994, 10, 31)
};

IBook book3 = new Book
{
    Title = "The Pragmatic Programmer",
    Author = "Andrew Hunt, David Thomas",
    ISBN = "978-0135957059",
    Publication = new DateTime(2019, 9, 13)
};

Console.WriteLine($"\nBooks in system:");
Console.WriteLine($"  1. {book1.Title} by {book1.Author} (ISBN: {book1.ISBN})");
Console.WriteLine($"  2. {book2.Title} by {book2.Author} (ISBN: {book2.ISBN})");
Console.WriteLine($"  3. {book3.Title} by {book3.Author} (ISBN: {book3.ISBN})");

ILibraryDatabase database = new LibraryDatabase();

Console.WriteLine("\n--- Library Database Operations ---");

try
{
    database.Add(book1);
    database.Add(book2);
    database.Add(book3);
    Console.WriteLine("Books added to database (simulated)");
}
catch (NotImplementedException)
{
    Console.WriteLine("Add operation not yet implemented");
}

ILibrarian librarian = new Librarian
{
    Name = "Maria Wiśniewska",
    ID = 3001
};

Console.WriteLine($"\nLibrarian: {librarian.Name}, ID: {librarian.ID}");
Console.WriteLine("\n--- Testing Operations ---");

try
{
    Console.WriteLine("Attempting to register user...");
    librarySystem.Register();
}
catch (NotImplementedException)
{
    Console.WriteLine("  Register() - Not yet implemented ❌");
}

try
{
    Console.WriteLine("Attempting to login...");
    librarySystem.Login();
}
catch (NotImplementedException)
{
    Console.WriteLine("  Login() - Not yet implemented ❌");
}

try
{
    Console.WriteLine("Attempting to verify user...");
    student.Verify();
}
catch (NotImplementedException)
{
    Console.WriteLine("  Verify() - Not yet implemented ❌");
}

try
{
    Console.WriteLine("Attempting to check account...");
    student.CheckAccount();
}
catch (NotImplementedException)
{
    Console.WriteLine("  CheckAccount() - Not yet implemented ❌");
}

try
{
    Console.WriteLine("Attempting to request book...");
    book1.BookRequest();
}
catch (NotImplementedException)
{
    Console.WriteLine("  BookRequest() - Not yet implemented ❌");
}

try
{
    Console.WriteLine("Attempting to calculate fine...");
    account.CalculateFine();
}
catch (NotImplementedException)
{
    Console.WriteLine("  CalculateFine() - Not yet implemented ❌");
}

try
{
    Console.WriteLine("Attempting to search books...");
    librarian.Search();
}
catch (NotImplementedException)
{
    Console.WriteLine("  Search() - Not yet implemented ❌");
}

Console.WriteLine("\n=== Summary ===");
Console.WriteLine("All models and interfaces are properly structured.");
Console.WriteLine("Implementation of business logic is pending.");
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
