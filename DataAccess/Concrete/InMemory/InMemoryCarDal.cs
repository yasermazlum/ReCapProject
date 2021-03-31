using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DtoConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id= 1, BrandId = 1, ColorId = 2, DailyPrice = 24000, ModelYear=2012, Description="Mercedes" },
                new Car{Id= 2, BrandId = 2, ColorId = 1, DailyPrice = 11000, ModelYear=2012, Description="Opel" },
                new Car{Id= 3, BrandId = 3, ColorId = 2, DailyPrice = 12000, ModelYear=2012, Description="BMW" },
                new Car{Id= 4, BrandId = 4, ColorId = 1, DailyPrice = 12500, ModelYear=2012, Description="Ford" },
                new Car{Id= 5, BrandId = 5, ColorId = 3, DailyPrice = 16000, ModelYear=2012, Description="Honda" },
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Arac eklendi. Model Yili: " + car.ModelYear);
        }

        public void Delete(Car car)
        {
            //Car carDelete=null;
            //foreach (var item in _cars)
            //{
            //    if (car.Id == item.Id)
            //    {
            //        carDelete = item;
            //    }
            //}


            //Linq ile 
            Car carDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carDelete);
            Console.WriteLine("Arac silindi.");
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDto> GetAllCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;


            Console.WriteLine("Arac guncellendi. Model Yili: " + car.ModelYear);
        }
    }
}
