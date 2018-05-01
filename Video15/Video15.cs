using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video15
{
    class Video15 //działania na klasach i metodach
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); //tworzenie nowego OBIEKTU klasy CAR, klasa jedynie służy za narzędzie do tworzenie obiektów
            myCar.Make = "Nissan";
            myCar.Model = "Quashqai";
            myCar.Year = 2009;
            myCar.Color = "Black";
            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color); //wyrzucenie na konsolę obiektów utworzonej wcześniej klasy
                                                                                                    // decimal value = DetermineMarketValue(myCar);
                                                                                                    //   Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue()); //wyrzucenie na konsolę wyniku metody klasy myCar, jednocześnie dodając symbol waluty- {0:C}
            Console.ReadLine();
        }
        private static decimal DetermineMarketValue(Car car) //utworzona nowa metoda ułamkowa (decimal), która akceptuje obiekt klasy Car jako parametr wejściowy
            //(muszą one być określone ponieważ metoda pobiera dane z innej klasy)
        {
            decimal carValue = 100.0M;
            //kiedyś można użyć serwisów web do wyszukania bardziej realnej wartości auta
            return carValue;
        }
    }

    class Car //tu została zdefiniowana nowa klasa Car,  która posiada poniżej określone parametry (Klasy są pudełkiem dla metod)
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue() //zdefiniowana metoda wewnątrz klasy car nie potrzebuje by określać parametry wejścia 
            //ponieważ jest utworzona wewnątrz klasy z której potrzebuje parametrów
        {
            decimal carValue; //określenie zmiennej
            if (Year > 2009) //funkcja if sprawdzająca warunek
                carValue = 40000; //przypisanie wartości do zmiennej w przypadku zgodnego warunku
            else
                carValue = 20000; //przypisanie wartości do zmiennej w przypadku niezgodnego warunku

            return carValue;
        }
    }

}
