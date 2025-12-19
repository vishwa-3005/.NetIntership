using System.Text.RegularExpressions;

namespace SMPS
{
    internal class Program
    {
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Role { get; set; } // admin, staff, student
        }

        public class Admin
        {
            public int Id { get; set; }
            public int UserId { get; set; }

            public User User { get; set; }
        }

        public class Staff
        {
            public int Id { get; set; }
            public int UserId { get; set; }

            public User User { get; set; }
        }

        public class Student
        {
            public int Id { get; set; }
            public int UserId { get; set; }

            public int GroupId { get; set; }
            public int CourseId { get; set; }

            public string PRN { get; set; }
            public string MobileNumber { get; set; }

            public User User { get; set; }
            public Group Group { get; set; }
            public Course Course { get; set; }
        }

        public class Course
        {
            public int Id { get; set; }
            public string CourseName { get; set; }
            public string Description { get; set; }
            public string Duration { get; set; }
            public decimal Fees { get; set; }

            public List<Group> Groups { get; set; }
            public List<Subject> Subjects { get; set; }
        }

        public class Group
        {
            public int Id { get; set; }
            public string GroupName { get; set; }

            public int CourseId { get; set; }
            public Course Course { get; set; }
        }

        public class Subject
        {
            public int Id { get; set; }
            public string SubjectName { get; set; }

            public int TheoryMarks { get; set; }
            public int LabMarks { get; set; }
            public int InternalMarks { get; set; }

            public int CourseId { get; set; }
            public Course Course { get; set; }
        }

        public class Task
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime From { get; set; }
            public DateTime To { get; set; }
            public string Status { get; set; } // assigned/in progress/completed

            public int AdminId { get; set; }
            public int StaffId { get; set; }
            public int SubjectId { get; set; }
            public int GroupId { get; set; }

            public Admin Admin { get; set; }
            public Staff Staff { get; set; }
            public Subject Subject { get; set; }
            public Group Group { get; set; }
        }

        public class Mark
        {
            public int Id { get; set; }
            public int StudentId { get; set; }
            public int SubjectId { get; set; }
            public int TaskId { get; set; }

            public int MarksObtained { get; set; }
            public string PassingStatus { get; set; }
            public int Rank { get; set; }

            public Student Student { get; set; }
            public Subject Subject { get; set; }
            public Task Task { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
