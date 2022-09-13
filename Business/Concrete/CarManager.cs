using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();

        }
        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }
        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.CarDailyPrice >= min && c.CarDailyPrice >= max);
        }
        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.CarDailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Yeni Araba Eklendi.");
            }
            else
            {
                Console.WriteLine("Arabanın adı 2 karakterden küçük olmamalı VEYA arabanın günlük fiyatı 0₺'den fazla olmalı!! ");
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba Silindi");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araba Güncellendi");
        }
    }
}
