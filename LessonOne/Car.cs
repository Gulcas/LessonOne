using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    class Car
    {
        private string _brand;
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
