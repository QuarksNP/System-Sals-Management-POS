﻿namespace itlapr.Web.Models
{
    public class EmployeesModel
    {
        public int employerId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? position { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
        public string? region { get; set; }
        public int postalCode { get; set; }
        public string? phone { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime hireDate { get; set; }

    }
}
