using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DtoConcrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetAllByUnitPrice(decimal min, decimal max);

        IDataResult<Car> GetById(int carId);

        IDataResult<List<CarDto>> GetAllCarDetails();

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
