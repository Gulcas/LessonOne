using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video13
{
    class Video13 //manipulating Strings/ manipulowanie stringami
    {
        static void Main(string[] args)
        {
            string myString = "My \"so-called\" life"; //backslash-\\\\\\\\ pozwala na wstawienie w stringa znaku specjalnego
            string myString2 = "New \n line";
            string myString3 = "To jest backslash- \\"; //wpisując dwa backslache jeden będzie widoczny, 
            //albo można dodać znak @ na początku i C# zignoruje backslashe w tej linijce kodu
            string myString4 = @"\ backslach \ backslash\";

            string myString5 = String.Format("{0} = {1}", "First", "Second"); //stosując komendę Format możemy podmieniać stringi
            string myString6 = String.Format("{0:C}", 123.45); // :C oznacza że wstawimy walutę jaka jest obecnie ustawiona na komputerze
            string myString7 = String.Format("{0:N}", 1234567890); // :N dodaje separację tysięczną i dziesiętną do liczby
            string myString8 = String.Format("Percentage: {0:P}", .123);


            Console.WriteLine(myString + myString2);
            Console.WriteLine(myString3 + myString4);
            Console.WriteLine(myString5 + " " + myString6 + " " + myString7 + " " + myString8);
            Console.ReadLine();
        }
    }
}
