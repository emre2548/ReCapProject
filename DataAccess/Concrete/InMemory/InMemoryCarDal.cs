using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICatrDal
    {
        public void Add(Car entity)
        {
            Console.WriteLine("Eklendi");
        }

        public void Delete(Car entity)
        {
            Console.WriteLine("Silindi");
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Console.WriteLine("Güncellendi");
        }

        List<Car> IEntityRepository<Car>.GetById()
        {
            throw new NotImplementedException();
        }
    }
}
