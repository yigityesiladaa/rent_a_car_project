using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IBrandService
	{
		public void Add(Brand brand);
		public void Update(Brand brand);
		public void Delete(Brand brand);
		List<Brand> GetAll();
		List<Brand> GetAllByBrandId(int brandId);
	}
}
