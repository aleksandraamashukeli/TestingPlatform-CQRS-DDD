using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class DatabaseContext: DbContext
    {
        private string _connectionString { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionBody> QuestionBodies { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerBody>  AnswerBodies { get; set; }

        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
            Database.EnsureCreated();
        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
