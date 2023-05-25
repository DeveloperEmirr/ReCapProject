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
            //Car();

            //CarTest();

            //CustomerTest();

            RentalAdedTest();
           // RentalGetTest();
            Console.Read();


        }

        private static void RentalGetTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                Console.WriteLine("------------------------------------------------------------------------");
                foreach (var rental in result.Data)
                {
                    Console.WriteLine("Araç İd = {0} Kiralanma Tarihi = {1}", rental.CarId, rental.RentDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalAdedTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result1 = rentalManager.Add(new Rental
            {
                CarId = 5,
                CustomerId = 2,
                RentDate = DateTime.Now,
                ReturnDate= new DateTime(2023,5,27)
            });
            Console.WriteLine(result1.Message);
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer{
            //    CompanyName="Emircan Oto"
            //});
            var result = customerManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                Console.WriteLine("------------------------------------------------------------------------");
                foreach (var customer in result.Data)
                {
                    Console.WriteLine("{0},{1}", customer.CustomerId, customer.CompanyName);
                }
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {

                Console.WriteLine(result.Message);
                Console.WriteLine("------------------------------------------------------------------------");
                foreach (var cars in result.Data)
                {
                    Console.WriteLine("Araç İsmi : {0}, Araç Modeli : {1}, Araç Rengi : {2}, Günlük Fiyatı : {3} \n"
                        , cars.Description, cars.BrandName, cars.ColorName, cars.DailyPrice);
                        
                }
  
            }
            else
            {
                Console.WriteLine(result.Message);    
            }
        }

        //private static void Car()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    //carManager.Add(new Car {BrandId=10, ColorId=5,  ModelYear=2022, Description="Civic", DailyPrice=19750});
        //    carManager.Delete(new Car { Id = 10, BrandId = 5, ColorId = 1, ModelYear = 2019, Description = "Megan", DailyPrice = 28974 });
        //    foreach (var cars in carManager.GetAll())
        //    {
        //        Console.WriteLine("CarId :{0}, CarBrandId :{1}, CarColorId :{2}, CarModelYear: {3}, CarDescription :{4}"
        //        , cars.Id, cars.BrandId, cars.ColorId, cars.ModelYear, cars.Description);
        //    }
        //}
    }
}
