using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo02
{
    //[Table("Students")]
    public class Student
        {
            [Key] //Roll_no is primary 
            public int Roll_no { get; set; }
            public string Name { get; set; }

            public List<Course> Courses { get; set; }

    }
}

