using System;

namespace W1_IfElse_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruya Manavina Hos Geldiniz!");

            int applePrice = 2, pearPrice = 3, strawberryPrice = 2, bananaPrice = 3, otherPrice = 4;
            Console.WriteLine($"Elma = {applePrice} TL");
            Console.WriteLine($"Armut = {pearPrice} TL");
            Console.WriteLine($"Cilek = {strawberryPrice} TL");
            Console.WriteLine($"Muz = {bananaPrice} TL");
            Console.WriteLine($"Diger butun meyveler = {otherPrice} TL");
            Console.WriteLine();

            Console.Write("Hangi meyveyi satin almak istersiniz? (Elma/Armut/Cilek/Muz/Diger): ");
            string userChoice = Console.ReadLine();

            // Kullanıcının çoklu seçimler arasından bir tanesini seçeceği durumlarda if-else yerine
            // switch-case daha yaygın olarak kullanılmaktadır.

            switch (userChoice.ToLower())
            {
                case "elma":
                    Console.WriteLine("Sectiginiz meyvenin fiyati = " + applePrice + " TL");
                    break;
                case "armut":
                    Console.WriteLine("Sectiginiz meyvenin fiyati = " + pearPrice + " TL");
                    break;
                case "cilek":
                    Console.WriteLine("Sectiginiz meyvenin fiyati = " + strawberryPrice + " TL");
                    break;
                case "muz":
                    Console.WriteLine("Sectiginiz meyvenin fiyati = " + bananaPrice + " TL");
                    break;
                case "diger":
                    Console.WriteLine("Sectiginiz meyvenin fiyati = " + otherPrice + " TL");
                    break;
                default:
                    Console.WriteLine("Hatali giris yaptiniz.");
                    break;
            }
        }
    }
}