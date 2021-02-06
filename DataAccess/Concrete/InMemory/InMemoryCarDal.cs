using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Silindi");
        }

        public void GetById()
        {
            Console.WriteLine("ID ile Getirildi");
        }

        public void GetAll()
        {
            Console.WriteLine("Hepsi Getirildi");
        }

        public void Update()
        {
            Console.WriteLine("Güncellendi");
        }

        List<Car> ICarDal.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
