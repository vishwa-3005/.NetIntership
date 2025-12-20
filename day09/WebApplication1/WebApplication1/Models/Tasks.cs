namespace WebApplication1.Models
{
    public class Tasks
    {
        public int TasksId { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int CourseGroupId { get; set; }
        public CourseGroup CourseGroup { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        //public string TaskTitle { get; set; }
    }
}
