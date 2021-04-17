using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICarService
	{
		public IResult Add(Car car);
		public IResult Update(Car car);
		public IResult Delete(Car car);
		public IDataResult<List<Car>> GetCars();
		public IDataResult<List<Car>> GetCarsByBrandID(int brandID);
		public IDataResult<List<Car>> GetCarsByColorID(int colorID);
		public IDataResult<List<CarDetailDto>> GetCarDetails();

	}
}
