using System;
using System.ComponentModel.DataAnnotations;

namespace AssignmentsAtanga.Areas.Assignments.Models
{
    public class Student
    {

        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a Grade.")]
        public string Grade { get; set; }

        public string Slug => FirstName?.Replace(' ', '-').ToLower() + '-' + Grade?.ToString();
    }
}
