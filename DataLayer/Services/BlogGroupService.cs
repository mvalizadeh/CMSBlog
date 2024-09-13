using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer.Services
{
    public class BlogGroupService : IBlogGroupRepository
    {
        CMSBlogContext db = new CMSBlogContext();

        public IEnumerable<BlogGroup> GetAll()
        {
            return db.BlogGroups.ToList();
        }

        public BlogGroup GetById(int id)
        {
            return db.BlogGroups.Find(id);
        }
        public bool Create(BlogGroup entity)
        {
            try
            {
                db.BlogGroups.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(BlogGroup entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(BlogGroup entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
