using System;

namespace PoP_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leva ?");
            double leva = Convert.ToInt32(Console.ReadLine());
            double euro = leva / 1.95583;
            Console.WriteLine(euro);

            // ou

            Console.WriteLine("_leva?");
            var _leva = int.Parse(Console.ReadLine());
            var _euro = _leva / 1.95583;
            Console.WriteLine(_euro);

            Console.ReadKey(); 
        }
    }
}
