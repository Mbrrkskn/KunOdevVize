using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KunOdevC
{
    public class DerstenGecmeHesaplama
    {
        public static void NotOrtalamasiHesaplama()
        {
            // Kullanıcıdan ders notlarını al
            Console.Write("Vize notunu girin: ");
            double vize = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final notunu girin: ");
            double final = Convert.ToDouble(Console.ReadLine());

            // Ortalamayı hesapla (vize %40, final %60)
            double ortalama = (vize * 0.4) + (final * 0.6);

            // Harf notunu belirle
            string harfNotu;

            if (ortalama >= 90)
                harfNotu = "AA";
            else if (ortalama >= 80)
                harfNotu = "BA";
            else if (ortalama >= 70)
                harfNotu = "BB";
            else if (ortalama >= 60)
                harfNotu = "CB";
            else if (ortalama >= 50)
                harfNotu = "CC";
            else if (ortalama >= 40)
                harfNotu = "DC";
            else if (ortalama >= 30)
                harfNotu = "DD";
            else
                harfNotu = "FF";

            // Geçip geçmediği durum
            bool dersiGecti = (harfNotu == "AA" || harfNotu == "BA" || harfNotu == "BB" || harfNotu == "CB" || harfNotu == "CC");

            // Sonuçları yazdır
            Console.WriteLine($"Not ortalamanız: {ortalama}");
            Console.WriteLine($"Harf notunuz: {harfNotu}");
            Console.WriteLine(dersiGecti ? "Dersinizi geçtiniz." : "Dersinizi geçemediniz.");
        }
    }
}