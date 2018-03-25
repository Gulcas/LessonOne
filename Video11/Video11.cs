using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video11
{
    class Video11 //defining and colling method - definiowanie i przywoływanie metod wykorzystując parametr wejściowy i wyjściowy
    {
        static void Main(string[] args)
        {
            HelloWorld(); //została przywołana metoda pomocznicza
            Console.ReadLine();

            Console.Write("Podaj imię: "); //pytanie wyrzucone na konsolę
            string firstName = Console.ReadLine(); //wyłapanie odpowiedzi od użytkownika i przypisanie do niej stringa

            Console.Write("Podaj nazwiski: ");
            string secondName = Console.ReadLine();

            Console.Write("Podaj swoje City: ");
            string cityName = Console.ReadLine();

            // ReverseString(firstName); //przywołanie metody pomocniczej, i przekazanie jej parametru firstName 
            //wcześniej określonego przez odczytanie danych podanych przez użytkownika- można byłoby tak zrobić gdyby metoda pomocnicza wykonywała dwa zadania,
            //zamieniała string na char'y odwracała ich kolejność i drukowała je na ekranie, ale może to wprowadzać zamęt w programie,
            // string reversedSecondName = ReverseString(secondName); //przywołanie metody pomocniczej, która ma zwrócić mi string na podstawie tego co jej przekazałem,
            //można to pominąć bo przecież te parametry wykorzystam w kolejnej metodzie pomocniczej
            // string reversedCityName = ReverseString(cityName);

            DisplayResult(ReverseString(secondName), ReverseString(cityName)); //przywołuję metodę pomocniczą która przyjmuje określne wcześniej parametry
            DisplayResultShort(ReverseString(secondName) + " " + ReverseString(cityName)); //przywołuję metodę pomocniczą której przesyłam parametr daję spację i przesyłam inny parametr
            Console.ReadLine();
        }

        private static void HelloWorld() //utworzona metoda pomocnicza poza metodą główną, ale jeszcze wewnątrz clasy Video11
        {
            Console.WriteLine("Hello");
        }

        private static string ReverseString(string message) // tworzę metodę pomocniczą która musi przyjąć string message jako parametr by wykonać swoje zadanie i zwrócić mi string
                                                            //jeżeli metoda ma nazwę public static void oznacza to że nie zwraca żadnego parametru
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray); //w tym miejscu odwracam kolejność listy znaków messageArray
            return String.Concat(messageArray); //metoda zwraca stringa który zbiera wszystkie znaki z listy messageArray i łączy je w string

            /* foreach (char item in messageArray)
             {
                 Console.Write(item);
             }
             Console.Write(" "); //dodaję spację po każdym użyciu tej metody by nie łączyć w jeden ciąg wyników tej metody
             */
        }

        private static void DisplayResult(string reversedSecondName, string reversedCityName) //metoda przyjmująca dwa parametry wejściowe
        {

            Console.Write("Wynik: ");
            Console.Write(String.Format("{0} {1}", reversedSecondName, reversedCityName)); //wyrzucam na konsolę pierwszy i drugi przyjęty parametr
        }

        private static void DisplayResultShort(string message)
        {
            Console.Write("Result w krótszym kodzie: ");
            Console.WriteLine(message);
        }
    }
}
