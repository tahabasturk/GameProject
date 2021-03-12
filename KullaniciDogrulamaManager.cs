using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2
{
    class KullaniciDogrulamaManager:IKullaniciDogrulamaService
    {
        public bool Dogrula(Oyuncu oyuncu)
        {
            if (oyuncu.TcNo==12345 && oyuncu.Ad=="Taha" &&oyuncu.Soyad=="Baştürk"&&oyuncu.DogumYılı==1998)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
