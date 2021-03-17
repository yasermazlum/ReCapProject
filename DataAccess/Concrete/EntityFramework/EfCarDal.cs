using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapPrjContext ctx = new ReCapPrjContext())
            {
                var addedEntity = ctx.Entry(entity);
                addedEntity.State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapPrjContext ctx = new ReCapPrjContext())
            {
                var deletedEntity = ctx.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapPrjContext ctx = new ReCapPrjContext())
            {
                return ctx.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapPrjContext ctx = new ReCapPrjContext())
            {
                return filter == null ? ctx.Set<Car>().ToList() : ctx.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (ReCapPrjContext ctx = new ReCapPrjContext())
            {
                var updatedEntity = ctx.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
