using DataLayer.Mapping;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    internal class CMSBlogContext : DbContext
    {
        DbSet<BlogGroup> BlogGroups { get; set; }
        DbSet<Blog> Blogs { get; set; }
        DbSet<BlogComment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BlogConfig());
            modelBuilder.Configurations.Add(new BlogCommentConfig());
        }
    }
}
