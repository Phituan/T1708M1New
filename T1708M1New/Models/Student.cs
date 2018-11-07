using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace T1708M1New.Models
{
    public class Student
    {
        [Key]
        [Display(Name = "Roll Number")]
        public string RollNumber { get; set; }
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Create At")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Update At")]
        public DateTime UpdatedAt { get; set; }
        [Display(Name = "Status")]
        public Status Status { get; set; }

        public Student()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Status = Status.Actived;
            this.Gender = Gender.Male;
        }
    }

    public enum Status
    {
        Actived = 0,
        Deactived = 1
    }

    public enum Gender
    {
        Male = 1,
        Female = 0,
        Other = 2
    }
}