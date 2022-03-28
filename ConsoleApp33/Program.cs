using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile chcesz wpisać imion? ");
            int rozmiar = int.Parse(Console.ReadLine());
            string[] imiona = new string[rozmiar]; //tablica string z imionami
            for (int i = 0; i < imiona.Length; i++) //wczytywanie imion
            {
                Console.WriteLine("Podaj {0} imię", i+1);
                imiona[i] = Console.ReadLine();
            }
            for (int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine("Imię {0}",i+1);
                Console.WriteLine(imiona[i]);
            }
            Console.ReadKey();
        }
    }
}
