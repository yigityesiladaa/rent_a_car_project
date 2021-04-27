using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.DataResults;
using Core.Utilities.Results.Concrete.VoidResults;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class UserManager : IUserService
	{
		IUserDal _iUserDal;

		public UserManager(IUserDal iUserDal)
		{
			_iUserDal = iUserDal;
		}

		public IResult Add(User user)
		{
			_iUserDal.Add(user);
			return new SuccessResult(Messages.UserAddedMessage);
		}

		public IResult Delete(User user)
		{
			_iUserDal.Delete(user);
			return new SuccessResult(Messages.UserDeletedMessage);
		}

		public IDataResult<List<User>> GetAll()
		{
			return new SuccessDataResult<List<User>>(_iUserDal.GetAll());
		}

		public IDataResult<User> GetById(int userId)
		{
			return new SuccessDataResult<User>(_iUserDal.Get(u => u.Id == userId));
		}


		public IResult Update(User user)
		{
			_iUserDal.Update(user);
			return new SuccessResult(Messages.UserUpdatedMessage);
		}
	}
}
