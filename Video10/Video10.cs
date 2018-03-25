using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video10
{
    class Video10 //listy array, for, foreach, reverse array
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; //lista array int z określoną ilością miejsc - 5
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine("wartość 2 kubełka listy array " + numbers[1]); //wyrzucam na konsolę konkretną pozycję z listy aray
            Console.ReadLine();
            Console.WriteLine("lista array ma " + numbers.Length + " pozycji"); //wyrzucam długość listy array na konsolę
            Console.ReadLine();

            int[] numbers2 = new int[] { 24, 8, 15, 16, 23, 42 }; //lista array int z nieokreśloną ilością miejsc
            string[] names = new string[] { "Ania", "Alicja", "Anastazja"}; //lista array string

            for (int i = 0; i < names.Length; i++) //tworzę pętlę for któej warunkeim jest int i mniejsze od długości listy array names
            {
                Console.WriteLine("pętla for wyrzucająca wartości listy na konsolę: " + names[i]); //teraz wyrzucam na konsolę po kolei wszystkie pola listy array names
            }
            Console.ReadLine();

            foreach (string name in names) //pętla for each tworzy tymczasowy string name z poszczególnych kubełków listy array names, 
                //poczym wyrzucan to na konsolę, string po stringu aż wyrzuci wszystkie pozycje
            {
                Console.WriteLine("pętla foreach wyrzucająca wartości listy na konsolę: " + name);
            }
            Console.ReadLine();

            string zig = "Tekst do odwrócenia kolejności";
            Console.WriteLine(zig);
            char[] charArray = zig.ToCharArray(); //tworzenie listy array pojedyńczych znaków (char) poprzez przekonwertowanie stringa zig na listę char
            foreach (char item in charArray) //wyrzucam wszystkie znaki utworzonego wcześniej zdania
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Array.Reverse(charArray); //teraz wykorzystuję utworzoną wcześniej listę arrach char i odwracam jej kolejność
            foreach (char item in charArray) //następnie wykorzystując pętlę foreach wyrzucam na konsolę znak po znaku
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }
    }
}
