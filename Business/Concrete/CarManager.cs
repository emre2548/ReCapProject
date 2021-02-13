using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Constant;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice < 0)
            {
                return new SuccessDataResult(Message.CarInvalidDailyPrice);
            }
  
            return new SuccessDataResult(Message.CarValidDailyPrice);
            

            //_carDal.Add(car);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return _carDal.GetAll();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        List<Car> ICarService.GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
