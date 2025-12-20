namespace WebApplication1.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public int SubjectName { get; set; }
        public int MaxInternalMarks { get; set; } = 40;
        public int MaxTheroyMarks { get; set; } = 40;
        public int MaxTheoryMarks { get; set; } = 20;
        public int PassingPercentTotal { get; set; } = 40;
        public int PassingPercentEachComponent { get; set; } = 40;
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public Mark Mark { get; set; }
    }
}
