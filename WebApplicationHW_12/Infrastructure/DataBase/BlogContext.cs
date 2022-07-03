using Microsoft.EntityFrameworkCore;
using WebApplicationHW_12.Models.Entity;

namespace WebApplicationHW_12.Infrastructure.DataBase
{
    public class BlogContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = .; Database = HW12; User Id = sa; Password = 123456;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Post>()
            .HasOne<Blog>(s => s.Blog)
            .WithMany(g => g.Posts)
            .HasForeignKey(s => s.BlogID);

            modelBuilder.Entity<Blog>()
                .HasOne<Blogimag>(s => s.blogimage)
                .WithOne(g => g.Blog);


            modelBuilder.Entity<Posttag>()
                  .HasOne<Post>(s => s.post)
                  .WithMany(g => g.PostTags)
                  .HasForeignKey(s => s.PostID);


        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Blogimag> BlogImags { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> Posttags { get; set; }
    }
}
