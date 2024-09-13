using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IBlogCommentRepository : IDisposable
    {
        IEnumerable<BlogComment> GetAll();
        BlogComment GetById(int id);
        bool Create(BlogComment entity);
        bool Update(BlogComment entity);
        bool Delete(BlogComment entity);
        void Save();
    }
}
