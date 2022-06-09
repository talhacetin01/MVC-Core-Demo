using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {

        public void AddCategory(Category category)
        {
            using (Context context = new Context())
            {
                context.Add(category);
                context.SaveChanges();
            }    
        }

        public List<Category> GetAll()
        {
            using (Context context = new Context())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetById(int id)
        {
            using (Context context = new Context())
            {
                return context.Categories.Find(id);
            }
        }

        public void RemoveCategory(Category category)
        {
            using (Context context = new Context())
            {
                context.Remove(category);
                context.SaveChanges();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (Context context = new Context())
            {
                context.Update(category);
                context.SaveChanges();
            }
        }
    }
}
