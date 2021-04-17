using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.DataResults;
using Core.Utilities.Results.Concrete.VoidResults;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarDal _iCarDal;

		public CarManager(ICarDal iCarDal)
		{
			_iCarDal = iCarDal;
		}

		public IResult Add(Car car)
		{
			if(car.CarName.Length >= 2 && car.DailyPrice > 0)
			{
				_iCarDal.Add(car);
				return new SuccessResult(Messages.CarAddedMessage);

			}
			return new ErrorResult(Messages.CarNotAddedMessage);
		}

		public IResult Delete(Car car)
		{
			_iCarDal.Delete(car);
			return new SuccessResult(Messages.CarDeletedMessage);
		}

		public IDataResult<List<CarDetailDto>> GetCarDetails()
		{
			return new SuccessDataResult<List<CarDetailDto>>(_iCarDal.GetCarDetails());
		}

		public IDataResult<List<Car>> GetCars()
		{
			return new SuccessDataResult<List<Car>>(_iCarDal.GetAll());
		}

		public IDataResult<List<Car>> GetCarsByBrandID(int BrandID)
		{
			return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(car=> car.BrandID == BrandID));
		}

		public IDataResult<List<Car>> GetCarsByColorID(int ColorID)
		{
			return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(car => car.ColorID == ColorID));
		}

		public IResult Update(Car car)
		{
			_iCarDal.Update(car);
			return new SuccessResult(Messages.CarUpdatedMessage);
		}
	}
}
