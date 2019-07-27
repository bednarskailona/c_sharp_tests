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

            string imie = "ilona";
            int i;

            Console.WriteLine(imie);
            Console.WriteLine();
            Console.WriteLine("Początek pętli for");
            Console.WriteLine("------------------");

            for (i=0; i<=10; i++)
            {
                Console.WriteLine(imie);
            }

           
            Console.ReadLine();
        }
    }
}
