using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepostoryBase<Color, ReCapProjectContext>, IColorDal
    {
       
    }
}
