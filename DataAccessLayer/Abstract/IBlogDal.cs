using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IEntityDal<Blog>
    {
        List<Blog> GetAll();
        Blog GetById(int id);
        void AddBlog(Blog blog);
        void RemoveBlog(Blog blog);
        void UpdateBlog(Blog blog);
    }
}
