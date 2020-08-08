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
			var userInput = Console.ReadLine();
            //to co user wprowadza jest string'iem, więc trzeba teraz to podzielic na liste liczb, ale kazda liczba nadal bedzie string'iem
            string[] listString = userInput.Split();
			//teraz kazdy element listy jest zamieniany z string na int. Docelowe rozwiazanie powinno jeszcze sprawdzać czy user na pewno wprowadzil liczbe (i np. czy liczba nie jest wieksza od maxymalnego inta)
			//obecnie jak user wprowadzi 1 2 test 3 4 pawel 5 to wywali blad
			var myList = listString.Select(x => int.Parse(x));

			var min = myList.Min();
			var max = myList.Max();
			Console.WriteLine($"Najmniejsza liczba to : {min} a największa to : {max} ");
		}
}
	}
