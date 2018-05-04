using System;
using System.IO;
using System.Net;

namespace Video18
{
    class Video18
    {
        static void Main(string[] args)
        {
            string text = "To jest tekst";

         
            WebClient client = new WebClient(); //jeżeli wystąpił błąd bo używana klasa nie jest opisana na początku (using System...)
            //to można użyć skrótu podpowiedzi CTRL+.
            string replay = client.DownloadString("http://msdn.microsoft.com"); //za pomocą dwóch linijek kodu pobieram stronę internetową i zapisuję ją w pliku tekstowym jako html

            Console.WriteLine(replay);
            //System.IO.File.WriteAllText(@"C:\aaTest\teksior.txt", text); //pełen zapis
            File.WriteAllText(@"C:\aaTest\teksior.txt", replay); //ale po użyciu na początku using System.IO możemy skrócić zapis
            //wyszukując klas można użyć w wyszukiwarce- site:msdn.microsoft.com   wtedy wyszkiwane są strony tylko z microsoftu...



            Console.ReadLine();

        }
    }
}
