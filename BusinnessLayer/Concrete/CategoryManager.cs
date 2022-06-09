using BusinnessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository efRepo = new EFCategoryRepository();

        public void AddCategory(Category category)
        {
            efRepo.Insert(category);
        }

        public List<Category> GetAllCategories()
        {
            return efRepo.GetAll();
        }

        public Category GetById(int id)
        {
            return efRepo.GetById(id);
        }

        public void RemoveCategory(Category category)
        {
            efRepo.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
            efRepo.Update(category);
        }
    }
}
