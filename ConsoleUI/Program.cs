using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());// ben inmemeroy çalışcam demek

foreach (var car in carManager.GetAll()) {
    Console.WriteLine(  car.Description );  

}
    
