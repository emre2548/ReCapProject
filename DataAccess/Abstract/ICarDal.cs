using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll(); // Ekleyince CAr Manager list<Car> hatası gitti
        void GetById();
        //void GetAll();
        void Add();
        void Update();
        void Delete();
    }
}
