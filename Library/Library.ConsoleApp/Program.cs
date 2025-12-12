using Library.Domain;
using Library.Persistence;
using Library.ConsoleApp;


//Book book = new Book(
//    "Wiedźmin: Ostatnie życzenie",
//    "Andrzej Sapkowski",
//    1993,
//    "978-83-7578-063-5",
//    10,
//    39.99m
//);


//Console.WriteLine(book.ToString());



//Console.Write("Podaj login: ");
//string login = Console.ReadLine();

//Console.Write("Podaj hasło: ");
//string password = Console.ReadLine();

//if (login == "Admin" && password == "password")
//{
//    Console.WriteLine("Access Granted");
//}
//else
//{
//    Console.WriteLine("Access Denied");
//}


/// zadanie 3
BooksRepository booksRepository = new BooksRepository();
OrdersRepository ordersRepository = new OrdersRepository();

BooksService booksService = new BooksService(booksRepository);
OrderService orderService = new OrderService(ordersRepository, booksRepository);



while (true)
{
    Console.Clear();

    Console.WriteLine("========= MENU =========");
    Console.WriteLine("(1)dodaj  - dodaj książkę");
    Console.WriteLine("(2)usun   - usuń książkę");
    Console.WriteLine("(3)wypisz - wypisz wszystkie książki");
    Console.WriteLine("(4)zmien  - zmień stan magazynowy książek");
    Console.WriteLine("(5)dodaj zamowienie - dodaj nowe zamówienie");
    Console.WriteLine("(6)lista zamowien   - lista wszystkich zamówień");
    Console.WriteLine("(7)wyjdz - zakończ program");
    Console.WriteLine("========================");

    Console.Write("Wpisz komendę: ");
    string command = Console.ReadLine();

    Console.Clear();

    if (command == "wyjdz" || command == "7")
    {
        Console.WriteLine("Zamykanie programu...");
        break;
    }
    else if (command == "dodaj" || command == "1")
    {
        booksService.AddBook();
    }
    else if (command == "usun" || command == "2")
    {
        booksService.RemoveBook();
    }
    else if (command == "wypisz" || command == "3")
    {
        booksService.ListBooks();
    }
    else if (command == "zmien" || command == "4")
    {
        booksService.ChangeState();
    }
    else if (command == "dodaj zamowienie" || command == "5")
    {
        orderService.PlaceOrder();
    }
    else if (command == "lista zamowien" || command == "6")
    {
        orderService.ListAll();
    }
    else
    {
        Console.WriteLine("Podana komenda nie jest wspierana.");
    }

    Console.WriteLine();
    Console.WriteLine("Press Any Key...");
    Console.ReadKey();
}


