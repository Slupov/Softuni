﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _01.Student_System.Models
{
    using System;

    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
            this.Homeworks = new HashSet<Homework>();
            this.Resources = new HashSet<Resource>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Homework> Homeworks { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
