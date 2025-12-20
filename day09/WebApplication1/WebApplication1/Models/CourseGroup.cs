namespace WebApplication1.Models
{
    public class CourseGroup
    {
        public int CourseGroupId { get; set; }
        public string CourseGroupName { get; set; }
        public int GroupSize { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
