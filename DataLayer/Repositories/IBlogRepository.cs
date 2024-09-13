using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    internal interface IBlogRepository:IDisposable
    {
        IEnumerable<Blog> GetAll();
        Blog GetById(int id);
        bool Create(Blog entity);
        bool Update(Blog entity);
        bool Delete(Blog entity);
        void Save();
    }
}
