using OOP_Assignment3.Model._2__Online_Course_Enrollment_System;
using OOP_Assignment3.Model._4__Library_System_with_Book_Status_Tracking;
using OOP_Assignment3.Model._4__Library_System_with_Book_Status_Tracking.Enum;
using OOP_Assignment3.Model._5__Task_Tracker_Application;
using OOP_Assignment3.Model._5__Task_Tracker_Application.Enum;
using OOP_Assignment3.Model.Smart_Home_Control_Center;
using OOP_Assignment3.Model.Smart_Home_Control_Center.Enum;
using OOP_Assignment3.Model.Ticket_Booking_System;

namespace OOP_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---||---||---||----- Ticket Booking System -----||---||---||---\n");
            TicketSystem system = new TicketSystem();

            system.AddTicket(new Ticket("Football Match", "A12", TicketType.VIP));
            system.AddTicket(new Ticket("Football Match", "A13", TicketType.Regular));
            system.AddTicket(new Ticket("Cinema show", "C09", TicketType.VIP));
            system.AddTicket(new Ticket("Power Olympiad", "B61", TicketType.Backstage));
            system.AddTicket(new Ticket("Formula One Racing", "D01", TicketType.VIP));

            Console.WriteLine("Accessing ticket with seat A13:");
            Ticket t = system["A13"];
            if (t != null)
                Console.WriteLine(t);
            else
                Console.WriteLine("The Ticket not found.");
            system.CountTicketsByType();

            Console.WriteLine("\n---||---||---||----- Online Course Enrollment System -----||---||---||---\n");

            CourseCatalog CC = new CourseCatalog();
            CC.AddCourse(new VideoCourse("English", "Hussam", Level.Begginer, 30));
            CC.AddCourse(new Course_Enrollment("Arabic", "Said", Level.Advanced));
            CC.AddCourse(new LiveSession("Math", "Ahmed", Level.Intermediate, "12/5 | 2:00 PM"));

            foreach (Level level in Enum.GetValues(typeof(Level)))
            {
                Console.WriteLine($"\n--- {level} Courses ---");

                List<Course_Enrollment> levelCourses = CC[level];

                if (levelCourses.Count == 0)
                {
                    Console.WriteLine("No courses found at this level.");
                    continue;
                }

                foreach (Course_Enrollment course in levelCourses)
                {
                    Console.WriteLine($"Course: {course.Name} | Instructor: {course.Instructor}");

                    if (course is VideoCourse video)
                    {
                        Console.WriteLine($"Type: Video Course | Duration: {video.Duration} hours");
                    }
                    else if (course is LiveSession live)
                    {
                        Console.WriteLine($"Type: Live Session | Schedule: {live.DateTime}");
                    }

                }

            }

            Console.WriteLine("\n---||---||---||----- Smart Home Control Center -----||---||---||---\n");

            SmartHome home = new SmartHome();

            home[DeviceType.Light].TurnOn();
            home[DeviceType.Fan].TurnOn();
            home[DeviceType.AC].TurnOff();


            Console.WriteLine("--- Device Status ---");
            home[DeviceType.Light].ShowStatus();
            home[DeviceType.Fan].ShowStatus();
            home[DeviceType.AC].ShowStatus();
            home[DeviceType.Heater].ShowStatus();

            Console.WriteLine("\n---||---||---||----- Library System with Book Status Tracking -----||---||---||---\n");

            Library library = new Library();

            library.AddBook(new Book("Nomouth and I Must Scream", "Harlan Ellison"));
            library.AddBook(new Book("Blood Meridian", "Cormac McCarthy"));
            library.AddBook(new Book("All Tomorrow", "C.M. Kösemen"));
            library.AddBook(new Book("Man After Man", "Dougal Dixon"));
            library.AddBook(new Book("Moby Dick", "Herman Melville"));

            Console.WriteLine("\nAccessing book '1984':");
            Console.WriteLine(library["1984"]);

            library.ChangeStatus("1984", BookStatus.CheckedOut);
            library.ChangeStatus("Moby Dick", BookStatus.Reserved);

            Console.WriteLine();
            library.ShowBooksByStatus(BookStatus.Available);
            Console.WriteLine();
            library.ShowBooksByStatus(BookStatus.CheckedOut);
            Console.WriteLine();
            library.ShowBooksByStatus(BookStatus.Reserved);

            Console.WriteLine("\n---||---||---||----- Task Tracker Application -----||---||---||---\n");

            TaskList taskList = new TaskList();


            taskList.AddTask(new Task_Track("Finish Assignment", "Complete C# assignment OOP2", TaskPriority.High));
            taskList.AddTask(new Task_Track("Grocery Shopping", "Buy vegetables and fruits", TaskPriority.Medium));
            taskList.AddTask(new Task_Track("Workout", "30 mins morning exercise", TaskPriority.Low));
            taskList.AddTask(new Task_Track("Read Book", "Read 'Clean Code'", TaskPriority.Medium));

            taskList.ShowAll();
            Console.WriteLine();

            Console.WriteLine("High Priority Tasks:");
            foreach (var task in taskList[TaskPriority.High])
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();

            taskList.MarkComplete("Workout");
            Console.WriteLine();

            taskList.ShowAll();
        }
    }
}
