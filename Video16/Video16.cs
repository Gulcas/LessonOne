using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video16
{
    class Video16
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); //utworzony obiekt klasy Car, w () znajduje się konstruktor w nim można wpisać parametry obiektu, 
            //jeżeli nie zostaną wpisane ustawione zostaną domyślne- 0, a w związku z tym że istnieje już domyślny konstruktor, można utworzyć @Overload constructor

            myCar.Model = "Quashqai";
            myCar.Year = 2009;
            myCar.Color = "Black";


            Car myOtherCar; //utworzony adres/referencja do klasy Car
            myOtherCar = myCar; //przypisanie utworzonego adresu referencji klasy Car do istniejącego już obiektu
            //teraz oba adresy odnoszą się do tego samego obiektu

            Car myThirdCar = new Car("Nissan", "Juke", 2012, "Red");

            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myCar.Model, myCar.Year, myCar.Color);
            Console.WriteLine("{0} {1} {2} {3}", myThirdCar.Make, myThirdCar.Model, myThirdCar.Year, myThirdCar.Color);

            myOtherCar = null; //wykorzystując "null" zrywam połączenie adresu do obiektu klasy Car, teraz zostanie on zgarnięty przez .Net Framework Runtime, 
            //w przypadku gdybym dalej chciał wykorzystać ten adres doprowadziłoby to do NullException i błędu
            //jeżeli utworzony obiekt nie posiada adresu bo np. został określony przez "null" to obiekt też zostanie usunięty
            //wykorzystując "null" zmuszamy Garbage Collector z .Net Framework Runtime by oczyścił pamięć

            Console.ReadLine();

        }
    }
    class Car
    {
        public string Make { get; set; } //deklaruję stringa Make
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car() //utworzyłem domyślny konstruktor
        {
            Make = "Fiat";
        }

        public Car(string make, string model, int year, string color) //tworzę przeładowany konstruktor (@Overload)
        {
            Make = make; //do istniejącego już stringa Make przypisuję parametry wejściowy make
            Model = model;
            Year = year;
            Color = color;
        }
    }
}
