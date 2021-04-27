using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IRentalService
	{
		public IResult Add(Rental rental);
		public IResult Update(Rental rental);
		public IResult Delete(Rental rental);
		IDataResult<List<Rental>> GetAll();
		IDataResult<Rental> GetById(int rentalId);
		IDataResult<List<Rental>> GetAllByCustomerId(int customerId);
		IDataResult<List<Rental>> GetAllByCarId(int carId);
	}
}
