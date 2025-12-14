using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo02
{
       // [Table("Course")]
            public class Course
        {
            [Key] //course_id is primary key now
            public int Course_id { get; set; }
            public string Course_name { get; set; }

            // Foreign key
            public int StudentId { get; set; }

            // Navigation Property
            public Student Student { get; set; }
    }
}
