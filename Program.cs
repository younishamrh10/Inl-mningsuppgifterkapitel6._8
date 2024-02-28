using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skiv in ett helt tal för att beräkna alntal primtal");
            int tal = int.Parse(Console.ReadLine());
            int antal = Metod2(tal);
            Console.WriteLine("De finns " + antal + " primtal mindre än " + tal + ".");
        }

        static int Metod2(int tal)
        {
            int antal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (Metod(i))
                {
                    antal++;
                }
            }
            return antal;
        }

        static bool Metod(int tal)
        {
            int deltal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (tal % i == 0)
                {
                    deltal++;
                }
            }
            return deltal == 0;
        }
    }
}