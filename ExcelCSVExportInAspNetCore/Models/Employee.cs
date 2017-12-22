using System;

namespace ExcelCSVExportInAspNetCore.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public double Salary { get; set; }

        public DateTime JoinedDate { get; set; }
    }
}
