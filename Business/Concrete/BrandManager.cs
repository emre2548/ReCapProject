using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.Name.Length >= 2)
            {
                _brandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("Araç markası en az 2 karakter olmalıdır");
            }

        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
