using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, CarModelYear=2020, CarDailyPrice= 350, CarDescription="Dizel,Manuel,5 Kişi & 1 Bagaj,Sedan"},
                 new Car{CarId=2, BrandId=2, ColorId=2, CarModelYear=2021, CarDailyPrice= 550, CarDescription="Dizel,Otomotik,5 Kişi & 3 Bagaj,Sedan"},
                  new Car{CarId=3, BrandId=3, ColorId=2, CarModelYear=2018, CarDailyPrice= 350, CarDescription="Benzin,Manuel,5 Kişi & 2 Bagaj,Hatchback 5 Kapı"},
                   new Car{CarId=4, BrandId=4, ColorId=3, CarModelYear=2022, CarDailyPrice= 650, CarDescription="Dizel,Manuel,5 Kişi & 4 Bagaj,Station Wagon"},
                   new Car{CarId=5, BrandId=5, ColorId=4, CarModelYear=2022, CarDailyPrice= 850, CarDescription="Benzin,Otomatik,5 Kişi & 3 Bagaj,SUV/Jeep"}                   
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarModelYear = car.CarModelYear;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
                

        }
    }
}
