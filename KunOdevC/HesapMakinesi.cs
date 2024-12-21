using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KunOdevC
{
   public class HesapMakinesi
    {
        public static void HesapMakinesiYazdir()
        {
            double num1, num2;
            string operation;

            Console.WriteLine("Basit Hesap Makinesi");

            // Kullanıcıdan iki sayı ve işlem türü alma
            Console.Write("Birinci sayıyı girin: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
            operation = Console.ReadLine();

            // Seçilen işleme göre sonucu hesaplama
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Sonuç: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Sonuç: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Sonuç: {num1 * num2}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Sonuç: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Bölme işlemi sırasında sıfıra bölme hatası.");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }
        }
    }
}
