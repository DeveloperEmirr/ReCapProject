using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
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

        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(),car);
                _cardal.Add(car);
                return new SuccesResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            if (car.Id != 0)
            {

                _cardal.Delete(car);
                return new SuccesResult(Messages.CarDeleted);
            }
            else
            {
                return new ErrorResult(Messages.CarDeletedInvalid);
            }
        }

        public IResult Update(Car car)
        {
            if (car.Description.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            else
            {
                _cardal.Update(car);
                return new SuccesResult(Messages.CarUptades);
            }
        }
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            
            return new SuccesDataResult<List<Car>>(_cardal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBranID(int id)
        {
            return new SuccesDataResult<List<Car>>(_cardal.GetAll(p=>p.Id==id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccesDataResult<List<Car>>(_cardal.GetAll(p=>p.ColorId==id));
        }

        public IDataResult<List<CarDetail>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResult<List<CarDetail>>(Messages.MaintenanceTime);
            }

            return new SuccesDataResult<List<CarDetail>>(_cardal.GetCarDetails(),Messages.CarListed);
        }
    }
}
