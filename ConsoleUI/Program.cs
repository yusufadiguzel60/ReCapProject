using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Id = 5;
            car.BrandId = 6;
            car.ColorId = 10;
            car.DailyPrice = 350;
            car.Description = "Peugoet 301";
            car.ModelYear = 2016;


            ICarDal cars = new InMemoryCarDal();
            cars.Add(car);
            cars.Delete(3);
            cars.GetAll();
            cars.GetById(4);
            cars.Update(2, car);
        }
    }
}
