using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {
        List<Car> _cars;

        public InMemory()
        {
            _cars = new List<Car> {
            new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=953000,ModelYear=2023,Description="Togg Yerli Milli Aracımız"},
            new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=1200000,ModelYear=2023,Description="Golf Spor Arabası"},
            new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=689256,ModelYear=2018,Description="Nissan Jip Rahat Araç"},
            new Car{Id=4,BrandId=4,ColorId=3,DailyPrice=463478,ModelYear=2016,Description="Kamyonet Yük Taşıma Aracı"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int branId)
        {
            return _cars.Where(p => p.BrandId == branId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetail> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
