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
			CarTest();
			//RentalTest();



		}
		private static void RentalTest()
		{
			RentalManager rentalManager = new RentalManager(new EfRentalDal());

			var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 4, RentDate = DateTime.Now });

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
			var getCarResult = carManager.GetCarDetails();
			var addCarResult = carManager.Add(new Car { BrandID = 1, CarID = 1, CarName = "Test", ColorID = 1, DailyPrice = 18485, Description = "Test Description", ModelYear = 2016});

			if (addCarResult.Success)
			{
				if (getCarResult.Success)
				{
					foreach (var car in getCarResult.Data)
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
					Console.WriteLine(getCarResult.Message);
				}
			}
			else
			{
				Console.WriteLine(addCarResult.Message);
			}
			
			
			
		}
	}
}
