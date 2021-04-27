using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.DataResults;
using Core.Utilities.Results.Concrete.VoidResults;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
	public class RentalManager : IRentalService
	{
		IRentalDal _iRentalDal;

		public RentalManager(IRentalDal iRentalDal)
		{
			_iRentalDal = iRentalDal;
		}

		public IResult Add(Rental rental)
		{
			var result = _iRentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate == null);
			if (result.Any())
			{
				return new ErrorResult(Messages.CarNotAddedMessage);
			}

			_iRentalDal.Add(rental);

			return new SuccessResult(Messages.CarAddedMessage);

		}

		public IResult Delete(Rental rental)
		{
			_iRentalDal.Delete(rental);
			return new SuccessResult(Messages.RentalDeletedMessage);
		}

		public IDataResult<List<Rental>> GetAll()
		{
			return new SuccessDataResult<List<Rental>>(_iRentalDal.GetAll());
		}

		public IDataResult<List<Rental>> GetAllByCarId(int carId)
		{
			return new SuccessDataResult<List<Rental>>(_iRentalDal.GetAll(r => r.CarId == carId));
		}

		public IDataResult<List<Rental>> GetAllByCustomerId(int customerId)
		{
			return new SuccessDataResult<List<Rental>>(_iRentalDal.GetAll(r => r.CustomerId == customerId));
		}

		public IDataResult<Rental> GetById(int rentalId)
		{
			return new SuccessDataResult<Rental>(_iRentalDal.Get(r => r.Id == rentalId));
		}

		public IResult Update(Rental rental)
		{
			_iRentalDal.Update(rental);
			return new SuccessResult(Messages.RentalUpdatedMessage);
		}
	}
}
