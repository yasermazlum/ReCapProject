using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
        //List<Color> GetAll();
        //void Add(Color color);
        //void Update(Color color);
        //void Delete(Color color);
    }
}
