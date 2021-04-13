using Business.Abstract;
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

		public List<CarDetailDto> GetCarDetails()
		{
			return _iCarDal.GetCarDetails();
		}

		public List<Car> GetCars()
		{
			Console.WriteLine("GetCars Çalıştı");
			return _iCarDal.GetAll();
		}

		public List<Car> GetCarsByBrandID(int BrandID)
		{
			return _iCarDal.GetAll(car=> car.BrandID == BrandID);
		}

		public List<Car> GetCarsByColorID(int ColorID)
		{
			return _iCarDal.GetAll(car => car.ColorID == ColorID);
		}

		public void Update(Car car)
		{
			_iCarDal.Update(car);
		}
	}
}
