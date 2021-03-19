using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            CarTest();
        }

        static void BrandTest()
        {
            Console.WriteLine("---- Marka Alani ---- \n");
            BrandManager bm = new BrandManager(new EfBrandDal());

            foreach (var item in bm.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }
            Console.WriteLine("--- Kayitlar listelendi ---");

            Brand brnd = new Brand();
            brnd.BrandName = "Deneme Markasi";

            #region Ekleme alani
            //Console.WriteLine("Yeni deneme markasi olusturuluyor..");            

            //bm.Add(brnd);
            //Console.WriteLine("Deneme markasi sisteme eklendi.");
            //foreach (var item in bm.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}
            #endregion

            #region Guncelleme alani 
            //Console.WriteLine("Guncelleme operasyonu basladi..");
            //bm.Update(new Brand() {Id=1002, BrandName = "Deneme 2 oldu bu"});
            //foreach (var item in bm.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}
            //Console.WriteLine("--- Kayitlar guncellendi ve listelendi ---");
            #endregion

            #region Silme alani             
            //foreach (var item in bm.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}
            //Console.WriteLine("Silme operasyonu basladi..");
            //bm.Delete(new Brand() { Id = 1002 });
            //Console.WriteLine("ID=1002 kaydi silindi..");
            //foreach (var item in bm.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}
            #endregion


        }

        static void CarTest()
        {
            Console.WriteLine("---- Araba Alani ---- \n");
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAllCarDetails();
            if (result.Success==true)
            {
                foreach (var item in carManager.GetAllCarDetails().Data)
                {
                    Console.WriteLine("Adi:{0} - Markasi:{1} - Rengi:{2} - Fiyati:{3}", item.CarName, item.BrandName, item.ColorName, item.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
