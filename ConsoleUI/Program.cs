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
            //CarTest();

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Car Name : " + car.BrandName);
                Console.WriteLine("Car Brand: " + car.ColorName);
                Console.WriteLine("Daily Price : " + car.DailyPrice);
                Console.WriteLine("Description : " + car.Description);
                Console.WriteLine("Model Year : " + car.ModelYear);
            }


        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}
