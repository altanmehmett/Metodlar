﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" Tebrikler, Sepete eklendi: " + urun.Adi);           

        }
        public void Ekle2(string urunAdi , string açıklama,double fiyat, int stokAdeti)
        {
            Console.WriteLine(" Tebrikler, Sepete eklendi: " + urunAdi);

        }
    }
}
