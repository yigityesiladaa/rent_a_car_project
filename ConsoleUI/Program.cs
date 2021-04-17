using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarTest();
		}

		private static void CarTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			var result = carManager.GetCarDetails();
			if (result.Success)
			{
				foreach (var car in result.Data)
				{
					Console.WriteLine(
						"Car Name: " + car.CarName
						+ "\nBrand: " + car.BrandName
						+ "\nColor: " + car.ColorName
						+ "\nDaily Price: " + car.DailyPrice + "\n"
					);
				}
			}
			else
			{
				Console.WriteLine(result.Message);
			}
			
		}
	}
}
