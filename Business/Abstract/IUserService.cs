﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUsersById(int id);
        IResult Add(User entity);
        IResult Delete(User entity);
        IResult Update(User entity);
    }
}
