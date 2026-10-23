
using System;
using System.Collections.Generic;

List<Student> students = new List<Student>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Nhap sinh vien thu {i + 1}:");

    Console.Write("Nhap ten: ");
    string name = Console.ReadLine() ?? "";

    int age;
    while (true)
    {
        Console.Write("Nhap tuoi: ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out age) && age > 0)
        {
            break;
        }

        Console.WriteLine("Tuoi phai la so nguyen lon hon 0. Nhap lai!");
    }

    Student student = new Student(name, age);
    students.Add(student);

    Console.WriteLine();
}

Console.WriteLine("DANH SACH SINH VIEN");

for (int i = 0; i < students.Count; i++)
{
    Console.WriteLine($"Sinh vien thu {i + 1}:");
    students[i].DisplayInfo();
}

public class Student
{
    public string Name { get; set; }

    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value), "Tuoi phai lon hon 0!");
            }
        }
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Ten: {Name}");
        Console.WriteLine($"Tuoi: {Age}");
    }
}
