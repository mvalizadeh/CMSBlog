using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IBlogGroupRepository:IDisposable
    {
        IEnumerable<BlogGroup> GetAll();
        BlogGroup GetById(int id);
        bool Create(BlogGroup entity);
        bool Update(BlogGroup entity);
        bool Delete(BlogGroup entity);
        void Save();
    }
}
