using System;
using System.Data;
using System.Globalization;

namespace cw1 {
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime currentDateTime = DateTime.Now;
            //DateTime.Now.ToString("HH:mm:ss");
            //Console.WriteLine(currentDateTime);

            //wiem jak pobrać czas z systemu ale nie wiem jak to przerobić żeby obliczyć upływ czasu w sek, dlatego liczba sek jest na sztywno


            int czasWSekundach = 332;
            string sformatowanyCzas = FormatowanieCzasu(czasWSekundach);
            Console.WriteLine(sformatowanyCzas);
        }

        private static string FormatowanieCzasu(int sekundy)
        {
            int godziny = sekundy / 3600;
            int minuty = (sekundy % 3600) / 60;
            int pozostaleSekundy = (sekundy % 3600) % 60;
            string sformatowanyCzas = godziny.ToString("D2") + ":" + minuty.ToString("D2") + ":" + pozostaleSekundy.ToString("D2");
            return sformatowanyCzas;
        }
    }
}