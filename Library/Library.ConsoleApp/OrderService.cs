using System;
using System.Linq;
using Library.Domain;
using Library.Persistence;

namespace Library.ConsoleApp
{
    public class OrderService
    {
        private readonly OrdersRepository _orderRepository;
        private readonly BooksRepository _booksRepository;

        public OrderService(OrdersRepository orderRepository, BooksRepository booksRepository)
        {
            _orderRepository = orderRepository;
            _booksRepository = booksRepository;
        }

        public void PlaceOrder()
        {
            Order order = new Order();

            while (true)
            {
                Console.WriteLine("add - dodaj pozycje do zamowienia");
                Console.WriteLine("end - zamknij zamowienie");
                Console.Write("Komenda: ");

                string command = Console.ReadLine();

                if (command == "end")
                {
                    _orderRepository.Insert(order);
                    Console.WriteLine("Zamówienie zostało dodane.");
                    break;
                }

                if (command == "add")
                {
                    Console.Write("Podaj ID książki: ");
                    int bookId = Convert.ToInt32(Console.ReadLine());

                    var book = _booksRepository.GetAll().FirstOrDefault(b => b.GetHashCode() == bookId);

                    // zabezpieczenie: książka musi istnieć
                    if (book == null)
                    {
                        Console.WriteLine("Nie ma takiej książki!");
                        continue;
                    }

                    Console.Write("Podaj ilość: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    // zabezpieczenie: ilość <= dostępnych
                    if (quantity > book.ProductsAvailable)
                    {
                        Console.WriteLine("Nie ma tylu egzemplarzy na stanie!");
                        continue;
                    }

                    book.ProductsAvailable -= quantity;

                    BookOrdered bookOrdered = new BookOrdered
                    {
                        BookId = book.GetHashCode(),
                        NumberOrdered = quantity
                    };

                    order.BooksOrderedList.Add(bookOrdered);
                    Console.WriteLine("Dodano pozycję do zamówienia.");
                }
                else
                {
                    Console.WriteLine("Nieznana komenda.");
                }
            }
        }

        public void ListAll()
        {
            var orders = _orderRepository.GetAll();

            if (!orders.Any())
            {
                Console.WriteLine("Brak zamówień.");
                return;
            }

            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
