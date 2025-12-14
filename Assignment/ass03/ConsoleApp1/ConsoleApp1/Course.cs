using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
public class Course
        {
            
            public int CourseId { get; set; }
            public string CourseName { get; set; }

            public int StudentId { get; set; } //foreign key
            public Student Student { get; set; } //navigation property
    }

}
