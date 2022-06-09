﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFCategoryRepository : EntityRepository<Category>, ICategoryDal
    {
        public void AddCategory(Category category)
        {
            
        }

        public void RemoveCategory(Category category)
        {
            
        }

        public void UpdateCategory(Category category)
        {
            
        }
    }
}
