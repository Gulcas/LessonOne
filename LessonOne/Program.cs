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

            string firstString = "pierwyj";
            string secondString = firstString + firstValue;
            Console.WriteLine(firstString + secondString);

            Console.ReadKey();

        }
    }
}
