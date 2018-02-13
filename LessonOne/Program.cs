using ProgramCars;
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
            Console.WriteLine(obiektPierwszy.NazwaKlasy);
            obiektDrugi = obiektPierwszy; //przekazanie przez referencję

            Console.WriteLine("obiekt pierwszy " + obiektPierwszy.NazwaKlasy); //wyrzenie na konsolę przekazanej wcześniej wartości
            Console.WriteLine("obiekt drugi " + obiektDrugi.NazwaKlasy);

            Bus bus = new Bus(); //przywołanie klasy z innego projektu dodając referencje do niego-->most łączący oba projekty

            Console.ReadKey();

            double temperatura = 20;

            if (temperatura > 20)  //zastosowanie funkcji if identycznie jak w JAVA
            {
                Console.WriteLine("ciepło");
            }
            else if (temperatura == 21) {
                Console.WriteLine("jest spoko");
            }
            else
            {
                Console.WriteLine("zimno");
                temperatura++;
                Console.WriteLine(temperatura);
            }

            int wartosc = 11;
            switch (wartosc) //pętla switch
            { case 10: Console.WriteLine("wartość jest zła: " + wartosc);
                    break;
                case 11: Console.WriteLine("wartość trafiona: " + wartosc);
                    break;
            }
            
            for (int i = 0; i < 9; i++) { //pętla for
                Console.WriteLine(i);
            }

            int cyferka = 0; 
            List<int> listaInt = new List<int>(); //utworzenie listy
            listaInt.Add(cyferka + 1);
            listaInt.Add(cyferka + 2);
            listaInt.Add(cyferka + 3);
            foreach (int name in listaInt) { //wykorzystanie pętli foreach celem wyrzucenia danych na konsolę
                Console.WriteLine("cyferka: " + name);
            }

            int vartWhile = 1;
            while (vartWhile < 5) { //zastosowanie pętli while
                Console.WriteLine("vartość: " + vartWhile);
                vartWhile++;
            }

            int vartDoPetli = 1;
            do //zastosowanie pętli do, która w przeciwieństwie do innych najpierw wykonuje kod a dopiero później sprawdza warunek
            {
                Console.WriteLine("numerek: " + vartDoPetli);
                vartDoPetli++;
            } while (vartDoPetli < 4);
            


            Console.ReadKey();
        }
    }
}
