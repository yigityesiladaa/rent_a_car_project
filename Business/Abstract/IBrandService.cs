using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IBrandService
	{
		public IResult Add(Brand brand);
		public IResult Update(Brand brand);
		public IResult Delete(Brand brand);
		IDataResult<List<Brand>> GetAll();
		IDataResult<List<Brand>> GetAllByBrandId(int brandId);
	}
}
