using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array - Diziler
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kamp Kursu",
                "Programlamaya Başlangıç","Java","Python" };
            
            //Döngü
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("--Sayfa Sonu--");

            //foreach
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("--Foreach Bitti--");
        }
    }
}
