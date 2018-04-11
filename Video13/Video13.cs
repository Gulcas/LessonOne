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

            string myString5 = string.Format("{0} = {1}", "First", "Second"); //stosując komendę Format możemy podmieniać stringi
            string myString6 = string.Format("{0:C}", 123.45); // :C oznacza że wstawimy walutę jaka jest obecnie domyślnie ustawiona na komputerze
            string myString7 = string.Format("{0:N}", 1234567890); // :N dodaje separację tysięczną i dziesiętną do liczby
            string myString8 = string.Format("Percentage: {0:P}", .123); //wyświetli liczbę jako %
            string myString9 = string.Format("Phone number: {0:(##) ###-###-###}", 48515345513); //używając # można określić w jakich parach będą wyświetlane liczby, 
                                                                                                 //formatowane są liczby od prawej do lewej, czyli jeżeli wpiszę 
                                                                                                 //więcej liczb niżeli ## to poszerzona zostanie grupa ostatnia od prawej (pierwsza od lewej)
            string myString10 = " Tekst przykładowy  ";
            myString10 = myString10.Substring(6, 3); //stosując taki zapis określamy że ze stringa określonego wcześniej chcemy 3 kolejne znaki począwszy od 6'go
            string myString11 = myString10.ToUpper(); //kapitalizacja stringa
            string myString12 = myString3.Replace(" ", "_"); //podmiana znaków, pierwszy to znak który chcę zamienić (spacja), a drugi to znak na jaki chcę podmienić spację
            string myString13 = myString2.Remove(6, 3); //usunięcie trzech znaków począwszy od znaku 6 w określonym stringu

            string myString14 = ("  Tekst z dwoma spacjami na początku i końcu wiersza  ");
            myString14 = String.Format("Length before: {0} -- Length after: {1}", myString14.Length, myString14.Trim().Length); //funkcja Trim ucina wycina spację
            //w powyższym przykładzie sprawiamy że myString14 najpierw wyrzuci na konsolę ilość wszystkich znaków z stringa14 a potem ilość wszystkich znaków bez uwzględniania spacji

            string myString15 = "";
            for (int i = 0; i < 10; i++)
                myString15 += "--" + i.ToString(); //+= oznacza że biorę oryginalnego string'a i dodaję do niego to co jest po prawej, czyli i skonwertowane do string'a

            StringBuilder myString16 = new StringBuilder(); //stosując funkcję StringBuilder można zrobić to samo co powyżej, ale angażując mniej pamięci
            for (int i = 0; i < 20; i++)
            {
                myString16.Append("--");
                myString16.Append(i);
            }



            Console.WriteLine(myString + myString2);
            Console.WriteLine(myString3 + myString4);
            Console.WriteLine(myString5 + " " + myString6 + " " + myString7 + " " + myString8);
            Console.WriteLine(myString9);
            Console.WriteLine(myString10 + myString11 + myString12);
            Console.WriteLine(myString13);
            Console.WriteLine(myString14);
            Console.WriteLine(myString15);
            Console.WriteLine(myString16);

            Console.ReadLine();
        }
    }
}
