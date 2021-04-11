using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

		public void Add(Car car)
		{
			if(car.CarName.Length >= 2 && car.DailyPrice > 0)
			{
				_iCarDal.Add(car);
			}
		}

		public void Delete(Car car)
		{
			_iCarDal.Delete(car);
		}

		public List<Car> GetCars()
		{
			return _iCarDal.GetAll();
		}

		public List<Car> GetCarsByBrandID(int BrandID)
		{
			return _iCarDal.GetAll(car=> car.BrandId == BrandID);
		}

		public List<Car> GetCarsByColorID(int ColorID)
		{
			return _iCarDal.GetAll(car => car.ColorId == ColorID);
		}

		public void Update(Car car)
		{
			_iCarDal.Update(car);
		}
	}
}
