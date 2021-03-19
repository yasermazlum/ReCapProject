using Core.DataAccess;
using Entities.Concrete;
using Entities.DtoConcrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDto> GetAllCarDetails();
    }
}
