using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jakub_Olechowski_3_TJ___praca_na_lekcji
{
    class SystemyLiczbowe
    {
        public int Dziesietna { get; set; }
        
        public string DziesietnaNaBinarna(int dzi)
        {
            string bin="";
            while(dzi!=0)
            {
                if (dzi % 2 == 1) bin = bin.Insert(0, "1");
                else bin = bin.Insert(0, "0");
                dzi /= 2;
            }
            return bin;
        }
        public string DziesietnaNaHex(int dzi)
        {
            int wyn;
            string hex = "";
            while (dzi != 0)
            {
                wyn = dzi % 16;
                if (wyn > 9)
                    switch (wyn)
                    {
                        case 10:{ hex = hex.Insert(0, "A"); break; }
                        case 11:{ hex = hex.Insert(0, "B"); break; }
                        case 12:{ hex = hex.Insert(0, "C"); break; }
                        case 13:{ hex = hex.Insert(0, "D"); break; }
                        case 14:{ hex = hex.Insert(0, "E"); break; }
                        case 15:{ hex = hex.Insert(0, "F"); break; }
                    }
                else hex = hex.Insert(0,wyn.ToString());
                dzi /= 16;
            }
            return hex;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SystemyLiczbowe nowaAkcja = new SystemyLiczbowe();
            Console.WriteLine("Podaj liczbe dziesiętną: ");
            nowaAkcja.Dziesietna =int.Parse(Console.ReadLine());
            Console.WriteLine("Binarnie: " + nowaAkcja.DziesietnaNaBinarna(nowaAkcja.Dziesietna));
            Console.WriteLine("Szesnastkowo: " + nowaAkcja.DziesietnaNaHex(nowaAkcja.Dziesietna));
            Console.ReadKey();
        }
    }
}
