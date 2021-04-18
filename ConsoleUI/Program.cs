using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			//CarTest();
			RentalTest();



		}
		private static void RentalTest()
		{
			RentalManager rentalManager = new RentalManager(new EfRentalDal());

			var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 4, RentDate = DateTime.Now, ReturnDate = DateTime.Today });

			if (result.Success)
			{
				Console.WriteLine("Rental Adding Succeed...");
			}
			else
			{
				Console.WriteLine(result.Message);
			}
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
