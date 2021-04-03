using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{

		List<Car> _cars = new List<Car> {
			
			new Car{Id = 1, BrandId = 1, ColorId = 3, DailyPrice = 400, Description = "Mercedes Benz", ModelYear = 2018},
			new Car{Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 200, Description = "BMW", ModelYear = 2018},
			new Car{Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 600, Description = "Audi", ModelYear = 2018},
		
		};


		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
			_cars.Remove(CarToDelete);
		}

		public List<Car> GetCars()
		{
			return _cars;
		}

		public List<Car> GetCarsById(int CarId)
		{
			return _cars.Where(c => c.Id == CarId).ToList();
		}

		public void Update(Car car)
		{
			Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

			CarToUpdate.BrandId = car.BrandId;
			CarToUpdate.ColorId = car.ColorId;
			CarToUpdate.DailyPrice = car.DailyPrice;
			CarToUpdate.Description = car.Description;
			CarToUpdate.ModelYear = car.ModelYear;
		}
	}
}
