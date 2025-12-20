namespace WebApplication1.Models
{
    public class Mark
    {
        public int MarkId { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int MaxInternalMarks { get; set; } = 40;
        public int MaxTheroyMarks { get; set; } = 40;
        public int MaxTheoryMarks { get; set; } = 20;
    }
}
