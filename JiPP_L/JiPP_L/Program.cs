//Pierwszy program - rozgrzewka

//int number = 25;
//float money = 12.5f;
//string text = "Example text";
//bool isLogged = true;
//char myChar = 'A';
//decimal price = 199.99m;

////Operatory
////zadanie 1 : Wyświetl wszystkie zmienne na konsoli.
//Console.WriteLine("number: " + number);
//Console.WriteLine("money: " + money);
//Console.WriteLine("text: " + text);
//Console.WriteLine("isLogged: " + isLogged);
//Console.WriteLine("myChar: " + myChar);
//Console.WriteLine("price: " + price);

//Zadanie 2
//string myAge = "Age:";
//int wifeAge = 18;

//var result = myAge + wifeAge;
//Console.WriteLine("result: " + result);

//Zadanie 3
//bool isTrue = true;
//bool isFalse = false;
//bool isReallyTrue = true;

//bool and = isTrue && isFalse;
//bool or = isTrue || isReallyTrue;
//bool negative = !isFalse;

//Console.WriteLine("and: " + and);
//Console.WriteLine("or: " + or);
//Console.WriteLine("negative: " + negative);

//zadanie 4
//int a = 5;
//int b = 12;

//string add = "add: " + (a + b);
//string sub = "sub: " + (a - b);
//string div = "div: " + (a / b);
//string mul = "mul: " + (a * b);
//string mod = "mod: " + (a % b);

//Console.WriteLine(add);
//Console.WriteLine(sub);
//Console.WriteLine(div);
//Console.WriteLine(mul);
//Console.WriteLine(mod);

//Zadanie 5
//string a = "Ala";
//string b = "ma";
//string c = "kota.";

//string results = a + " "+ b + " " + c;
//Console.WriteLine(results);

//Instrukcje sterujące i pętle
// zadanie 1
//int n1 = 10;
//int n2 = 20;

//if (n1 > n2)
//{
//    Console.WriteLine("n1 jest większe od n2");
//}
//else if (n1 < n2)
//{
//    Console.WriteLine("n1 jest mniejsze od n2");
//}
//else
//{
//    Console.WriteLine("n1 jest równe n2");
//}

//// zadanie 2
////pętla for
//for (int p = 0; p < 10; p++)
//{
//    Console.WriteLine("C#");
//}

//// pętla while
//int i = 0;
//int count = 10;

//while (i < count)
//{
//    Console.WriteLine("c#");
//    i++;
//}

//// zadanie 3
//int n = 10;

//for (int j = 1; j <= n; j++)
//{
//    if (j % 2 == 0)
//    {
//        Console.WriteLine("Liczba " + j + " - parzysta");
//    }
//    else
//    {
//        Console.WriteLine("Liczba " + j + " - nieparzysta");
//    }
//}

// zadanie 4
//int n = 5;

//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

// zadanie 5

//int exam = 57;

//if (exam < 0 || exam > 100)
//{
//    Console.WriteLine(" Wartość poza zakresem");
//}
//else if (exam <= 39)
//{
//    Console.WriteLine("Ocena: Niedostateczna");
//}
//else if (exam <= 54)
//{
//    Console.WriteLine("Ocena: Dopuszczająca");
//}
//else if (exam <= 69)
//{
//    Console.WriteLine("Ocena: Dopuszczająca");
//}
//else if (exam <= 84)
//{
//    Console.WriteLine("Ocena: Dobra");
//}
//else if (exam <= 98)
//{
//    Console.WriteLine("Ocena: Bardzo dobra");
//}
//else
//{
//    Console.WriteLine("Ocena: Celująca");
//}

// Kolekcje
// zadanie 1

//string[] colors = new string[4];
//colors[0] = "Czerwony";
//colors[1] = "Zielony";
//colors[2] = "Niebieski";
//colors[3] = "Żółty";

//Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
//Console.WriteLine("Mój ostatni kolor to: " + colors[3]);

// zadanie 2

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//pętla for
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("Liczba: " + numbers[i]);
//}

////pętla foreach

//foreach (int number in numbers)
//{
//    Console.WriteLine("Liczba: " + number);
//}

//pętla while
//int i = 0;
//int count = numbers.Length;

//do {
//    Console.WriteLine("Liczba: " + numbers[i]);
//    i++;
//} while (i < count);

// zadanie 3
List<string> fruits = new List<string>();

fruits.Add("Pomidor");
fruits.Add("Jabłko");
fruits.Add("Marchewka");
fruits.Add("Gruszka");

Console.WriteLine("Wszystkie owoce: ");
Console.WriteLine(string.Join(", ", fruits));

fruits.RemoveAt(0);
fruits.Remove("Gruszka");

Console.WriteLine("Owoce po usunięciu: ");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
Console.ReadKey();