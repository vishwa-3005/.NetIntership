using System.ComponentModel.DataAnnotations;

namespace EFDemo01
{
    class Course
    {
        [Key]
        public int Course_id { get; set; }
        public string Course_name { get; set; }
    }
}
