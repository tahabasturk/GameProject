using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2
{
    class OyuncuManager:IOyuncuService
    {
        IKullaniciDogrulamaService _kullaniciDogrulamaService;
        public OyuncuManager(IKullaniciDogrulamaService kullaniciDogrulamaService)
        {
            _kullaniciDogrulamaService = kullaniciDogrulamaService;
        }
        public void Ekle(Oyuncu oyuncu)
        {
            if (_kullaniciDogrulamaService.Dogrula(oyuncu)==true)
            {
                Console.WriteLine("Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Mernis Sisteminde Böyle bir kişi bulunmamaktadır!!");
            }
        }

        public void Güncelle(Oyuncu oyuncu)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }

        public void Sil(Oyuncu oyuncu)
        {
            Console.WriteLine("Kayıt Silindi");
        }
    }
}
