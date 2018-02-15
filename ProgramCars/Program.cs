using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCars //application name
{
    class Program //class
    {
        static void Main(string[] args)     //code block = metod
        {
            Console.WriteLine("Let's know each other.");
            int x; //deklaracja wartości zmiennej x
            /* komentarz wieloliniowy
             */
            x = 7;
            int y = x + 3;
            Console.WriteLine(y);
            Console.WriteLine("Let's find out what is your name.");

            string myName; //utworzony string --> korzystając z CTRL+. można zmienić nazwy wszystkich tych zmiennych
            Console.Write("Type your surname: ");
            string mySurname = Console.ReadLine(); //skrócony zapis kodu wyłapującego dane od usera
            Console.Write("Tape in your name: ");

            for (int i = 0; i < 5; i++)
            {
                myName = Console.ReadLine();

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
            int lottery = Convert.ToInt32(Console.ReadLine()); //wyłapanie int od usera
            string message;
            if (lottery == 1) //nie ma konieczności stosowania {} jeżeli wykonujemy tylko jedną linijkę kodu
                message = "yes it's 1";
            else if (lottery > 1)
                message = "number is to high";
            else
                message = "to small number";
            Console.WriteLine(message);
            Console.ReadLine();



        }
    }
}
