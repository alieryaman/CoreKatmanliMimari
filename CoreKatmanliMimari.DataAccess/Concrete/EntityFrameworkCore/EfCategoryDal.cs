using CoreKatmanliMimari.core.DataAcsess.EntityFrameworkCore;
using CoreKatmanliMimari.DataAccess.Abstract;
using CoreKatmanliMimari.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatmanliMimari.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, TestProjectDbContext>, ICategoryDal
    {
    }
}
