using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var cars in carManager.GetCarDetails())
            {
                Console.WriteLine("Araç İsmi : {0}, Araç Modeli : {1}, Araç Rengi : {2}, Günlük Fiyatı : {3} \n"
                    ,cars.Description,cars.BrandName,cars.ColorName,cars.DailyPrice
                    );
            }
            Console.Read();
        }

        private static void Car()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car {BrandId=10, ColorId=5,  ModelYear=2022, Description="Civic", DailyPrice=19750});
            carManager.Delete(new Car { Id = 10, BrandId = 5, ColorId = 1, ModelYear = 2019, Description = "Megan", DailyPrice = 28974 });
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine("CarId :{0}, CarBrandId :{1}, CarColorId :{2}, CarModelYear: {3}, CarDescription :{4}"
                , cars.Id, cars.BrandId, cars.ColorId, cars.ModelYear, cars.Description);
            }
        }
    }
}
