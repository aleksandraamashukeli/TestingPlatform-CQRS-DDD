using System;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace TestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=USER-PC\SQLEXPRESS;Database=TestsAndUsers;Trusted_Connection=True";

            Console.ForegroundColor = ConsoleColor.Green;

 

            Console.ReadLine();
        }

        private static void InitializeData(string cs)
        {
            //using (DatabaseContext database = new DatabaseContext())
            //{
            //    var user = new User() { FirstName = "dimitri", LastName = "beria", UserName = "dimaberia", Password = "dima123" };
            //    database.Users.Add(user);

            //    var test = new Test() { TestName = "first test", TestDescription = "this is first test", User = user };
            //    database.Tests.Add(test);

            //    var question = new Question() { Test = test };
            //    database.Questions.Add(question);

            //    var questionBody = new QuestionBody() { QuestionText = "first question", Question = question };
            //    database.QuestionBodies.Add(questionBody);

            //    var answer = new Answer() { Question = question };
            //    var answerBody = new AnswerBody() { AnswerText = "this is first answer", Answer = answer };

            //    var answer2 = new Answer() { Question = question };
            //    var answerBody2 = new AnswerBody() { AnswerText = "this is sec answer", Answer = answer2 };

            //    var answer3 = new Answer() { Question = question, IsCorrect = true };
            //    var answerBody3 = new AnswerBody() { AnswerText = "this is third answer", Answer = answer3 };

            //    database.Answers.AddRange(answer, answer2, answer3);
            //    database.AnswerBodies.AddRange(answerBody, answerBody2, answerBody3);

            //    database.SaveChanges();

            //}
        }
    }
}
