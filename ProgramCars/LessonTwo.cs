using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCars
{
    class LessonTwo
    {
        static void Second(string[] args) //ta apka nie wystartuje bo jest tylko klasą dodatkową nie MAIN
        {
            int aA, bB, cC; //można utworzyć kilka variable int za jednym zamachem,
            aA = 1;
            bB = 2; //CTRL+E CTRL+D -> reformating code on entire document
            cC = 3;
            string porownanie = (aA == 1) ? "Prawda" : "False"; //wartość sprawdzająca, 
                                                                //jeżeli wartość w nawiasach jest prawdą string porownanie będzie wynosił wartość 1 ="prawda{
            Console.WriteLine(porownanie);
            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                    Console.WriteLine("Liczba 7 się znalazła");
                break;
            }

            //Lista array z określoną liczbą elementów
            int[] numery = new int[5]; //utworzona lista array numery z 5 miejscami w niej
            numery[0] = 2;
            numery[1] = 45;
            numery[2] = 34;
            numery[3] = 23;
            numery[4] = 45;
            Console.WriteLine(numery[2]); //wyrzucenie na consolę konkretnego elemtu listy
            Console.WriteLine(numery.Length); //wyrzucenie na consolę informacji ile pól ma dana lista

            //Lista array z nieokreśloną liczbą elementów
            int[] numeryDwa = new int[] { 2, 3, 5, 2, 3, 5 };
            string[] namesy = new string[] { "adam", "ewa000" };

            for (int i = 0; i < numeryDwa.Length; i++) //w ten sposób możemy wyrzucić na ekran wszystkie wartości z listy
            {
                Console.WriteLine(numeryDwa[i]);
            }

            foreach (int num in numeryDwa) //łatwiejszy sposób na wyrzenie na ekran wszystkich wartości z listy
            {
                Console.WriteLine(num);
            }

            string zig = "Rafał " + 
                "Granszewski";
            char[] literki = zig.ToCharArray(); //utworzenie listy pojedyńczych znaków z pośród wcześniej określonego stringa
            Array.Reverse(literki); //to polecenie odwraca znaki z wcześniejszej listy, odwraca ich kolejność pierwsza staje się ostatnią i odwrotnie

            foreach (char zigLiterki in literki) //wykorzystująć pętlę foreach wyrzucam na konsolę wszystkie znaki
            {
                Console.WriteLine(zigLiterki);
            }



            Console.ReadLine();

        }
    }
}
