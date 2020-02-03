using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer
{
    public class DatabaseContext: IdentityDbContext<User>
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseLazyLoadingProxies();


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
       
            builder.Entity<Answer>();
            builder.Entity<Question>();
            builder.Entity<Test>();
        }
    }
}
