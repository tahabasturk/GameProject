using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2
{
    interface IOyuncuService
    {
        void Ekle(Oyuncu oyuncu);
        void Güncelle(Oyuncu oyuncu);
        void Sil(Oyuncu oyuncu);
    }
}
