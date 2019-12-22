using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
 

namespace DataAccessLayer
{
    public class DatabaseContext: DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionBody> QuestionBodies { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerBody>  AnswerBodies { get; set; }


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
