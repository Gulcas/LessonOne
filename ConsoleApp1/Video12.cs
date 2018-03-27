using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Video12 //while iteration
    {
        static void Main(string[] args)
        {

            bool displayMenu = true; //przypisuję wartość true do booleana displayMenu
            while (displayMenu) //pętla zapewni możliwość powtarzania działania przywołanej metody, 
                                //wartość bool w nawiasie domyślnie jest true dlatego nie trzeba stosować dłuższego zapisu
                                //czyli displayMenu == true
            {
                displayMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            Console.Clear(); //za każdym ponownym rozpoczęciem kodu zostanie wyczyszczona zawartość konsoli
            Console.WriteLine("Chose an option: ");
            Console.WriteLine("1) Print numbers as you wish");
            Console.WriteLine("2) Guess numbers game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true; //w przypadku wyboru opcji przez użytkownika przywołuje ona konkretną metodę i zwraca wartość true 
                //co zgodnie z założeniami pętli while w metodzie głównej kontynuje pętle
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false; //w przypadku wybrania przez użytkownika tej opcji zwraca ona wartość false co skutkuje 
                //wyjściem z pętli while w metodzie głównej i zakończeniem programu
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers() //utworzona metoda
        {
            Console.Clear();
            Console.WriteLine("Print numbers.");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game");
            Random myRandom = new Random(); //utworzenie randomowej wartośći
            int randomNumber = myRandom.Next(1, 11); //wykorzystuję randomową wartość, przypisuje ją do int i określam jej zakres
            int guesses = 0;
            bool incorrect = true;
            do //pętla do, najpierw wykonywany jest kod wewnątrz niej dopiero potem jest sprawdzany warunek 
            {
                Console.WriteLine("Guess a number between 1 - 10: ");
                string result = Console.ReadLine(); //przypisuję wpis użytkownika do stringa result
                guesses++; //zaraz po wyrzuceniu na konsolę komentarza licznik zgadywań zostaje zwiększony

                if (result == randomNumber.ToString()) //jeżeli wpis użytkownika odpowiada randomowej liczbie skonwertowanej do stringa 
                    //to boolean zmienia wartość na false a co idzie za tym idzie wychodzi z pętli
                    incorrect = false;

                else
                    Console.WriteLine("Guess one more time."); //jeżeli wpis użytkownika jest błędny to boolean się nie zmienia i przechodzi do 

            } while (incorrect);
            Console.WriteLine("Correct. It took {0} guesses", guesses);

            Console.ReadLine();
        }
    }
}
