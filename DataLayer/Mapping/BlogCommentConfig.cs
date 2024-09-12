using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping
{
    internal class BlogCommentConfig : EntityTypeConfiguration<BlogComment>
    {
        public BlogCommentConfig()
        {
            ToTable("CMSBlog", "BlogComments");
            HasRequired(t => t.Blog).WithMany(t => t.BlogComments).HasForeignKey(t => t.BlogId).WillCascadeOnDelete(false);
        }
    }
}
