using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.VoidResults;
using Core.Utilities.Results.Concrete.DataResults;
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
		public IResult Add(Brand brand)
		{
			if(brand.BrandName.Length < 2)
			{
				return new ErrorResult(Messages.InvalidBrandName);
			}
			_iBrandDal.Add(brand);
			return new SuccessResult(Messages.BrandAddedMessage);
		}

		public IResult Delete(Brand brand)
		{

			
			_iBrandDal.Delete(brand);
			return new SuccessResult(Messages.BrandDeletedMessage);
		}

		public IDataResult<List<Brand>> GetAll()
		{
			if (DateTime.Now.Hour == 20)
			{
				return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
			}
			return new SuccessDataResult<List<Brand>>(_iBrandDal.GetAll(), Messages.BrandListedMessage);
		}

		public IDataResult<List<Brand>> GetAllByBrandId(int brandId)
		{
			return new SuccessDataResult<List<Brand>>(_iBrandDal.GetAll(b => b.BrandID == brandId));
		}

		public IResult Update(Brand brand)
		{
			_iBrandDal.Update(brand);
			return new SuccessResult(Messages.BrandUpdatedMessage);
		}
	}
}
