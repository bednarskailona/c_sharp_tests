﻿using System;
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
            double srednia;
            bool result = double.TryParse(Console.ReadLine(), out srednia);

            if (srednia >= 4.75)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(imie + " " + nazwisko + " " + "świadectwo z wyróżnieniem");
            }

            else if (result == false)
            {
                Console.WriteLine("Podałeś niewłaściwą formę średniej");
            }

            else
            {
                Console.WriteLine(imie + " " + nazwisko + " - świadectwo bez wyróżnienia");
            }

           
            Console.ReadLine();
        }
    }
}
