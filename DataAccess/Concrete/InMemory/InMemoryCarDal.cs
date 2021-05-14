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
        List<Car> _cars = new List<Car>
         {
        new Car{BrandId=1, ColorId=2, DailyPrice=5000, Description="Mercedes E 250 BlueTEC", Id=1, ModelYear=2019},
        new Car{BrandId=3, ColorId=1, DailyPrice=2750, Description="Volvo S90", Id=2, ModelYear=2018},
        new Car{BrandId=8, ColorId=3, DailyPrice=900,  Description="Ford Focus 1.5 TDCİ Titanium", Id=3, ModelYear=2017},
        new Car{BrandId=4, ColorId=2, DailyPrice=460, Description="Volkwagen cc 1.4 TSI BMT.160 BG exclusive", Id=4, ModelYear=2013}
         };


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int ID)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.Id == ID);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int ID)
        {
            return _cars.Where(c => c.Id == ID).ToList();
        }

        public void Update(int ID, Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c=> c.Id == ID);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
