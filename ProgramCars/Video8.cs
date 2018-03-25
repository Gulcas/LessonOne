using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCars //application name
{
    class Video8 //class
    {
        static void Main(string[] args)     //code block = metod
        {
            /*komentarz
             * wielolinijkowy
             */
            Console.WriteLine("Let's know each other.");
            int x; //deklaracja wartości zmiennej x
            x = 7;
            int y = x + 3; //to jest STATEMENT (z angielskiego wyrażenie)
            //operatory są stałe w C# i trzeba je zapamiętać, to np int, string
            Console.WriteLine(y); //klasa Console
            Console.WriteLine("Let's find out what is your name.");
            string myName; //utworzony string --> korzystając z CTRL+. można zmienić nazwy wszystkich tych zmiennych
            Console.Write("Type your surname: ");
            string mySurname = Console.ReadLine(); //skrócony zapis kodu wyłapującego dane od usera
            Console.Write("Tape in your name: ");

            for (int i = 0; i < 5; i++)
            {
                myName = Console.ReadLine(); //ten string został zadeklarowany wcześniej, tu tylko wyłapuje wpis od usera

                if (myName == "Rafal")
                {
                    Console.WriteLine("Hi, " + myName + " " + mySurname);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong name or bad capitalization. Please try one more time.");
                }
            }

            Console.WriteLine("Podaj liczbę.");
            int lottery = Convert.ToInt32(Console.ReadLine()); //wyłapanie int od usera, wyłapana linijka jest od razu konwertowana na int
            string message;
            if (lottery == 1) //nie ma konieczności stosowania {} jeżeli wykonujemy tylko jedną linijkę kodu
                message = "yes it's 1 " + 1 + lottery;
            else if (lottery > 1)
                message = "number is to high " + 22 + lottery;
            else if (lottery < 1)
                message = "to small number " + 33 + lottery;
            else
                message = "nie trafiłeś kolo " + 44 + lottery;
            Console.WriteLine(message);

            Console.WriteLine("podaj numer nagrody, a są dwie do wyboru");
            string userValue = Console.ReadLine();
            string newMessage = (userValue == "1") ? "1:Fura" : "2:komóra"; //jeżeli user wpisze value 1, newMessage będzie równe pierwszej (będzie TRUE)
            //wartości po "?", jeżeli wartość będzie false (inna) to do newMessage zostanie przypisana druga wartość po ":"
            //Console.Write("wygrałeś: );
            //Console.Write(newMessage);
            Console.WriteLine("wybrałeś liczbę {0}, więc wygrałeś: {1} .", userValue, newMessage); //krótszy zapis dwóch powyższych linijek kodu
            Console.ReadLine(); //klasa Console



        }
    }
}
