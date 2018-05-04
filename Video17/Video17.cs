using System;


namespace Video17
{
    class Video17 //zrozumienie zakresów/ variables scope
    {
        private static string k = "sto milion siedem"; //zmienna dostępna w całej klasie Video17
                                                       //private - metody prywatne mogą być wywołane jedynie przez metody w tej samej klasie
                                                       //public - metody public mogą być wywołane w różnych klasach, są przez nie widoczne

        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.DoSomething(); //przypisanie jedynej widocznej metody- publicznej

            Console.WriteLine(myCar);
            Console.ReadLine();
        }

    }
    class Car
    {
        public void DoSomething() //utworzona metoda publiczna w klasie Car- jest widoczna i w klasie Video17
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod() //utworzona metoda prywatna która widoczna jest jedynie w klasie Car, a w klasie Video17 już nie
        {
            return "siema";
        }
    }
}
