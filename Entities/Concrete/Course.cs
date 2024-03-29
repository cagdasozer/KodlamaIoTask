﻿using KodlamaİoTask.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİoTask.Entities.Concrete
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
    }
}
