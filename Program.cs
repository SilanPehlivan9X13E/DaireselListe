using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DaireselBaglantılıListe list = new DaireselBaglantılıListe();

            // Ekleme işlemleri
            Console.WriteLine("Sona Ekle");
            list.SonaEkle(9);
            list.SonaEkle(8);
            list.SonaEkle(7);
            list.Goruntule(); 

            Console.WriteLine();

            Console.WriteLine("Eklenti Başlangıcı");
            list.EklentiBaslangıcı(7);
            list.Goruntule(); 

            Console.WriteLine();

            Console.WriteLine("İstenilen Sıradan Ekle");
            list.İstenilenSıradaEkle(9, 9); // 9'un arkasına 9 ekle
            list.Goruntule();  

            Console.WriteLine();


            // Silme işlemleri
            Console.WriteLine("Silme İşlemi");
            list.BastanSil();
            list.Goruntule();  

            Console.WriteLine();

            Console.WriteLine("Sondan Silme");
            list.SondanSil();
            list.Goruntule();  

            Console.WriteLine();

            Console.WriteLine("İstediğin Sıradan Silme");
            list.İstediginSıradanSil(8);
            list.Goruntule();  

            Console.WriteLine();

            Console.WriteLine("İstediğin Sıradan Sil");
            list.İstediginSıradanSil(6); // Bulunamadı
            list.Goruntule();  
            
            Console.ReadKey();
        }

    }

}

