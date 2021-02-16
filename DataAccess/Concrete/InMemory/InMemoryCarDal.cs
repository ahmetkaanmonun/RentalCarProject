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
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=10,ModelYear=1998,Description="Bmw 1.16"},
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=20,ModelYear=2002,Description="Mercedes C180"},
                new Car{Id=3,BrandId=1,ColorId=2,DailyPrice=35,ModelYear=2004,Description="Volvo"},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=40,ModelYear=2010,Description="Renault Hybrid"},
                new Car{Id=5,BrandId=2,ColorId=3,DailyPrice=50,ModelYear=2021,Description="Tesla"}
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(cartoDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car cartoUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            car.Id = cartoUpdate.Id;
            car.BrandId = cartoUpdate.BrandId;
            car.ColorId = cartoUpdate.ColorId;
            car.DailyPrice = cartoUpdate.DailyPrice;
            car.Description = cartoUpdate.Description;
            car.ModelYear = cartoUpdate.ModelYear;
        
        }
    }
}
