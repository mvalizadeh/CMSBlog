namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogGroups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.GroupId);
            
            CreateTable(
                "Blogs.CMSBlog",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false),
                        Visit = c.Int(nullable: false),
                        ImageName = c.String(),
                        CreatDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BlogId)
                .ForeignKey("dbo.BlogGroups", t => t.GroupId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "BlogComments.CMSBlog",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        BlogId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Comment = c.String(nullable: false, maxLength: 100),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("Blogs.CMSBlog", t => t.BlogId)
                .Index(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Blogs.CMSBlog", "GroupId", "dbo.BlogGroups");
            DropForeignKey("BlogComments.CMSBlog", "BlogId", "Blogs.CMSBlog");
            DropIndex("BlogComments.CMSBlog", new[] { "BlogId" });
            DropIndex("Blogs.CMSBlog", new[] { "GroupId" });
            DropTable("BlogComments.CMSBlog");
            DropTable("Blogs.CMSBlog");
            DropTable("dbo.BlogGroups");
        }
    }
}
