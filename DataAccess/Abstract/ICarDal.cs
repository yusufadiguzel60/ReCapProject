using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetById(int ID);
        List<Car> GetAll();
        void Add(Car car);
        void Update(int ID, Car car);
        void Delete(int ID);
    }
}
