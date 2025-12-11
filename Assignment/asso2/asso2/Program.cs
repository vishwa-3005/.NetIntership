using static System.Formats.Asn1.AsnWriter;

namespace asso2
{
    internal class Program
    {
        class Book
        {
            public int Id { get; set; }
            public String Author { get; set; }
            public string Title { get; set; }
            public Decimal Price { get; set; }

            public void Display()
            {
                Console.WriteLine($"Book name:{Title} || Author name:{Author} || Price:{Price}");
            }
        }

        class Student
        {
            public int RollNo { get; set; }
            public string Name { get; set; }

            public void Display()
            {
                Console.WriteLine($"name: {Name}, rollno: {RollNo}");
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");

                List<Book> list = new List<Book>
            {
                new Book { Id = 1, Author = "P.k.Jamwal", Title = "Life of Py", Price = 100.00m },
                new Book { Id = 2, Author = "J.K. Rowling", Title = "Harry Potter and the Philosopher's Stone", Price = 250.50m },
                new Book { Id = 3, Author = "George Orwell", Title = "1984", Price = 180.25m },
                new Book { Id = 4, Author = "Harper Lee", Title = "To Kill a Mockingbird", Price = 200.00m },
                new Book { Id = 5, Author = "F. Scott Fitzgerald", Title = "The Great Gatsby", Price = 150.75m },
                new Book { Id = 6, Author = "Leo Tolstoy", Title = "War and Peace", Price = 400.00m },
                new Book { Id = 7, Author = "Jane Austen", Title = "Pride and Prejudice", Price = 175.00m },
                new Book { Id = 8, Author = "Mary Shelley", Title = "Frankenstein", Price = 160.00m },
                new Book { Id = 9, Author = "Arthur Conan Doyle", Title = "The Hound of the Baskervilles", Price = 140.00m },
                new Book { Id = 10, Author = "Agatha Christie", Title = "And Then There Were None", Price = 190.00m }
            };

                #region 1a
                //list.Sort((a, b) => a.Price.CompareTo(b.Price));

                //foreach(var b in list)
                //{
                //    b.Display();
                //}
                #endregion

                #region 1b
                //foreach(var book in list)
                //{
                //    if (book.Author.Contains('a'))
                //    {
                //        book.Display();
                //    }
                //}
                #endregion

                #region 1c
                //Console.Write("Enter ID of book to be deleted : ");
                //int id = Convert.ToInt32(Console.ReadLine());
                //bool flag = true;

                //foreach(Book book in list)
                //{
                //    if(book.Id == id)
                //    {
                //        list.Remove(book);
                //        Console.WriteLine("Book removed!");
                //        flag = false;
                //        break;
                //    }
                //}
                //if (flag) Console.WriteLine("Book Not Found!");

                #endregion

                Dictionary<int, string> studentList = new Dictionary<int, string>
            {
                {1, "Vishwadeep" },
                {2, "Varad" },
                {3, "Prafull" },
                {4, "Swapnil" },
                {5, "Aditya" },
                {6, "Priyanka" },
                {7, "Sandeep" },
                {8, "Shweta" },
                {9, "Shrushti" },
                {10, "Vaishnavi" }
            };

                #region 2
                int rn = Convert.ToInt32(Console.ReadLine());
                if (studentList[rn] != "")
                {
                    Console.WriteLine(studentList[rn]);
                }
                else Console.WriteLine("Student not found!");

                List<Student> students = new List<Student>();
                foreach (var s in studentList)
                {
                    Student student = new Student();
                    student.RollNo = s.Key; student.Name = s.Value;
                    students.Add(student);
                }

                students.Sort((a, b) => a.Name.CompareTo(b.Name));

                foreach (var s in students)
                {
                    s.Display();
                }
                #endregion
            }
        }
    }
}
