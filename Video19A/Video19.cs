using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video19fix; //odwołanie do utworzonej klasy którą będę wykorzystywał w tym projekcie

namespace Video19A
{
    class Video19
    {
        static void Main(string[] args) //aby dodać referencję do innej klasy-> solution explorer-> references-> ppm-> add ref-> projects...
        {
            Video19fixx myScrape = new Video19fixx();
            string value = myScrape.ScrapeWebPage("http://msdn.microsoft.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
