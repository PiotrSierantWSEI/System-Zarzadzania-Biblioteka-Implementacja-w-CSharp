# 📚 System Zarządzania Biblioteką (Library Management System)

## 📖 Opis projektu

System Zarządzania Biblioteką to aplikacja konsolowa napisana w **C# (.NET)**, która implementuje wzorce projektowe oraz zasady programowania obiektowego. Projekt został stworzony w ramach zajęć z **Wzorców Projektowych** na studiach.

## 🎯 Cel projektu

Celem projektu jest zaprojektowanie i implementacja systemu bibliotecznego z przygotowanego wcześniej diagramu.

## 🏗️ Architektura systemu

Projekt ma podział na:
- **Interfaces** - interfejsy definiujące kontrakty
- **Models** - implementacje klas biznesowych
- **Program.cs** - punkt wejścia aplikacji

## 📊 Diagram klas UML

```
┌─────────────────────────────────────┐
│   LibraryManagementSystem           │
├─────────────────────────────────────┤
│ + UserType: string                  │
│ + Username: string                  │
│ - Password: string                  │
├─────────────────────────────────────┤
│ + Login(): bool                     │
│ + Register(): bool                  │
│ + Logout(): void                    │
└──────────┬──────────────────────────┘
           │
           │ manages
           ↓
┌──────────────────────┐              ┌─────────────────────────┐
│       User           │              │      Librarian          │
├──────────────────────┤              ├─────────────────────────┤
│ + Name: string       │              │ + Name: string          │
│ + ID: int            │              │ + ID: int               │
├──────────────────────┤              │ - Password: string      │
│ + Verify(): bool     │◄─────────────┤─────────────────────────┤
│ + CheckAccount()     │   verifies   │ + VerifyLibrarian()     │
│ + GetBookInfo()      │              │ + Search(): List<Book>  │
└──────┬───────────────┘              └──────────┬──────────────┘
       │                                         │
       │ has                                     │ searches
       ↓                                         ↓
┌──────────────────┐                    ┌──────────────────────┐
│    Account       │                    │   LibraryDatabase    │
├──────────────────┤                    ├──────────────────────┤
│ + NoBorrowedBooks│                    │ - ListOfBooks        │
│ + NoReservedBooks│                    ├──────────────────────┤
│ + NoReturnedBooks│                    │ + Add(Book)          │
│ + NoLostBooks    │                    │ + Delete(Book)       │
│ + FineAmount     │                    │ + Update(Book)       │
├──────────────────┤                    │ + Display()          │
│ + CalculateFine()│                    │ + Search(string)     │
└──────────────────┘                    └──────────┬───────────┘
                                                  │
       ↑                                          │ manages
       │ inherits                                 ↓
       │                                 ┌───────────────────┐
┌──────┴─────┐   ┌─────────┐             │      Book         │
│  Student   │   │  Staff  │             ├───────────────────┤
├────────────┤   ├─────────┤             │ + Title: string   │
│ + Class    │   │ + Dept  │             │ + Author: string  │
└────────────┘   └─────────┘             │ + ISBN: string    │
                                         │ + Publication     │
                                         ├───────────────────┤
                                         │ + ShowDueDate()   │
                                         │ + BookRequest()   │
                                         │ + RenewInfo()     │
                                         │ + Feedback()      │
                                         └───────────────────┘
```

### Szczegółowy diagram UML

Pełny diagram klas znajduje się w pliku: [lab2.drawio.pdf](lab2.drawio.pdf)

## 🔧 Technologie

- **Język**: C# 13
- **Framework**: .NET 9.0
- **IDE**: Visual Studio Code
- **System operacyjny**: Windows

## 📁 Struktura projektu

```
LibrarySystem/
│
├── Interfaces/
│   ├── ILibraryManagementSystem.cs
│   ├── IUser.cs
│   ├── IStudent.cs
│   ├── IStaff.cs
│   ├── IAccount.cs
│   ├── IBook.cs
│   ├── ILibrarian.cs
│   └── ILibraryDatabase.cs
│
├── Models/
│   ├── LibraryManagementSystem.cs
│   ├── User.cs
│   ├── Student.cs
│   ├── Staff.cs
│   ├── Account.cs
│   ├── Book.cs
│   ├── Librarian.cs
│   └── LibraryDatabase.cs
│
├── Program.cs
├── README.md
└── lab2.drawio.pdf
```

## 🎨 Wzorce projektowe

## 🚀 Uruchomienie projektu

### Wymagania
- .NET SDK 8.0 lub nowszy
- Visual Studio Code (opcjonalnie)

### Kompilacja i uruchomienie

```bash
# Przejdź do folderu projektu
cd LibrarySystem

# Uruchom aplikację
dotnet run

# Lub zbuduj projekt
dotnet build
```

## 📝 Główne klasy i ich odpowiedzialności

### 1. LibraryManagementSystem
Główna klasa systemu odpowiedzialna za:
- Rejestrację użytkowników
- Logowanie i wylogowywanie
- Zarządzanie sesjami użytkowników

### 2. User (klasa bazowa)
Reprezentuje użytkownika biblioteki z możliwością:
- Weryfikacji tożsamości
- Sprawdzania konta
- Pobierania informacji o książkach

#### Student (dziedziczy po User)
- Dodatkowe pole: `Class` (klasa)

#### Staff (dziedziczy po User)
- Dodatkowe pole: `Dept` (dział)

### 3. Account
Zarządza kontem użytkownika:
- Liczba wypożyczonych książek
- Liczba zarezerwowanych książek
- Liczba zwróconych książek
- Liczba zgubionych książek
- Obliczanie kar finansowych

### 4. Book
Reprezentuje książkę w systemie:
- Informacje o książce (tytuł, autor, ISBN, data publikacji)
- Rezerwacja książki
- Żądanie wypożyczenia
- Odnowienie wypożyczenia
- System feedbacku

### 5. Librarian
Bibliotekarz z uprawnieniami do:
- Wyszukiwania książek
- Weryfikacji bibliotecznej
- Zarządzania zbiorami

### 6. LibraryDatabase
Baza danych biblioteki umożliwiająca:
- Dodawanie książek
- Usuwanie książek
- Aktualizację danych
- Wyświetlanie katalogu
- Wyszukiwanie książek

## 👨‍💻 Autor

**Piotr**  
Rok 2, Wzorce Projektowe  
Data: Listopad 2025

## 📄 Licencja

Projekt edukacyjny - wszystkie prawa zastrzeżone.

## 📚 Dokumentacja dodatkowa

- [Diagram UML (PDF)](lab2.drawio.pdf)
- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Design Patterns in C#](https://refactoring.guru/design-patterns/csharp)

---

*Projekt stworzony w ramach zajęć z Wzorców Projektowych*