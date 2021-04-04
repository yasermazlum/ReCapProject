using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        #region CAR MESSAGES STRING
        public static string CarAdded = "Arac basariyla eklendi..";
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
        #endregion

        #region CUSTOMER MESSAGES STRING
        public static string CustomerAdded = "Musteri basariyla eklendi..";
        public static string CustomerDeleted = "Musteri basariyla silindi..";
        public static string CustomerListed = "Musteri listesi getirildi..";
        public static string CustomerUpdated = "Musteri basariyla guncellendi..";

        public static string CustomerGetById = "Istenen Musteri getirildi..";
        #endregion

        #region BRAND MESSAGES STRING
        public static string BrandAdded = "Marka basariyla eklendi..";
        public static string BrandDeleted = "Marka basariyla silindi..";
        public static string BrandUpdated = "Marka basariyla guncellendi..";
        public static string BrandListed = "Marka listesi getirildi..";

        public static string BrandGetById = "Istenen marka getirildi..";
        #endregion

        #region COLOR MESSAGES STRING
        public static string ColorAdded = "Renk basariyla eklendi..";
        public static string ColorDeleted = "Renk basariyla silindi..";
        public static string ColorListed = "Renk listesi getirildi..";
        public static string ColorUpdated = "Renk basariyla guncellendi..";

        public static string ColorGetById = "Istenen arac rengi getirildi..";
        #endregion

        #region RENTAL MESSAGES STRING
        public static string RentalAdded = "Kiralama basariyla atandi..";
        public static string RentalDeleted = "Kiralama olayi silindi..";
        public static string RentalListed = "Kiralanan arac listesi getirildi..";
        public static string RentalUpdated = "Kiralama basariyla guncellendi..";

        public static string RentalGetById = "Istenilen kiralama basariyla getirildi..";
        #endregion

        #region USER MESSAGES STRING
        public static string UserAdded = "Kullanici basariyla eklendi..";
        public static string UserDeleted = "Kullanici basariyla silindi..";
        public static string UsersListed = "Kullanici listesi getirildi..";
        public static string UserUpdated = "Kullanici basariyla guncellendi..";

        public static string UserGetById = "Istenilen kullanici bilgisi getirildi..";
        #endregion

        #region ERROR MESSAGES STRING 
        public static string MaintenanceTime = "Sunucu suan bakimda. Isteginiz yerine getirilmedi.";
        public static string AuthorizationDenied = "Bu islemi yapmak icin yetkin yok.";
        #endregion

        #region CAR IMAGE MESSAGE STRING
        public static string CarImageAdded = "Arac resmi basarili sekilde eklendi.";
        public static string CarImageDeleted = "Secilen arac resmi silindi.";
        public static string CarImageGetById = "Belirtilen aracin resimleri getirildi.";
        public static string CarImageUpdated = "Secilen arac resmi guncellendi.";
        public static string GetCarImagesByCarId = "Secilen araca gore resimler getirildi.";
        public static string CarImageGetAll = "Tum arac resimleri getirildi.";

        public static string CarCheckImageLimited = "En fazla 5 adet arac eklenebilir.";
        public static object ValidImageFileTypes = "Dosya tipiniz onaylandi.";
        public static string InvalidImageExtension = "Uyumsuz dosya.";


        #endregion
    }
}
