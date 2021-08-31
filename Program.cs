using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oyuncu 1'in ismini giriniz:");
            string Oyuncu1 = Console.ReadLine();
            Console.WriteLine("Oyuncu 2'nin ismini giriniz");
            string Oyuncu2 = Console.ReadLine();
            Random sayiGen = new Random();
            int zar1 = sayiGen.Next(1, 7);
            int zar2 = sayiGen.Next(1, 7);

            Console.WriteLine("{0}:{1}-{2}:{3}", Oyuncu1,zar1,Oyuncu2,zar2);

            if (zar1 > zar2)
                Console.WriteLine("Tebrikler {0} kazandı", Oyuncu1);
            else if (zar2 > zar1)
                Console.WriteLine("Tebrikler {2} kazandı", Oyuncu2);
            else
                Console.WriteLine("Berabere!!");
            

        }
    }
}
