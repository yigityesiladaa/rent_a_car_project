using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IUserService
	{
		public IResult Add(User user);
		public IResult Update(User user);
		public IResult Delete(User user);
		IDataResult<List<User>> GetAll();
		IDataResult<List<User>> GetAllByUserId(int userId);
	}
}
