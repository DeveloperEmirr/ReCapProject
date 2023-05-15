using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();

                //context.Cars.Add(entity); context.SaveChanges();
                //ekleme komutunda üsteki komut da kullanılabilir
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList() //gönderilen bişe yoksa hepsini getir dedik
                    : context.Set<Car>().Where(filter).ToList(); // gönderilen bişey varsa gönderilen veriyi getir dedik
            }
           
        }

        public void Update(Car entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                //var updateEntity = context.Entry(entity);
                //updateEntity.State = EntityState.Modified;
                //context.SaveChanges();

                var productToUpdate = context.Cars.SingleOrDefault(p=>p.Id==entity.Id);
                productToUpdate.Id = entity.Id;
                productToUpdate.BrandId = entity.BrandId;
                productToUpdate.ColorId = entity.ColorId;
                productToUpdate.DailyPrice = entity.DailyPrice;
                productToUpdate.Description = entity.Description;
                productToUpdate.ModelYear = entity.ModelYear;
                context.SaveChanges();
            }
        }
    }
}
