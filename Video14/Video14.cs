using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video14
{
    class Video14
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now; //data obecna w momencie startu aplikacji
            DateTime myValue2 = new DateTime(1986, 04, 23); //ustawiam wartość datową myValue2 na określoną datę
            DateTime myValue3 = DateTime.Parse("2/13/1991"); //konwersja stringa do wartości daty, podana zgodnie z ustawieniami systemowymi
            TimeSpan myValue4 = DateTime.Now.Subtract(myValue2); //w ten sposób odejmuję od daty obecnej datę wskazaną



            Console.WriteLine(myValue.ToString()); //ToString powoduje że data zostanie wyświetlona zgodnie z ustawieniami systemowymi komputera
            Console.WriteLine(myValue.ToShortDateString()); //różne sposoby wyświetlenia daty i czasu
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine(myValue.AddDays(3).ToLongDateString()); //w tym wierszu dodałem do obecnej daty 3 dni i wyświetliłem ją w dłuższy sposób
            Console.WriteLine(myValue.AddHours(23).ToLongTimeString());
            Console.WriteLine(myValue.AddDays(-3567).ToLongDateString()); //odejmuję dni od daty obecnej
            Console.WriteLine(myValue2.AddDays(32323).ToLongDateString());
            Console.WriteLine(myValue2.AddYears(33).ToLongDateString());
            Console.WriteLine(myValue3);
            Console.WriteLine(myValue4.TotalDays); //dzięki TotalDays widze ile dni wynosi różnica między wcześniejszym odejmowaniem
            Console.WriteLine("{0:n}", myValue4.TotalHours); //dzięki TotalHours wyrzucam różnicę podaną w godzinach i używam separacji tysięcznej

            Console.ReadLine();
        }
    }
}
