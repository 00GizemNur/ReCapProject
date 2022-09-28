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
           //CarTest();
            //CarAdd();
            //CarDelete();
            //CarUpdate();
            //BrandTest();
            //BrandAdd();
            //BrandDelete();
            //BrandUpdate();
            //ColorTest();
            //ColorAdd();
            ColorDelete();
            //ColorUpdate();

        }

        private static void ColorUpdate()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color = new Color { ColorId = 3, ColorName = "Mavi" };
            var result = colorManager.Update(color);
            Console.WriteLine(result.Message);
        }

        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color=new Color { ColorId = 4, ColorName = "Mavi" };
            var result = colorManager.Delete(color);
            Console.WriteLine(result.Message);
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color =new Color { ColorId = 4, ColorName = "Mavi" };
            var result = colorManager.Add(color);
            Console.WriteLine(result.Message);
        }

        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand= brandManager.Update(new Brand { BrandId = 10, BrandName = "Isuzu" });

            Console.WriteLine(brand.Message);
        }

        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = brandManager.Delete(new Brand { BrandId = 11, BrandName = "Toyota" });
            Console.WriteLine(brand.Message);
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand= brandManager.Add(new Brand { BrandId = 11, BrandName = "Toyota" });
            Console.WriteLine(brand.Message);

        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = carManager.Update(new Car { CarId = 31, CarName = "D-Max", BrandId = 10, ColorId = 3, CarDailyPrice = 550, CarDescription = "Benzin,Otomatik", CarModelYear = 2020 });
 
            Console.WriteLine(car.Message);
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = carManager.Delete(new Car { CarId = 32, CarName = "4C Spider", BrandId = 1, ColorId = 1, CarDailyPrice = 650, CarDescription = "Benzin,Otomatik", CarModelYear = 2021 });
           Console.WriteLine(car.Message);
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
          var car = carManager.Add(new Car { CarId = 32, CarName = "4C Spider", BrandId = 1, ColorId = 1, CarDailyPrice = 650, CarDescription = "Benzin,Otomatik", CarModelYear = 2021 });
           
            Console.WriteLine(car.Message);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var colors = colorManager.GetAll();
            foreach (var color in colors.Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brands = brandManager.GetAll();
            foreach (var brand in brands.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach(var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
