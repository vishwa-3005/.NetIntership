namespace ConsoleApp2
{
        public class TaskItem
        {
            public int TaskItemId { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public bool IsCompleted { get; set; }
            public int StaffId { get; set; } //foreign key
            public Staff Staff { get; set; } //navigation property

            //one task to one staff member only
        }
}
