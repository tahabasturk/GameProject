using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            OyuncuManager oyuncuManager = new OyuncuManager(new KullaniciDogrulamaManager());
            oyuncuManager.Ekle(new Oyuncu() { Id = 1, Ad = "Taha", Soyad = "Baştürk", DogumYılı = 1998, TcNo = 12345 });
            Console.ReadLine();
        }
    }
}
