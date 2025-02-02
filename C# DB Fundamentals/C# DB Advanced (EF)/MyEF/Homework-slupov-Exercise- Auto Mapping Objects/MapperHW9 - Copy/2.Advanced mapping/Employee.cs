﻿using System;
using System.Collections.Generic;

namespace _2.Advanced_mapping
{
    public class Employee
    {
        public Employee()
        {
            this.Subordinates = new HashSet<Employee>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsOnHoliday { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> Subordinates { get; set; }
    }
}