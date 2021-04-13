using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICarService
	{
		public void Add(Car car);
		public void Update(Car car);
		public void Delete(Car car);
		public List<Car> GetCars();
		public List<Car> GetCarsByBrandID(int brandID);
		public List<Car> GetCarsByColorID(int colorID);
		public List<CarDetailDto> GetCarDetails();

	}
}
