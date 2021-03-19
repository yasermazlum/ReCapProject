using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Arac eklendi..";
        public static string CarDontAdded = "Hata! Arac eklenemedi..";

        public static string CarUptaded = "Arac verileri guncellendi..";
        public static string CarNotUptaded = "Hata! Arac verileri guncellenemedi..";

        public static string CarDeleted = "Arac verileri silindi..";
        public static string CarNotDeleted = "Hata! Arac verileri silinemedi..";

        public static string CarListed = "Arac listesi getirildi..";
        public static string CarListedofBrand = "Arac listesi Marka adina gore listelendi..";
        public static string CarListedofColor = "Arac listesi Renk secimine gore siralandi..";
        public static string CarListedofUnitPrice = "Verilen limitlere gore siralandi..";
        public static string CarGetById = "Belirtilen arac getirildi..";
    }
}
