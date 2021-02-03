using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{BrandId=1,CarId=1,ColorId=125,DailyPrice=100000,Description="TÜM BAKIMLARI YAPILMIŞTIR",ModelYear=2012},
            new Car{BrandId=1,CarId=2,ColorId=115,DailyPrice=90000,Description="BASKI BALATA YENİ",ModelYear=2011},
            new Car{BrandId=2,CarId=3,ColorId=135,DailyPrice=110000,Description="TRİGER YENİ",ModelYear=2013},
            new Car{BrandId=2,CarId=4,ColorId=145,DailyPrice=120000,Description="LASTİKLERİ YENİ",ModelYear=2020},
            new Car{BrandId=3,CarId=5,ColorId=155,DailyPrice=140000,Description="TÜM BAKIMLARI YAPILMIŞTIR",ModelYear=2014},
            new Car{BrandId=3,CarId=6,ColorId=165,DailyPrice=160000,Description="TÜM BAKIMLARI YAPILMIŞTIR",ModelYear=2015},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =  _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetById(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        
        }
    }
}
