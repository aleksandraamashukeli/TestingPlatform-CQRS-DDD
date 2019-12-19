﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Question
    {
        public int Id { get; set; }

        public QuestionBody QuestionBody { get; set; }

        public List<Answer> Answers { get; set; }

        public int TestId { get; set; }
        public Test Test { get; set; }

    }
}