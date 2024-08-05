using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Concrete.InMemory
{// bellekte verimiz var biz onu yönetiyoruz.
    public class InMemoryCarDal : ICarDal
    {// bütün metotların dışında oluşturduğun içn global oldu o yüzden _ ile başladı
        List<Car> _cars;
        // constructor
        public InMemoryCarDal()
        {// bu veriler bir yerden geliyormuş gibi davranıyoruz
            _cars = new List<Car>() { 
            new Car() { Id = 1, BrandId = 1,  ColorId=1,
            DailyPrice=1200000,Description="Yepyeni bir  araba",ModelYear=2020
            },
             new Car() { Id = 2, BrandId = 1,  ColorId=1,
            DailyPrice=1600000,Description="Daha yeni bir  araba",ModelYear=2024
            },
           new Car()   { Id = 3, BrandId = 2,  ColorId=2,
            DailyPrice=800000,Description="Biraz iyi araba",ModelYear=2002
            },
            new Car()  { Id = 4, BrandId = 3,  ColorId=1,
            DailyPrice=1260000,Description="Yepyeni bir  araba",ModelYear=2024
            },
            };
        }
        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
          return _cars; // veritabanını olduğu gibi döndür
        }

        public void GetById(int id)
        {
              throw new NotImplementedException();
        }

        public void Update(Car car)
        {
          
        }
    }
}
