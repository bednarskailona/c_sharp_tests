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


            int i;
            
            for (i=1; i<=3; i++)
            {
                Console.WriteLine();
                Console.Write("Podaj imię ucznia: ");
                string imie = Console.ReadLine();

                Console.Write("Podaj nazwisko ucznia: ");
                string nazwisko = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Podaj średnią ucznia: ");
                double srednia;
                bool result = double.TryParse(Console.ReadLine(), out srednia);

                if (srednia > 6)
                {
                    Console.WriteLine("Średnia nie może być większa od 6. Podaj właściwą średnią");
                }

                else if (srednia < 1)
                {
                    Console.WriteLine("średnia nie może być mniejsza od 1. Podaj właściwą średnią");
                }

                else if (srednia >= 4.75)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(imie + " " + nazwisko + " " + "świadectwo z wyróżnieniem");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                }

                else if (result == false)
                {
                    Console.WriteLine("Podałeś niewłaściwą formę średniej");
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine(imie + " " + nazwisko + " - świadectwo bez wyróżnienia");
                    
                }

            }


            Console.ReadLine();
        }
    }
}
