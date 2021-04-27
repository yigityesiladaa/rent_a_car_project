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
		public IDataResult<List<Car>> GetAll();
		public IDataResult<List<Car>> GetAllByBrandID(int brandID);
		public IDataResult<List<Car>> GetAllByColorID(int colorID);
		public IDataResult<List<CarDetailDto>> GetCarDetails();

	}
}
