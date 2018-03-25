using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video9
{
    class Video9 //na tym video poruszany jest też temat debugera VisualStudio
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) /*używanie funkcji for, (COUNTER) - tworzę int i któremu przypisuję wartość 0, (CONDITION) - w kolejnej części sprawdzam 
                czy int i jest nadal mniejszy od 10 by wykonać kod znajdujący się w {} i ostatecznie (INCREMENTER) - zwiększam wartość int i o 1 po wykonaniu kodu z nawiasów {}
                czyli COUNTER; CONDITION; INCREMENENTER
                */
            {
                Console.WriteLine(i); //w ten sposób z zastosowaniem pętli for na konsolę zostaną wyrzucone wszystkie liczy 1,2,3...
                if ( i == 7)
                {
                    Console.WriteLine("Znaleziono liczbę {0}", i); //przy okazji trwania pętli for odliczającej od 1 do 10, sprawdzane jest wyrażnie if. 
                    //wyrzucając na konsolę zdanie można użyć zmiennej np int i, wstawiając ją po przecinku.
                    break; //po poprawnym wykonaniu bloku kodu wyrażenia if wychodzimy z pętli for.
                }
            }
            Console.ReadLine();
        }
    }
}
