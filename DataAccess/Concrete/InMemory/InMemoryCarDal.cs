using DataAccess.Abstract;
using Entities.Concrete;

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
            //Car carToDelete= null;
            //foreach (var c in _cars)
            //{
            //    if(car.Id == c.Id)
            //    {
            //        carToDelete = c;    
            //    }
            //} bununyerine LINQ kullanıyoruz

            Car carToDelete  = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);  
        }

        public List<Car> GetAll()
        {
          return _cars; // veritabanını olduğu gibi döndür
        }

      


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;  
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.BrandId = car.BrandId;  
            carToUpdate.ColorId = car.ColorId;  

        }

        List<Car> GetById(int id)
        {
            //Car carToGet = _cars.SingleOrDefault(c => c.Id == id);
            //return carToGet;
            return _cars.Where(c => c.Id == id).ToList();
        }

        List<Car> ICarDal.GetById(int id)
        {
            //Car carToGet = _cars.SingleOrDefault(c => c.Id == id);
            //return carToGet;
            return _cars.Where(c => c.Id == id).ToList();
        }
    }
}
