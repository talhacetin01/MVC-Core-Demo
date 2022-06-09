using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IEntityDal<Category>
    {
        List<Category> GetAll();
        Category GetById(int id);
        void AddCategory(Category category);
        void RemoveCategory(Category category);
        void UpdateCategory(Category category);

    }
}
