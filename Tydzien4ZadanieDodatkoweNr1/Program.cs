using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien4ZadanieDodatkoweNr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg dowolnych liczb całkowitych odzielonych spacją :");
            // jak do zmiennej myList wrzucic to co poda użytkownik
            var myList = new List<int>();
            var min = myList.Min();
            var max = myList.Max();
            Console.WriteLine($"Najmniejsza liczba to : {min} a największa to : {max} ");
        }
    }
}
