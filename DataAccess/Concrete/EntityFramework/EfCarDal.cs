
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : EfEntityRepositoryBase<Car, RentACarProjectContext>, ICarDal
	{
		public List<CarDetailDto> GetCarDetails()
		{
			using (RentACarProjectContext context = new RentACarProjectContext())
			{
				var result = from car in context.Cars
							 join color in context.Colors
							 on car.ColorID equals color.ColorID
							 join brand in context.Brands
							 on car.BrandID equals brand.BrandID
							 select new CarDetailDto
							 {
								 CarID = car.CarID,
								 BrandName = brand.BrandName,
								 ColorName = color.ColorName,
								 CarName = car.CarName,
								 DailyPrice = car.DailyPrice,
								
							 };
				return result.ToList();
			}
		}
	}
}
