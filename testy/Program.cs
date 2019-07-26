using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj imię ucznia: ");
            string imie = Console.ReadLine();

            Console.Write("Podaj nazwisko ucznia: ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Podaj średnią ucznia: ");
            double srednia = double.Parse(Console.ReadLine());

            if (srednia >= 4.75)
            {
                Console.Write("Uczeń "+ imie + " " + nazwisko + " " + "otrzymuje świadectwo z wyróżnieniem");
            }

           
            Console.ReadLine();
        }
    }
}
