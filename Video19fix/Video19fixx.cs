using System;
using System.IO;
using System.Net;

namespace Video19fix
{
    public class Video19fixx
    {
        public string ScrapeWebPage(string url) //utworzona metoda publiczna do wykorzystania w innej klasie,
        {
            return GetWebPage(url); //metoda zwraca adres url wykorzystując metodę prytwaną 
        }

        public string ScapreWebPage(string url, string filePath) //podobnie jak wyżej, tylko zapisuje pobraną stronę do pliku na podstawie danych od użytkownika
        {
            string replay = GetWebPage(url);
            File.WriteAllText(filePath, replay);
            return replay;
        }

        private string GetWebPage(string url) //metoda prywatna do użytku tylko i wyłącznie w tej klasie
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
