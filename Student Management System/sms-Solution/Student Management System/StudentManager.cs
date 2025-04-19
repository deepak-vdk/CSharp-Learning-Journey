using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class NoValidDataFoundedException: Exception
    { 
        public NoValidDataFoundedException(string message): base(message)
        {
        }
    }
    class StudentManager
    {
        List<Student> students = new List<Student>();
        //add new elemnt in a list
        public void AddStudent(Student student)
        {
            try
            {
                students.Add(student);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void DisplayAllStudents()
        {
            try
            {
                foreach (Student s in students)
                {
                    Console.WriteLine($"Name: {s.Name}, Age: {s.Age},  Id: {s.Id}, Grade: {s.StudGrade}");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SearchByIdStudents(int Id)
        {
            try
            {
                var searchStudent = students.FirstOrDefault(s => s.Id == Id);
                if (searchStudent == null)
                {
                    throw new NoValidDataFoundedException("No Record Founded");
                }
                else
                {
                    Console.WriteLine(searchStudent);
                }
            }
            catch (NoValidDataFoundedException ex) { 
                Console.WriteLine(ex.Message);
            }
            
        }
        public void UpdateStudents(int Id)
        {
            try
            {
                var searchStudent = students.FirstOrDefault(s => s.Id == Id);
                if (searchStudent == null)
                {
                    Console.WriteLine("Record Not Found");
                }
                else
                {
                    Console.WriteLine("Record Founded");
                    Console.WriteLine();
                    Console.WriteLine("Existing Record" + searchStudent);
                    Console.WriteLine();
                    Console.WriteLine("Enter Data To Update The Record");

                    Console.WriteLine("Enter Student Name: ");
                    searchStudent.Name = Console.ReadLine();


                    Console.WriteLine("Enter Student Age: ");
                    searchStudent.Age = int.Parse(Console.ReadLine());


                    Console.WriteLine("Enter Student Id: ");
                    searchStudent.Id = int.Parse(Console.ReadLine());


                    Console.WriteLine("Enter Student Grade: ");
                    String tempGrade = Console.ReadLine();
                    if (Enum.TryParse(tempGrade, true, out Student.Grade StudGrade))
                    {
                        searchStudent.StudGrade = StudGrade;
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void DeleteStudents(int Id)
        {
            try
            {
                var searchStudent = students.FirstOrDefault(s => s.Id == Id);
                if (searchStudent == null)
                {
                    Console.WriteLine("Record Not Found");
                }
                else
                {
                    students.Remove(searchStudent);
                }
            }
            catch(ArgumentOutOfRangeException ex) 
            {
                    Console.WriteLine(ex.Message);
            }
           
        }
        public void SortingStudents()
        {
            try
            {
                var sortStudent = students.OrderBy(s => s.Name);
                foreach (var student in sortStudent)
                {
                    Console.WriteLine(student);
                }
            }
            catch (OutOfMemoryException ex) {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void FilterStudents(Student.Grade grade)
        {
            try
            {
                var filtergrade = students.Where(g => g.StudGrade.Equals(grade));
                foreach (var student in filtergrade)
                {
                    Console.WriteLine(student);
                }
            }
            catch(OutOfMemoryException ex) {
                Console.WriteLine(ex.Message);
            }
           
        }
    }

}
