using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;


namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        [SecuredOperation("admin, moderator")]
        [ValidationAspect(typeof(BrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        [PerformanceAspect(1)]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);

        }

        [SecuredOperation("admin, moderator")]
        [CacheRemoveAspect("IBrandService.Get")]
        [PerformanceAspect(1)]
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        [PerformanceAspect(1)]
        [CacheAspect]
        public IDataResult<List<Brand>> GetAll()
        {
            var list = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(list, Messages.BrandListed);
        }

        [PerformanceAspect(1)]
        [CacheAspect]
        public IDataResult<Brand> GetById(int id)
        {
            var data = _brandDal.Get(b => b.Id == id);
            return new SuccessDataResult<Brand>(data, Messages.BrandGetById);
        }

        [SecuredOperation("admin, moderator")]
        [ValidationAspect(typeof(BrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        [PerformanceAspect(1)]
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
