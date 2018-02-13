using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCars
{
    class Car // dodając na początku sealed, klasa ma zabronione dziediczenie
    {
        private string _brand; //klasa oznaczona jako private może być wykorzystana tylko w tym oknie
        public string brand {
        get { return _brand; }
        set { _brand = value; }
        }

        public string Color { get; set; }

        public Car (string brand, string color)
        {
            _brand = brand;
            Color = color;
       }

        public void DisplayBrand()
        {
            Console.WriteLine("Marka to: ", _brand);
        }
    }
}
