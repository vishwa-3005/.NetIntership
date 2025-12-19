using System.ComponentModel.DataAnnotations;

namespace ScalFoldDemo1.Models
{
    public class Student
    {
        //id, name, email, course
        
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Name is Required!")]
        [StringLength(50, ErrorMessage = "Name can not exceed more than 50 charachters")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Email is Required!")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        public int CourseId { get; set; }
        public Course course { get; set; }
    }
}
