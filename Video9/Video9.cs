using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video9
{
    class Video9
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) /*używanie funkcji for, (COUNTER) - tworzę int i któremu przypisuję wartość 0, (CONDITION) - w kolejnej części sprawdzam 
                czy int i jest nadal mniejszy od 10 by wykonać kod znajdujący się w {} i ostatecznie (INCREMENTER) - zwiększam wartość int i o 1 po wykonaniu kodu z nawiasów {}
                czyli COUNTER; CONDITION; INCREMENENTER
                */
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
