using System;
using System.Linq;
using Library.Domain;
using Library.Persistence;

namespace Library.ConsoleApp
{
    public class BooksService
    {
        // 1. Pole repozytorium – TO jest _repository
        private readonly BooksRepository _repository;

        // 2. Konstruktor – przyjmuje BooksRepository i zapisuje do pola
        public BooksService(BooksRepository repository)
        {
            _repository = repository;
        }

        public void AddBook()
        {
            Console.Write("Podaj tytuł: ");
            string title = Console.ReadLine();

            Console.Write("Podaj autora: ");
            string author = Console.ReadLine();

            Console.Write("Podaj rok wydania: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Podaj liczbę dostępnych sztuk: ");
            int productsAvailable = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj cenę: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            var book = new Book(title, author, year, isbn, productsAvailable, price);

            // 3. Tutaj używamy _repository – błąd CS0103 zniknie
            _repository.Insert(book);

            Console.WriteLine("Książka została dodana.");
        }

        public void RemoveBook()
        {
            Console.Write("Podaj tytuł książki do usunięcia: ");
            string title = Console.ReadLine();

            _repository.RemoveByTitle(title);

            Console.WriteLine("Operacja usunięcia zakończona (jeśli książka istniała).");
        }

        public void ListBooks()
        {
            var books = _repository.GetAll();

            Console.WriteLine("Tutaj pojawi sie lista ksiazek");

            if (!books.Any())
            {
                Console.WriteLine("(Brak książek w repozytorium)");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void ChangeState()
        {
            Console.Write("Podaj tytuł książki, której stan chcesz zmienić: ");
            string title = Console.ReadLine();

            Console.Write("Podaj nowy stan (liczbę dostępnych sztuk): ");
            int newState = Convert.ToInt32(Console.ReadLine());

            _repository.ChangeState(title, newState);

            Console.WriteLine("Stan magazynowy został zmieniony (jeśli książka istniała).");
        }
    }
}
