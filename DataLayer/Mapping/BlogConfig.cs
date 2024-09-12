using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping
{
    internal class BlogConfig : EntityTypeConfiguration<Blog>
    {
        public BlogConfig()
        {
            ToTable("CMSBlog", "Blogs");
            HasRequired(t => t.BlogGroup).WithMany(t => t.Blogs).HasForeignKey(t => t.GroupId).WillCascadeOnDelete(false);
        }
    }
}
