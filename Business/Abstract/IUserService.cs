﻿using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int id);

        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
