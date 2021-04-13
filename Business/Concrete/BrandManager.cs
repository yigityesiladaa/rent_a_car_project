using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class BrandManager : IBrandService
	{
		IBrandDal _iBrandDal;

		public BrandManager(IBrandDal iBrandDal)
		{
			_iBrandDal = iBrandDal;
		}
		public void Add(Brand brand)
		{
			_iBrandDal.Add(brand);
		}

		public void Delete(Brand brand)
		{
			_iBrandDal.Delete(brand);
		}

		public List<Brand> GetAll()
		{
			return _iBrandDal.GetAll();
		}

		public List<Brand> GetAllByBrandId(int brandId)
		{
			return _iBrandDal.GetAll(b => b.BrandID == brandId);
		}

		public void Update(Brand brand)
		{
			_iBrandDal.Update(brand);
		}
	}
}
