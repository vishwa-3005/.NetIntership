namespace ConsoleApp2
{

        public class Manager
        {
            public int ManagerId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }

            public List<Staff> staflist { get; set; } = new List<Staff>(); //list of staff members under this manager
            //one manager can have many staff member

        }

}
