using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{// bir iş sınıfı başka sınıfları newlemez
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
          //iş kodları

         return _carDal.GetAll();
            // emoryCarDal ınMemoryCarDal = new InMemoryCarDal(); böyle yaparsan iş kodlarının tamamı memeoryle çalışır
        }
    }
}
