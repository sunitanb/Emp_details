﻿namespace EmployeeAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Mobile { get; set; }


        public string CurrentAddress { get; set; }

        public string PermanentAddress { get; set; }

        public string City { get; set; }

        public string Nationality { get; set; }

        public string PINCode { get; set; }
    }
}
