using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            //CarAdd();
            //CarDelete();
            //CarUpdate();
            //BrandTest();
            //BrandAdd();
            // BrandDelete();
            //BrandUpdate();
            // ColorTest();
            // ColorAdd();
            //ColorDelete();
            //ColorUpdate();

        }

        private static void ColorUpdate()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { ColorId = 3, ColorName = "Mavi" });
        }

        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { ColorId = 4, ColorName = "Mavi" });
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 4, ColorName = "Mavi" });
        }

        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 10, BrandName = "Isuzu" });
        }

        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 11, BrandName = "Toyota" });
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 11, BrandName = "Toyota" });
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId = 31, CarName = "D-Max", BrandId = 10, ColorId = 3, CarDailyPrice = 550, CarDescription = "Benzin,Otomatik", CarModelYear = 2020 });
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { CarId = 32, CarName = "4C Spider", BrandId = 1, ColorId = 1, CarDailyPrice = 650, CarDescription = "Benzin,Otomatik", CarModelYear = 2021 });
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId = 32, CarName = "4C Spider", BrandId = 1, ColorId = 1, CarDailyPrice = 650, CarDescription = "Benzin,Otomatik", CarModelYear = 2021 });
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())

            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())

            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/"+ car.ColorName+ "/" + car.DailyPrice);
            }
        }
    }
}
