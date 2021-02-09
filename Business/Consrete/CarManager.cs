using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Consrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
           if (car.DailyPrice>0 && car.Description.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba başarıyla eklendi.");
            }
           else
            {
                Console.WriteLine("Lütfen günlük fiyat kısmını 0'dan büyük ve en az 2 karakter giriniz.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba başarıyla silindi.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _carDal.GetAll(c => c.BrandId == brandid);
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _carDal.GetAll(c => c.ColorId == colorid);
        }

        public void Update(Car car)
        {
            if(car.DailyPrice > 0 && car.Description.Length>2)
            {
                _carDal.Update(car);
                Console.WriteLine("Araba başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Lütfen günlük fiyat kısmını 0'dan büyük ve en az 2 karakter giriniz.");
            }
        }
    }
}