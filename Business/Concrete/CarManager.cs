using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;
        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length<2 || car.DailyPrice<0)
            {
                Console.WriteLine("Araç İsmi minimum 2 karakter, araç günlük fiyatı geçerli rakam olmalıdır!");
            }
            else
            {
                _cardal.Add(car);
                Console.WriteLine("Araç Başarı İle Eklendi...");

            }
        }

        public void Delete(Car car)
        {
            if (car.Id != 0)
            {
                _cardal.Delete(car);
            }
            else
            {
                Console.WriteLine("Araç İd Boş Girilemez!");
            }
        }

        public void Update(Car car)
        {
            if (car.Description.Length < 2)
            {
                Console.WriteLine("Araç İsmi minimum 2 karakter, araç günlük fiyatı geçerli rakam olmalıdır!");
            }
            else
            {
                _cardal.Update(car);
            }
        }
        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public List<Car> GetCarsByBranID(int id)
        {
            return _cardal.GetAll(p=>p.Id==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _cardal.GetAll(p=>p.ColorId==id);
        }

     
    }
}
