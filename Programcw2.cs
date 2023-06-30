using System;
namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            //wzor |AB| = pierwiastek z (x2-x1)^2 + (y2-y1)^2
            
            Oblicz(2, 3, 4, 5);

            double Oblicz(int x1, int x2, int y1, int y2)
            {
                int nawiasX = x2 - x1;
                int nawiasY = y2 - y1;
                double potegaX = Math.Pow(nawiasX, 2);
                double potegaY = Math.Pow(nawiasY, 2);
                double wynik = Math.Sqrt(potegaX + potegaY);
                Console.WriteLine(wynik);
                return wynik;
                
            }
        }
    }
}