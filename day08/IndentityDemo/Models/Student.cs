namespace IndentityDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
