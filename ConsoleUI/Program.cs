using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            //CarTest();
            //UserTest();
            //ColorTest();
            //CustomerTest();
            //RentalTest();
        }

        static void BrandTest()
        {
            Console.WriteLine("---- Marka Alani ---- \n");
            BrandManager bm = new BrandManager(new EfBrandDal());

            foreach (var item in bm.GetAll().Data)
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
            if (result.Success == true)
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

        static void ColorTest()
        {
            ColorManager cm = new ColorManager(new EfColorDal());
            var result = cm.GetAll();

            foreach (var item in result.Data)
            {
                Console.WriteLine(item.ColorName);
            }
        }

        static void UserTest()
        {
            //User usr1 = new User();
            //usr1.FirstName = "Yaser Mazlum";
            //usr1.LastName = "Ermis";
            //usr1.Email = "yasermazlum@gmail.com";
            //usr1.Password = "12345";

            //User usr2 = new User { FirstName = "Mahsum", LastName = "Ermis", Email = "mahsum@gmail.com", Password = "12345" };

            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();
            //userManager.Add(usr1);
            //userManager.Add(usr2);
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.FirstName);
                }
            }


        }

        static void CustomerTest()
        {
            //Customer customer1 = new Customer {UserId=1, CompanyName="Orjin Bilisim" };
            //Customer customer2 = new Customer {UserId=2, CompanyName="Van Bilisim" };

            CustomerManager cm = new CustomerManager(new EfCustomerDal());
            //cm.Add(customer1);
            //cm.Add(customer2);

            var result = cm.GetAll();

            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CompanyName);
            }
        }

        static void RentalTest()
        {
            //Rental ren1 = new Rental { CarId = 5, CustomerId = 2, RentDate = new DateTime(2021, 03, 19) };
            //Rental ren2 = new Rental { CarId = 6, CustomerId = 1, RentDate = new DateTime(2021, 02, 12) };
            //Rental ren3 = new Rental { CarId = 6, CustomerId = 1, RentDate = new DateTime(2021, 01, 11) };
            //Rental ren4 = new Rental { CarId = 5, CustomerId = 2, RentDate = new DateTime(2021, 03, 13) };
            //Rental ren5 = new Rental { CarId = 11, CustomerId = 3, RentDate = new DateTime(2021, 03, 13) };

            RentalManager rm = new RentalManager(new EfRentalDal());
            //rm.Add(ren1);
            //rm.Add(ren2);
            //rm.Add(ren3);
            //rm.Add(ren4);
            //rm.Add(ren5);

            var result = rm.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CustomerId);
            }
        }
    }
}
