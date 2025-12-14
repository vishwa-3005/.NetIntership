namespace ConsoleApp2
{

        public class Staff
        {
            public int StaffId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public int ManagerId { get; set; } //foreign key 
            public Manager Manager { get; set; }  //navigation property
            //one staff can have one manager

            public List<TaskItem> taskItems { get; set; } = new List<TaskItem>();
        }

}
