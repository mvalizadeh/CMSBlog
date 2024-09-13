using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class BlogCommentService : IBlogCommentRepository
    {
        CMSBlogContext db = new CMSBlogContext();

        public IEnumerable<BlogComment> GetAll()
        {
            return db.Comments.ToList();
        }

        public BlogComment GetById(int id)
        {
            return db.Comments.Find(id);
        }
        public bool Create(BlogComment entity)
        {
            try
            {
                db.Comments.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(BlogComment entity)
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

        public bool Delete(BlogComment entity)
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
