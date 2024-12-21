using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KunOdevC
{
    public class SayiTahminOyunu
    {
      
       public static void SayiTahminYazdir()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı tutma
            int userGuess;
            int attempts = 0;

            Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz!");
            Console.WriteLine("1 ile 100 arasında bir sayı tuttum, bakalım tahmin edebilecek misiniz?");

            // Tahmin yapana kadar devam eden döngü
            while (true)
            {
                Console.Write("Tahmininizi girin: ");
                bool isValid = int.TryParse(Console.ReadLine(), out userGuess); // Sayıyı alırken hata kontrolü

                if (!isValid)
                {
                    Console.WriteLine("Geçerli bir sayı girin.");
                    continue;
                }

                attempts++;

                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Daha yüksek bir sayı tahmin edin.");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Daha düşük bir sayı tahmin edin.");
                }
                else
                {
                    Console.WriteLine($"Tebrikler! Doğru tahmin ettiniz. Sayı {secretNumber} idi.");
                    Console.WriteLine($"Toplamda {attempts} denemede doğru cevabı buldunuz.");
                    break;
                }
            }
        }
    }

}

