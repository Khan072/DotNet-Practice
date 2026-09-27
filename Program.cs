using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;

                case "2":
                    ViewStudents();
                    break;

                case "3":
                    SearchStudent();
                    break;

                case "4":
                    DeleteStudent();
                    break;

                case "5":
                    Console.WriteLine("Thank you for using Student Management System!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Add Student
    static void AddStudent()
    {
        Console.WriteLine("\n===== ADD STUDENT =====");

        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Student Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Course: ");
        string course = Console.ReadLine();

        Student student = new Student
        {
            Id = id,
            Name = name,
            Age = age,
            Course = course
        };

        students.Add(student);

        Console.WriteLine("\nStudent added successfully!");
    }

    // View Students
    static void ViewStudents()
    {
        Console.WriteLine("\n===== ALL STUDENTS =====");

        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        foreach (Student student in students)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"ID     : {student.Id}");
            Console.WriteLine($"Name   : {student.Name}");
            Console.WriteLine($"Age    : {student.Age}");
            Console.WriteLine($"Course : {student.Course}");
        }
    }

    // Search Student
    static void SearchStudent()
    {
        Console.WriteLine("\n===== SEARCH STUDENT =====");

        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());

        Student foundStudent = students.Find(student => student.Id == id);

        if (foundStudent != null)
        {
            Console.WriteLine("\nStudent Found!");
            Console.WriteLine($"ID     : {foundStudent.Id}");
            Console.WriteLine($"Name   : {foundStudent.Name}");
            Console.WriteLine($"Age    : {foundStudent.Age}");
            Console.WriteLine($"Course : {foundStudent.Course}");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    // Delete Student
    static void DeleteStudent()
    {
        Console.WriteLine("\n===== DELETE STUDENT =====");

        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());

        Student foundStudent = students.Find(student => student.Id == id);

        if (foundStudent != null)
        {
            students.Remove(foundStudent);

            Console.WriteLine("Student deleted successfully!");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}