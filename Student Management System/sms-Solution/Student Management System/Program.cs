using Student_Management_System;
using System;
using System.Xml.Linq;
using static Student_Management_System.Student;
class Sample
{
    public static void Main(String[] args)
    {
        //Object Creation
        Student studentObj = new Student();
        StudentManager manager = new StudentManager();


        bool Continue = false;
        do
        {
            Console.WriteLine("Welcome to Student Management System");
            Console.WriteLine();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All");
            Console.WriteLine("3. Search");
            Console.WriteLine("4. Update");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Sort The Data");
            Console.WriteLine("7. Filter The Data");
            Console.WriteLine("7. Exit");
            Console.WriteLine();
            Console.Write("Enter Your Option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                //Create
                case 1:
                    Console.WriteLine("Adding Student...");
                    Console.WriteLine();
                    Console.WriteLine("Enter Student Name:");
                    studentObj.Name = Console.ReadLine();

                    Console.WriteLine("Enter Student Age:");
                    studentObj.Age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Student Id:");
                    studentObj.Id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Student Grade (A/B/C/F):");
                    string InputGrade= Console.ReadLine();
                    if (Enum.TryParse(InputGrade, true, out Grade StudGrade))
                    {
                        studentObj.StudGrade= StudGrade;
                    }

                    manager.AddStudent(new Student { Name = studentObj.Name, Age = studentObj.Age, Id = studentObj.Id, StudGrade = studentObj.StudGrade });
                    break;
                //Display
                case 2:
                    Console.WriteLine("Viewing All Students...");

                    manager.DisplayAllStudents();
                    break;
                //Search
                case 3:
                    Console.WriteLine("Enter Student ID To Search: ");
                    int tempID = int.Parse(Console.ReadLine());
                    manager.SearchByIdStudents(tempID);
                    
                    break;
                //Update
                case 4:
                    Console.WriteLine("Enter ID To Be Updated: ");
                    int temp = int.Parse(Console.ReadLine());
                    manager.UpdateStudents(temp);
                    break;
                //Delete
                case 5:
                    Console.WriteLine("Enter Student ID To Be Deleted: ");
                    int delId=int.Parse(Console.ReadLine());
                    manager.DeleteStudents(delId);
                    break;
                case 6:
                    Console.WriteLine("Sorting The List.....");
                    manager.SortingStudents(); 
                    break;
                case 7:
                    Console.WriteLine("Enter The Rank To Be Filter: ");
                    string filterGrade = Console.ReadLine();
                    if (Enum.TryParse(filterGrade, true, out Grade FilterGrade)){
                        manager.FilterStudents(FilterGrade);
                    }
                    break;
                case 8:
                    Console.WriteLine("Exiting... Goodbye!");
                    Continue = false;
                    continue;
            }
            Console.WriteLine("Do You Want To Continue(YES/NO)");
            string DoYouContinue = Console.ReadLine();
            if (DoYouContinue.Equals("YES", StringComparison.OrdinalIgnoreCase))
            {
                Continue = true;
            }
            if (DoYouContinue.Equals("NO", StringComparison.OrdinalIgnoreCase))
            {
                Continue = false;
            } 
        } while (Continue);
        Console.WriteLine("Thanks for using");
    }
}