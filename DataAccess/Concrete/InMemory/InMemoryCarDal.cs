using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{

		List<Car> _cars = new List<Car> {

			new Car{CarID = 1, BrandID = 1, ColorID = 3, DailyPrice = 400, Description = "Mercedes Benz", ModelYear = 2018},
			new Car{CarID = 2, BrandID = 1, ColorID = 1, DailyPrice = 200, Description = "BMW", ModelYear = 2018},
			new Car{CarID = 3, BrandID = 2, ColorID = 2, DailyPrice = 600, Description = "Audi", ModelYear = 2018},

		};


		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car CarToDelete = _cars.SingleOrDefault(c => c.CarID == car.CarID);
			_cars.Remove(CarToDelete);
		}

		public Car Get(Expression<Func<Car, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public List<CarDetailDto> GetCarDetails()
		{
			throw new NotImplementedException();
		}

		public List<Car> GetCars()
		{
			return _cars;
		}

		public List<Car> GetCarsById(int CarId)
		{
			return _cars.Where(c => c.CarID == CarId).ToList();
		}

		public void Update(Car car)
		{
			Car CarToUpdate = _cars.SingleOrDefault(c => c.CarID == car.CarID);

			CarToUpdate.BrandID = car.BrandID;
			CarToUpdate.ColorID = car.ColorID;
			CarToUpdate.DailyPrice = car.DailyPrice;
			CarToUpdate.Description = car.Description;
			CarToUpdate.ModelYear = car.ModelYear;
		}
	}
}
