using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemory());
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine("CarId :{0}, CarBrandId :{1}, CarColorId :{2}, CarModelYear: {3}, CarDescription :{4}"
                ,cars.Id, cars.BrandId, cars.ColorId,cars.ModelYear, cars.Description);   
            }
            Console.Read();
        }
    }
}
