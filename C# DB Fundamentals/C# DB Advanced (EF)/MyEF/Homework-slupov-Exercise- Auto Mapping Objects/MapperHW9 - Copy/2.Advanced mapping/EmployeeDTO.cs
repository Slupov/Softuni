﻿namespace _2.Advanced_mapping
{
    public class EmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"\t- {this.FirstName} {this.LastName} {this.Salary:F2}";
        }
    }
}
