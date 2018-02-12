using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 10; //variable int
            int secondValue;
            secondValue = firstValue;  //przekazanie przez wartość z jednej do drugiej variable
            Console.WriteLine(firstValue);
            Console.WriteLine(firstValue + secondValue);

            Console.ReadKey();

            string firstString = "romek";
            string secondString = firstString + " 1001 " + firstValue;
            Console.WriteLine(firstString);
            Console.WriteLine(secondString);

            Console.ReadKey();

            LessonOneClass2 obiektPierwszy = new LessonOneClass2(); //przywołanie obiektu utworzonego w drugiej klasie
            LessonOneClass2 obiektDrugi = new LessonOneClass2();
            obiektDrugi.NazwaKlasy = "jeden"; //określenie parametru utworzonego obiektu
            obiektPierwszy.NazwaKlasy = "dwa";
            
            Console.WriteLine(obiektPierwszy.NazwaKlasy);
            Console.WriteLine(obiektDrugi.NazwaKlasy); //wyrzucenie do konsoli przywołanego wcześniej obiektu
            //którego wcześniej określiliśmy parametr
            

            obiektPierwszy.NazwaKlasy = "zmieniony";
            obiektDrugi = obiektPierwszy; //przekazanie przez referencję

            Console.WriteLine("obiekt pierwszy " + obiektPierwszy.NazwaKlasy); //wyrzenie na konsolę przekazanej wcześniej wartości
            Console.WriteLine("obiekt drugi " + obiektDrugi.NazwaKlasy);

            Console.ReadKey();
        }
    }
}
